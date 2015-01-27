Imports System.Math
Imports System.Data.SQLite
'(MinNumber - MaxNumber) * Rnd + MaxNumber)

Module Operaciones

    Dim random As New Random
    Public n1, n2 As Double
    Public operation As Char
    Dim simbolo() As Char = {"+", "-", "*", "/", "^"} 'Las posiciones empiezan en 1

    Public Function Personalizado() As String
        Dim aux(5) As Char
        Dim i As Integer
        Dim Mn As Double = Configuracion.TbMin.Text
        Dim Mx As Double = Configuracion.TbMax.Text

        If Configuracion.CBoSum.Checked Then
            aux(i) = "+"
            i += i
        End If
        If Configuracion.CBoSubs.Checked Then
            aux(i) = "-"
            i += i
        End If
        If Configuracion.CBoMult.Checked Then
            aux(i) = "*"
            i += i
        End If
        If Configuracion.CBoDiv.Checked Then
            aux(i) = "-"
            i += i
        End If
        If Configuracion.CBoPot.Checked Then
            aux(i) = "^"
            i += i
        End If

        ReDim Preserve aux(i)
        If Not Configuracion.CBotDecs.Checked Then
            n1 = random.Next(Mn, Mx)
            n2 = random.Next(Mn, Mx)
        End If
        operation = aux(random.Next(0, aux.Length))


        Dim res As String = n1 & " " & operation & " " & n2
        If Sign(n2) = -1 Then
            res = n1 & " " & operation & " " & "(" & n2 & ")"
        End If

        Return res
    End Function

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

End Module
