Imports System.Data.SQLite

Public Class Registro

    Dim conexion As SQLiteConnection = New SQLiteConnection("Data source = Resources/juegoMat.db")
    Dim cmd As SQLiteCommand
    Dim comando As String
    Dim mensaje As String

    Private Sub Registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conexion.Open()
        comando = "SELECT Nick FROM Jugadores"
        cmd = New SQLiteCommand(comando, conexion)
        Dim reader As SQLiteDataReader = cmd.ExecuteReader
        While (reader.Read)
            CBUsers.Items.Add(reader.GetString(0))
        End While
        CBUsers.SelectedIndex = 0
        conexion.Close()
    End Sub

    Private Sub TipoAccion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBReg.CheckedChanged, RBIdent.CheckedChanged

        If RBReg.Checked Then
            comando = "INSERT INTO Jugadores VALUES (?, ?, 0)"
        ElseIf RBIdent.Checked Then
            comando = "SELECT * FROM Jugadores WHERE Nick = ? AND pass = ?"
        End If

        

    End Sub

    Private Sub BEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEntrar.Click
        conexion.Open()
        Dim id As SQLiteParameter = New SQLiteParameter()
        id.Value = CBUsers.Text
        Dim pw As SQLiteParameter = New SQLiteParameter()
        pw.Value = TbPass.Text
        cmd = New SQLiteCommand(comando, conexion)
        cmd.Parameters.Add(id)
        cmd.Parameters.Add(pw)
        

        If RBReg.Checked Then

            Try
                cmd.ExecuteNonQuery()
                mensaje = "Bienvenido " & CBUsers.Text
            Catch ex As SQLiteException
                MsgBox("El usuario ya existe")
            End Try

        ElseIf RBIdent.Checked Then

            Dim reader As SQLiteDataReader = cmd.ExecuteReader
            If reader.Read Then
                If reader.GetString(0) = CBUsers.Text And reader.GetString(1) = TbPass.Text Then
                    mensaje = "Hola otra vez :D"
                    Dim comando2 As String = "UPDATE Jugadores set Visitas = Visitas + 1"
                    Dim cmd2 As SQLiteCommand = New SQLiteCommand(comando2, conexion)
                    cmd2.ExecuteNonQuery()
                    Hide()
                    Tittle.Show()
                End If
            Else
                MsgBox("No existe usuario/contraseña proporcionado")
            End If

        End If



        conexion.Close()
    End Sub

    

    'con = New SQLiteConnection("Data Source=juegoMat.db")
    '    con.Open()
    'Dim comando As String = "SELECT * FROM Jugadores WHERE Nick = ? "
    'Dim cmd As SQLiteCommand = New SQLiteCommand(comando, con)
    'Dim id As SQLiteParameter = New SQLiteParameter()
    '    id.Value = TbTime.Text
    '    cmd.Parameters.Add(id)
    'Dim reader As SQLiteDataReader = cmd.ExecuteReader

    '    If reader.Read Then
    'Dim res As String = reader.GetString(0) & " - " & reader.GetString(1) & " - " & reader.GetInt16(2)
    '        TbTime.Text = res
    '    Else
    '        MsgBox("Raro Raro")
    '    End If    
    
End Class