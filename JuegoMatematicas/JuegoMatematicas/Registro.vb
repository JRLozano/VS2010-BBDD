Imports System.Data.SQLite

Public Class Registro

    Dim conexion As SQLiteConnection = New SQLiteConnection("Data source = Resources/juegoMat.db")
    Dim cmd As SQLiteCommand = conexion.CreateCommand
    Dim comando As String
    Dim mensaje As String

    Private Sub Registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GestionBBDD.ListarJug()

    End Sub

    Private Sub BEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEntrar.Click

        If RBReg.Checked Then
            GestionBBDD.InsertarJug(CBUsers.Text, TbPass.Text)
            mensaje = "Bienvenido " & CBUsers.Text
        ElseIf RBIdent.Checked Then

            If GestionBBDD.ValidarJug(CBUsers.Text, TbPass.Text) Then
                mensaje = "Hola otra vez :D"
                Hide()
                Tittle.Show()
            Else
                MsgBox("No existe usuario/contraseña proporcionado")
            End If
            
        End If

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