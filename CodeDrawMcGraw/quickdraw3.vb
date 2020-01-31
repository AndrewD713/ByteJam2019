Public Class quickdraw3
    Dim WeaponDraw As Boolean = False
    Dim lose As Boolean = False
    Dim enemyCtr As Int16 = 1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Timer until bad 1 weapon draw
        picbox_Bad1.Image = Image.FromFile("..\..\..\Assets\Enemies\Bandana_Bandit_Anim.gif")
        WeaponDraw = True
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Timer until bad 1 shoots
        picbox_Bad1.Image = Image.FromFile("..\..\..\Assets\Enemies\Bandana_Bandit_Static_Loss.gif")
        My.Computer.Audio.Play("..\..\..\Assets\sound-effects\Gunshot-sound.wav", AudioPlayMode.Background)
        Timer2.Enabled = False
        WeaponDraw = False
        gameOver()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'Timer until bad 2 draws
        picbox_Bad2.Image = Image.FromFile("..\..\..\Assets\Enemies\Bandana_Bandit_Anim.gif")
        WeaponDraw = True
        Timer3.Enabled = False
        Timer4.Enabled = True
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        'Timer until bad 2 shoots
        picbox_Bad2.Image = Image.FromFile("..\..\..\Assets\Enemies\Bandana_Bandit_Static_Loss.gif")
        My.Computer.Audio.Play("..\..\..\Assets\sound-effects\Gunshot-sound.wav", AudioPlayMode.Background)
        Timer4.Enabled = False
        WeaponDraw = False
        gameOver()
    End Sub

    Private Sub quickdraw3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Player gun firing condition
        If e.KeyCode = Keys.Space And lose = False Then
            picbox_Bad1.Image = Image.FromFile("..\..\..\Assets\Enemies\Bandana_Bandit_Static_Win.gif")
            My.Computer.Audio.Play("..\..\..\Assets\sound-effects\Gunshot-sound.wav", AudioPlayMode.Background)

            If WeaponDraw And enemyCtr = 1 Then
                'Shoot first bad
                Timer2.Enabled = False
                Timer3.Enabled = True
                WeaponDraw = False
                enemyCtr = 2

            ElseIf WeaponDraw And enemyCtr = 2 Then
                'Shoot second bad and win
                picbox_Bad2.Image = Image.FromFile("..\..\..\Assets\Enemies\Bandana_Bandit_Static_Win.gif")
                Timer4.Enabled = False
                win()

            ElseIf enemyCtr = 2 Then
                'Shoot second bad too early and lose
                picbox_Bad2.Image = Image.FromFile("..\..\..\Assets\Enemies\Bandana_Bandit_Static_Win.gif")
                gameOver()

            Else
                'Miss shot and lose
                gameOver()
            End If
        End If

        'Restart the form
        If e.KeyCode = Keys.R Then
            Dim frmReset As New quickdraw3
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
        Timer3.Enabled = False
        Timer4.Enabled = False
    End Sub

    Private Sub win()
        MessageBox.Show("you win, press ok to continue")
        Dim frmStory8 As New Story8
        frmStory8.Show()
        Me.Close()
    End Sub
End Class