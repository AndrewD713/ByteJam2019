Public Class main
    Public Shared userName As String

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        'START
        My.Computer.Audio.Stop()
        Dim frmSTART As New Story1
        frmSTART.Show()
    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        My.Computer.Audio.Stop()
        Dim frmCredits As New Credits
        frmCredits.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("..\..\..\Assets\sound-effects\The Gunfight - Everet Almond.wav", AudioPlayMode.BackgroundLoop)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub
End Class
