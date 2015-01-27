Public Class Tittle

    Private Sub BExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BExit.Click
        Close()
    End Sub

    Private Sub BHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BHelp.Click
        'Archivo de Ayuda .chm
    End Sub

    Private Sub BTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTop.Click
        'DataGridView donde se cargan las puntuaciones
        Hide()
        Puntuaciones.Show()
    End Sub

    Private Sub BPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPlay.Click
        'Empieza el Juego!!
        Hide()
        Configuracion.Show()


    End Sub
End Class
