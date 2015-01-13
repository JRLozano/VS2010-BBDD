Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ruta As String = Application.StartupPath & "\..\..\Resources\Archivo de ayuda.chm"
        'Dim ruta As String = System.Text.Encoding.Default.GetString(My.Resources.Archivo_de_ayuda)
        System.Diagnostics.Process.Start(ruta)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim ruta As String = Application.StartupPath & "\..\..\Resources\Archivo de ayuda.html"
        System.Diagnostics.Process.Start(ruta)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
