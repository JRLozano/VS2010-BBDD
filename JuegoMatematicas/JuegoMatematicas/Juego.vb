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
            punt = puntuacion

            'Me.Comment = Interaction.InputBox("Introduce un comentario(No obligatorio)", "Comentario")
            GestionBBDD.InsertarPartida()

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
End Class