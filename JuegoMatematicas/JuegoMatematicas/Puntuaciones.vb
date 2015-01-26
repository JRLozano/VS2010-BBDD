Imports System.Data.SQLite
Public Class Puntuaciones
    Dim conexion As SQLiteConnection = New SQLiteConnection("Data Source = Resources/juegoMat.db")
    Private Sub Puntuaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        conexion.Open()
        Dim comando As String = "INSERT INTO Puntuaciones VALUES ('Prueba', 'E', 30, CURRENT_TIMESTAMP, 'PartidaPrueba1')"
        Dim cmd As SQLiteCommand = New SQLiteCommand(comando, conexion)
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub
End Class