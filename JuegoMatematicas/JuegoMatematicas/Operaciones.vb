Imports System.Math
Imports System.Data.SQLite
'(MinNumber - MaxNumber) * Rnd + MaxNumber)

Module Operaciones

    'Public nick As String
    'Public difficult As Char
    'Public Comment As String = ""

    Dim random As New Random
    Public n1, n2 As Double
    Public operation, operation2 As Char
    Dim simbolo() As Char = {"+", "-", "*", "/", "^"} 'Las posiciones empiezan en 1

    'Public Function Personalizado() As String
    '    Dim aux(5) As Char
    '    Dim i As Integer
    '    Dim Mn As Double = Configuracion.TbMin.Text
    '    Dim Mx As Double = Configuracion.TbMax.Text

    '    If Configuracion.CBoSum.Checked Then
    '        aux(i) = "+"
    '        i += i
    '    End If
    '    If Configuracion.CBoSubs.Checked Then
    '        aux(i) = "-"
    '        i += i
    '    End If
    '    If Configuracion.CBoMult.Checked Then
    '        aux(i) = "*"
    '        i += i
    '    End If
    '    If Configuracion.CBoDiv.Checked Then
    '        aux(i) = "-"
    '        i += i
    '    End If
    '    If Configuracion.CBoPot.Checked Then
    '        aux(i) = "^"
    '        i += i
    '    End If

    '    ReDim Preserve aux(i)
    '    If Not Configuracion.CBotDecs.Checked Then
    '        n1 = random.Next(Mn, Mx)
    '        n2 = random.Next(Mn, Mx)
    '    End If
    '    operation = aux(random.Next(0, aux.Length))


    '    Dim res As String = n1 & " " & operation & " " & n2
    '    If Sign(n2) = -1 Then
    '        res = n1 & " " & operation & " " & "(" & n2 & ")"
    '    End If

    '    Return res
    'End Function

    Public Function Operations(ByVal DIff) As String

        Dim aux(5) As Char
        Dim i As Integer = 1

        Select Case DIff
            Case 1
                n1 = random.Next(0, 50)
                n2 = random.Next(0, 50)
                operation = simbolo(random.Next(0, 2))
            Case 2
                n1 = random.Next(0, 50)
                n2 = random.Next(0, 50)
                operation = simbolo(random.Next(0, 4))

                If operation = "/" And n2 = 0 Then
                    n2 = random.Next(0, 50)
                End If
            Case 3
                'n1 = Round((-50 - 50) * Rnd() + 50, 2)
                'n2 = Round((-50 - 50) * Rnd() + 50, 2)
                n1 = random.Next(-50, 50)
                n2 = random.Next(-50, 50)
                operation = simbolo(random.Next(0, 5))
            Case 4

                Dim Mn As Double = Configuracion.TbMin.Text
                Dim Mx As Double = Configuracion.TbMax.Text

                If Configuracion.CBoSum.Checked Then
                    aux(i) = "+"
                End If
                'MsgBox(i)
                If Configuracion.CBoSubs.Checked Then
                    i = i + 1
                    aux(i) = "-"
                End If
                'MsgBox(i)
                If Configuracion.CBoMult.Checked Then
                    i = i + 1
                    aux(i) = "*"
                End If
                'MsgBox(i)
                If Configuracion.CBoDiv.Checked Then
                    i = i + 1
                    aux(i) = "-"
                End If

                If Configuracion.CBoPot.Checked Then
                    i = i + 1
                    aux(i) = "^"
                End If


                If Not Configuracion.CBotDecs.Checked Then
                    n1 = random.Next(Mn, Mx)
                    n2 = random.Next(Mn, Mx)
                Else
                    n1 = Round(random.Next(Mn, Mx), 1)
                    n2 = Round((Mn - Mx) * Rnd() + Mx, 1)

                End If

                ReDim Preserve aux(i)
                operation = aux(random.Next(1, aux.Length))

                If operation = "/" And n2 = 0 Then
                    n2 = random.Next(Mn, Mx)
                End If
                If operation = "^" Then
                    n2 = random.Next(Mn, Mx)
                End If
        End Select


        Operations = n1 & " " & operation & " " & n2
        If Sign(n2) = -1 Then
            Operations = n1 & " " & operation & " " & "(" & n2 & ")"
        End If

        Return Operations
    End Function

    'Public Sub InsertarPartida()
    '    Dim conexion As SQLiteConnection = New SQLiteConnection("Data Source = Resources/juegoMat.db")
    '    conexion.Open()
    '    Dim comando As String = "INSERT INTO Puntuaciones VALUES (?, ?, ?, CURRENT_TIMESTAMP, ?)"
    '    Dim cmd As SQLiteCommand = New SQLiteCommand(comando, conexion)

    '    Dim id As SQLiteParameter = New SQLiteParameter
    '    id.Value = nick
    '    Dim dif As SQLiteParameter = New SQLiteParameter
    '    dif.Value = difficult
    '    Dim score As SQLiteParameter = New SQLiteParameter
    '    score.Value = Juego.puntuacion
    '    Dim com As SQLiteParameter = New SQLiteParameter
    '    com.Value = Comment

    '    cmd.Parameters.Add(id)
    '    cmd.Parameters.Add(dif)
    '    cmd.Parameters.Add(score)
    '    cmd.Parameters.Add(com)

    '    cmd.ExecuteNonQuery()
    '   conexion.Close()
    'End Sub

    'Public Function Operations2(ByVal DIff) As String

    '    Select Case DIff
    '        Case 1
    '            n3 = random.Next(0, 50)
    '            n4 = random.Next(0, 50)
    '            operation2 = simbolo(random.Next(0, 2))
    '        Case 2
    '            n3 = random.Next(0, 50)
    '            n4 = random.Next(0, 50)
    '            operation2 = simbolo(random.Next(0, 4))

    '            If operation2 = "/" And n4 = 0 Then
    '                n4 = random.Next(0, 50)
    '            End If
    '        Case 3
    '            'n1 = Round((-50 - 50) * Rnd() + 50, 2)
    '            'n2 = Round((-50 - 50) * Rnd() + 50, 2)
    '            n3 = random.Next(-50, 50)
    '            n4 = random.Next(-50, 50)
    '            operation2 = simbolo(random.Next(0, 5))

    '            If operation2 = "/" And n4 = 0 Then
    '                n4 = random.Next(-50, 50)
    '            End If
    '    End Select



    '    Operations2 = n3 & " " & operation2 & " " & n4
    '    If Sign(n4) = -1 Then
    '        Operations2 = n3 & " " & operation2 & " " & "(" & n4 & ")"
    '    End If

    '    Return Operations2
    'End Function



End Module
