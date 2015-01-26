
Imports System.Data.SQLite
Public Class Configuracion
    Dim con As SQLiteConnection = New SQLiteConnection("Data source = ejemplo.db")
    Dim cmd As SQLiteCommand

    Public i As Integer
    Dim j As Integer = 0
    Dim simbolos(5) As Integer

    Private Sub LOAD_Configuracion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DeshabilitarOps()
    End Sub

    Private Sub ChooseDiff(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBdEasy.CheckedChanged,
        RBdHard.CheckedChanged, RBdMed.CheckedChanged, RBdPers.CheckedChanged

        If RBdEasy.Checked Then

            DeshabilitarOps()
            TbTime.Text = "1"
            TbMin.Text = 50
            TbMax.Text = 50

            CBoSum.Checked = True
            CBoSubs.Checked = True
            CBoMult.Checked = False
            CBoDiv.Checked = False
            CBoPot.Checked = False
            CBotDecs.Checked = False
            CBotNegat.Checked = False
            TbTime.Enabled = False

            Juego.difficult = "E"

        ElseIf RBdMed.Checked Then

            DeshabilitarOps()
            TbTime.Text = "4"
            TbMin.Text = 50
            TbMax.Text = 50

            CBoSum.Checked = True
            CBoSubs.Checked = True
            CBoMult.Checked = True
            CBoDiv.Checked = True
            CBoPot.Checked = False
            CBotDecs.Checked = False
            CBotNegat.Checked = False
            TbTime.Enabled = False

            Juego.difficult = "M"
        ElseIf RBdHard.Checked() Then

            DeshabilitarOps()
            TbTime.Text = "3"
            TbMin.Text = 50
            TbMax.Text = 50

            CBoSum.Checked = True
            CBoSubs.Checked = True
            CBoMult.Checked = True
            CBoDiv.Checked = True
            CBoPot.Checked = True
            CBotDecs.Checked = False
            CBotNegat.Checked = True
            TbTime.Enabled = False

            Juego.difficult = "H"
        ElseIf RBdPers.Checked Then

            HabilitarOps()
            TbTime.Text = "Introduzca el tiempo"

            CBoSum.Checked = False
            CBoSubs.Checked = False
            CBoMult.Checked = False
            CBoDiv.Checked = False
            CBoPot.Checked = False
            CBotDecs.Checked = False
            CBotNegat.Checked = False
            TbTime.Enabled = True

            Juego.difficult = "P"
        End If

        i = CType(sender, RadioButton).Tag

    End Sub

    Private Sub LetsPlay(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPlay.Click

        Juego.i = i
        Hide()
        Juego.Show()

    End Sub

    Public Sub DeshabilitarOps()
        CBoSum.Enabled = False
        CBoSubs.Enabled = False
        CBoMult.Enabled = False
        CBoDiv.Enabled = False
        CBoPot.Enabled = False
        CBotDecs.Enabled = False
        CBotNegat.Enabled = False
        TbTime.Enabled = False
        TbMax.Enabled = False
        TbMin.Enabled = False
    End Sub

    Public Sub HabilitarOps()
        CBoSum.Enabled = True
        CBoSubs.Enabled = True
        CBoMult.Enabled = True
        CBoDiv.Enabled = True
        CBoPot.Enabled = True
        CBotDecs.Enabled = True
        CBotNegat.Enabled = True
        TbTime.Enabled = True
        TbMax.Enabled = True
        TbMin.Enabled = True
    End Sub

    Private Sub BAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAtras.Click
        Me.Close()
        Tittle.Show()
    End Sub
End Class