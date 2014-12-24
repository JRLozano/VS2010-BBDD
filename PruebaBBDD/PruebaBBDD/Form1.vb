Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conector As New MySqlConnection("server=localhost;user=ejemplo;password=ejemplo;database=ejemplo;port=3306")
    Dim comando As String
    Dim reader As MySqlDataReader

    Function Validar(ByVal numDep As Integer) As Boolean
        comando = "SELECT * FROM Departamentos WHERE dept_no = @num"
        Dim cmd As New MySqlCommand(comando, conector)
        conector.Open()
        cmd.Parameters.Add("@num", MySqlDbType.Int16).Value = numDep
        reader = cmd.ExecuteReader
        Validar = False

        If reader.Read Then
            reader.Close()
            Validar = True
        End If

        conector.Close()
        Return Validar
    End Function


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Consultar.Click
        comando = "SELECT dnombre, loc FROM Departamentos WHERE dept_no = @numDep"
        Dim cmd As New MySqlCommand(comando, conector)
        conector.Open()
        cmd.Parameters.Add("@numDep", MySqlDbType.Int16).Value = TextBox1.Text
        reader = cmd.ExecuteReader

        If reader.Read Then
            TextBox2.Text = reader.GetString(0)
            TextBox3.Text = reader.GetString(1)
        Else
            MsgBox("El departamento no existe")
        End If
        reader.Close()
        conector.Close()

    End Sub

    Private Sub Añadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Añadir.Click
        'comando = "SELECT dept_no FROM Departamentos WHERE dept_no = @numDep"
        'Dim cmd As New MySqlCommand(comando, conector)

        'cmd.Parameters.Add("@numDep", MySqlDbType.Int16).Value = TextBox1.Text
        'reader = cmd.ExecuteReader

        If Validar(TextBox1.Text) Then
            MsgBox("El departamento ya existe")
        Else
            reader.Close()
            Dim comando As String = "INSERT INTO Departamentos VALUES(@numDep, @nom, @loc)"
            Dim cmd As New MySqlCommand(comando, conector)
            conector.Open()
            cmd.Parameters.Add("@numDep", MySqlDbType.Int16).Value = TextBox1.Text
            cmd.Parameters.Add("@nom", MySqlDbType.String).Value = TextBox2.Text
            cmd.Parameters.Add("@loc", MySqlDbType.String).Value = TextBox3.Text
            cmd.ExecuteNonQuery()
            MsgBox("Departamento Introducido")
        End If


        conector.Close()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        comando = "SELECT dept_no FROM Departamentos WHERE dept_no = @numDep"
        Dim cmd As New MySqlCommand(comando, conector)
        conector.Open()
        cmd.Parameters.Add("@numDep", MySqlDbType.Int16).Value = TextBox1.Text
        reader = cmd.ExecuteReader

        If reader.Read Then
            Try
                reader.Close()
                Dim comando2 As String = "DELETE FROM Departamentos WHERE dept_no = @numDep"
                Dim cmd2 As New MySqlCommand(comando2, conector)
                cmd2.Parameters.Add("@numDep", MySqlDbType.Int16).Value = TextBox1.Text
                cmd2.ExecuteNonQuery()

                MsgBox("Departamentos Eliminado")
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
           


        Else
            MsgBox("El departamento no existe")
        End If

        ' reader.Close()
        conector.Close()

    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        comando = "UPDATE Departamentos SET dnombre = @nom, loc = @loc WHERE dept_no = @numDep"
        Dim cmd As New MySqlCommand(comando, conector)
        conector.Open()
        cmd.Parameters.Add("@numDep", MySqlDbType.Int16).Value = TextBox1.Text
        cmd.Parameters.Add("@nom", MySqlDbType.String).Value = TextBox2.Text
        cmd.Parameters.Add("@loc", MySqlDbType.String).Value = TextBox3.Text

        cmd.ExecuteNonQuery()
        MsgBox("El Departamento ha sido modificado")

        conector.Close()
    End Sub
End Class
