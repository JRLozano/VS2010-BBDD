Imports System.Text.RegularExpressions
Imports System.Data.SQLite
Public Class Juego

    Public i As Integer
    Public puntuacion As Integer = 0
    Dim time As String
    Dim min As Integer = CInt(Configuracion.TbTime.Text) - 1
    Dim sec As Integer = 59

    Private Sub LOAD_Juego(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblOp1.Text = Operaciones.Operations(i)
        mensajes.Text = ""
        Timer2.Enabled = True

        Text = "Tiempo: " & min & ":" & sec & " --- " & "Puntuacion: " & puntuacion
    End Sub

    Private Sub CountDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If sec = 1 And min = 0 Then
            Text = "Juego finalizado"
            TbRes1.Enabled = False
            BPause.Enabled = False
            Timer2.Stop()

            'Me.Comment = Interaction.InputBox("Introduce un comentario(No obligatorio)", "Comentario")
            'Me.InsertarPartida()
            'Dim conexion As SQLiteConnection = New SQLiteConnection("Data Source = Resources/juegoMat.db")

            'Dim comando As String = "INSERT INTO Puntuaciones VALUES ('Prueba', 'E', 30, CURRENT_TIMESTAMP, 'PartidaPrueba1')"

            'Dim cmd As SQLiteCommand = New SQLiteCommand(comando, conexion)
            'conexion.Open()
            'cmd.ExecuteNonQuery()
            'conexion.Close()
            MsgBox("Gracias por Jugar!!!")
        Else
            sec -= 1
            If sec = 0 Then
                min -= 1
                sec = 59
            End If
            Text = "Tiempo: " & min & ":" & sec & " --- " & "Puntuacion: " & puntuacion


        End If
    End Sub

    Private Sub PauseGame(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPause.Click

        Timer2.Enabled = False
        Text = "Pausado"
    End Sub

    Private Sub SelectRes1(ByVal sender As Object, ByVal e As System.EventArgs) Handles TbRes1.Click, TbRes1.GotFocus
        TbRes1.SelectAll()
    End Sub

    Private Sub ValidarRes1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbRes1.KeyPress

        If e.KeyChar = ChrW(13) Or e.KeyChar = ChrW(9) Then
            If TbRes1.Text = "" Then
                mensajes.Text = "No puedes dejar el campo vacio"

            ElseIf Regex.IsMatch(TbRes1.Text, "(^-?\d{2}(\.(\d{1,2}?))?$)") Or Regex.IsMatch(TbRes1.Text, "(^-?\d{1,2})") Then
                Dim res As Double = Replace(TbRes1.Text, ".", ",")
                Select Case Operaciones.operation
                    Case "+"
                        If res = Operaciones.n1 + Operaciones.n2 Then
                            puntuacion = puntuacion + 1
                        Else
                            puntuacion = puntuacion - 1
                        End If
                    Case "-"
                        If res = Operaciones.n1 - Operaciones.n2 Then
                            puntuacion = puntuacion + 1
                        Else
                            puntuacion = puntuacion - 1
                        End If
                    Case "*"
                        If res = Operaciones.n1 * Operaciones.n2 Then
                            puntuacion = puntuacion + 1
                        Else
                            puntuacion = puntuacion - 1
                        End If
                    Case "/"
                        If res = Operaciones.n1 / Operaciones.n2 Then
                            puntuacion = puntuacion + 1
                        Else
                            puntuacion = puntuacion - 1
                        End If
                    Case "^"
                        If res = Operaciones.n1 ^ Operaciones.n2 Then
                            puntuacion = puntuacion + 1
                        Else
                            puntuacion = puntuacion - 1
                        End If
                End Select

                Text = "Tiempo: " & min & ":" & sec & " --- " & "Puntuacion: " & puntuacion
                TbRes1.SelectAll()
                lblOp1.Text = Operaciones.Operations(i)

            Else
                TbRes1.Text = ""
                mensajes.Text = "Solo numeros validos"
            End If
            'Else
            '    TbRes1.Text = ""
            '    mensajes.Text = "Solo acepta numeros, comas y simbolos de negativo"
        End If
    End Sub

    
    Public nick As String = "Prueba"
    Public difficult As Char
    Public Comment As String = ""


    'Public Sub InsertarPartida()
    '    Dim conexion As SQLiteConnection = New SQLiteConnection("Data Source = Resources/juegoMat.db")
    '    conexion.Open()
    '    Dim comando As String = "INSERT INTO Puntuaciones VALUES ('Prueba', 'E', 30, CURRENT_TIMESTAMP, 'PartidaPrueba1')"
    '    'Dim comando As String = "SELECT * FROM Jugadores"
    '    Dim cmd As SQLiteCommand = New SQLiteCommand(comando, conexion)
    '    'Dim reader As SQLiteDataReader = cmd.ExecuteReader

    '    'If reader.Read Then
    '    '    MsgBox(reader.GetString(0) & " - " & reader.GetString(1) & " - " & reader.GetInt16(2))
    '    'End If



    '    'Dim id As SQLiteParameter = New SQLiteParameter
    '    'id.Value = nick
    '    'Dim dif As SQLiteParameter = New SQLiteParameter
    '    'dif.Value = difficult
    '    'Dim score As SQLiteParameter = New SQLiteParameter
    '    'score.Value = puntuacion
    '    'Dim fec As SQLiteParameter = New SQLiteParameter
    '    'fec.Value = DateAndTime.Now
    '    'Dim com As SQLiteParameter = New SQLiteParameter
    '    'com.Value = "PartidaPrueba1"

    '    'cmd.Parameters.Add(id)
    '    'cmd.Parameters.Add(dif)
    '    'cmd.Parameters.Add(score)
    '    'cmd.Parameters.Add(fec)
    '    'cmd.Parameters.Add(com)
    '    cmd.ExecuteNonQuery()
    '    conexion.Close()
    'End Sub
    

    'Private Sub TbRes2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbRes2.KeyPress
    '    If e.KeyChar = ChrW(13) Or e.KeyChar = ChrW(9) Then
    '        Select Case Operaciones.operation2
    '            Case "+"
    '                If CLng(TbRes2.Text) = Operaciones.n3 + Operaciones.n4 Then
    '                    puntuacion = puntuacion + 1
    '                Else
    '                    puntuacion = puntuacion - 1
    '                End If
    '            Case "-"
    '                If CLng(TbRes2.Text) = Operaciones.n3 - Operaciones.n4 Then
    '                    puntuacion = puntuacion + 1
    '                Else
    '                    puntuacion = puntuacion - 1
    '                End If
    '            Case "*"
    '                If CLng(TbRes2.Text) = Operaciones.n3 * Operaciones.n4 Then
    '                    puntuacion = puntuacion + 1
    '                Else
    '                    puntuacion = puntuacion - 1
    '                End If
    '            Case "/"
    '                If CLng(TbRes2.Text) = Operaciones.n3 / Operaciones.n4 Then
    '                    puntuacion = puntuacion + 1
    '                Else
    '                    puntuacion = puntuacion - 1
    '                End If
    '            Case "^"
    '                If CLng(TbRes2.Text) = Operaciones.n3 ^ Operaciones.n4 Then
    '                    puntuacion = puntuacion + 1
    '                Else
    '                    puntuacion = puntuacion - 1
    '                End If
    '        End Select
    '        BPause.Text = puntuacion
    '        TbRes1.Focus()
    '        lblOp2.Text = Operaciones.Operations2(i)
    '    End If
    'End Sub
    

    'Private Sub TbRes2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbRes2.KeyPress
    'Dim MsgBoxRegex As Regex = New Regex("(^-?\d{2}(\.(\d{1,2}?))?$)")
    'Dim M As Match = MsgBoxRegex.Match(TbRes2.Text)
    'Dim pattern2 As Regex = New Regex("(^-?\d{1,2})")
    'Dim m2 As Match = pattern2.Match(TbRes2.Text)


    'If e.KeyChar = ChrW(13) Then
    '    'If M.Success Or m2.Success Then
    '    If Regex.IsMatch(TbRes2.Text, "(^-?\d{2}(\.(\d{1,2}?))?$)") Or Regex.IsMatch(TbRes2.Text, "(^-?\d{1,2})") Then


    '        MsgBox("bien")
    '    Else
    '        MsgBox("mal")
    '    End If


    'End If

    'End Sub
End Class