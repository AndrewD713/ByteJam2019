Public Class quickdraw2
    Dim WeaponDraw As Boolean = False
    Dim lose As Boolean = False

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Timer until weapon draw
        picbox_Bad.Image = Image.FromFile("..\..\..\Assets\Enemies\Bandana_Bandit_Anim.gif")
        WeaponDraw = True
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Timer until shoot
        picbox_Bad.Image = Image.FromFile("..\..\..\Assets\Enemies\Bandana_Bandit_Static_Loss.gif")
        My.Computer.Audio.Play("..\..\..\Assets\sound-effects\Gunshot-sound.wav", AudioPlayMode.Background)
        Timer2.Enabled = False
        WeaponDraw = False
        gameOver()
    End Sub

    Private Sub quickdraw2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Player gun firing condition
        If e.KeyCode = Keys.Space And lose = False Then
            picbox_Bad.Image = Image.FromFile("..\..\..\Assets\Enemies\Bandana_Bandit_Static_Win.gif")
            My.Computer.Audio.Play("..\..\..\Assets\sound-effects\Gunshot-sound.wav", AudioPlayMode.Background)

            If WeaponDraw Then
                Timer2.Enabled = False
                win()
            Else
                gameOver()
            End If
        End If

        'Restart the form
        If e.KeyCode = Keys.R Then
            Dim frmReset As New quickdraw2
            frmReset.Show()
            Me.Close()
        End If
    End Sub

    Private Sub gameOver()
        'Sets lose to true to avoid space bar presses after game over
        lose = True
        lblGameOver.Visible = True
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub

    Private Sub win()
        MessageBox.Show("you win, press ok to continue")
        Dim frmStory6 As New Story6
        frmStory6.Show()
        Me.Close()
    End Sub
End Class