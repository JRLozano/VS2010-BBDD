Imports System.Data.SQLite
Public Class Puntuaciones
    Dim conexion As SQLiteConnection = New SQLiteConnection("Data Source = Resources/juegoMat.db")

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'GestionBBDD.InsertarPartida()
        'MsgBox("Hecho")

    End Sub

    Private Sub Puntuaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GestionBBDD.RellenarPuntuaciones()

    End Sub
End Class