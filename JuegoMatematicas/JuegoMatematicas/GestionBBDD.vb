Imports System.Data.SQLite

Module GestionBBDD

    Public Sub ListarJug()
        Dim Jugs(100) As String
        Dim i As Integer = 0

        Using conexion As New SQLiteConnection("Data Source = Resources/juegoMat.db")
            conexion.Open()
            Dim sql As String = "SELECT Nick FROM Jugadores"
            Using cmd As New SQLiteCommand(sql, conexion)
                Dim rdr As SQLiteDataReader = cmd.ExecuteReader
                While (rdr.Read)
                    Registro.CBUsers.Items.Add(rdr.GetString(0))
                End While
            End Using

        End Using
    End Sub

    Public Sub InsertarJug(ByVal Nick, ByVal Pass)
        Using conexion As New SQLiteConnection("Data Source = Resources/juegoMat.db")
            conexion.Open()
            Dim sql As String = "INSERT INTO Jugadores VALUES (@id, @pw, 0)"

            Using cmd As New SQLiteCommand(sql, conexion)
                'cmd.CommandText = "INSERT INTO Jugadores VALUES (@id, @pw, 0)"
                cmd.Parameters.Add(New SQLiteParameter("@id", Nick))
                cmd.Parameters.Add(New SQLiteParameter("@pw", Pass))

                Try
                    cmd.ExecuteNonQuery()
                Catch ex As SQLiteException
                    MsgBox("El usuario ya existe")
                End Try
            End Using
        End Using
    End Sub

    Public Function ValidarJug(ByVal Nick, ByVal Pass) As Boolean
        ValidarJug = False
        Using conexion As New SQLiteConnection("Data Source = Resources/juegoMat.db")
            conexion.Open()
            Dim sql As String = "SELECT * FROM Jugadores"

            Using cmd As New SQLiteCommand(sql, conexion)

                Dim rdr As SQLiteDataReader = cmd.ExecuteReader

                While (rdr.Read)
                    If rdr.GetString(0) = Nick And rdr.GetString(1) = Pass Then
                        ValidarJug = True

                    End If
                End While

            End Using
        End Using
        Return ValidarJug
    End Function

    Public dif As String
    Public punt As Integer
    Public Sub InsertarPartida()
        Using conexion As New SQLiteConnection("Data Source = Resources/juegoMat.db")
            conexion.Open()
            Dim sql As String = "INSERT INTO Puntuaciones VALUES(@id, @df, @punt, @fec, @com)"
            Using cmd As New SQLiteCommand(sql, conexion)
                cmd.Parameters.Add(New SQLiteParameter("@id", Registro.CBUsers.Text))
                cmd.Parameters.Add(New SQLiteParameter("@df", dif))
                cmd.Parameters.Add(New SQLiteParameter("@punt", punt))
                cmd.Parameters.Add(New SQLiteParameter("@fec", DateAndTime.Now))
                cmd.Parameters.Add(New SQLiteParameter("@com", "PruebaPartida1"))

                cmd.ExecuteNonQuery()
            End Using

        End Using
    End Sub

    Public Sub RellenarPuntuaciones()
        Using conexion As New SQLiteConnection("Data Source = Resources/juegoMat.db")
            conexion.Open()

            Dim sql As String = "SELECT * FROM Puntuaciones"
            Dim db As SQLiteDataAdapter = New SQLiteDataAdapter(sql, conexion)
            Dim dt As DataTable = New DataTable
            db.Fill(dt)


            Puntuaciones.DataGridView1.DataSource = dt
        End Using
    End Sub

End Module
