Public Class Fight_1
    Dim boolPunching As Boolean = False
    Dim boolShield As Boolean = False
    Dim intGoodHealth As Int16 = 100
    Dim intBadHealth As Int16 = 100
    Dim lose As Boolean = False

    Private Sub Fight_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("SPACE - PUNCH." + Environment.NewLine + Environment.NewLine +
                        "E - BLOCK" + Environment.NewLine + Environment.NewLine +
                        "Your punches are slower, but blocking will stun your opponent for a brief period of time",
                        "INSTRUCTIONS")
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'bad guy punching start
        picBad.Image = Image.FromFile("..\..\..\Assets\Enemies\Billy_The_Code_Punch.gif")
        My.Computer.Audio.Play("..\..\..\Assets\sound-effects\strong_punch.wav", AudioPlayMode.Background)
        Timer2.Enabled = True

        'Reduces player health if not shielding, otherwise stuns bad guy
        If boolShield = False Then
            intGoodHealth -= 10
            lblGoodHealth.Text = intGoodHealth.ToString() + "%"
            Timer1.Interval = 750
            If intGoodHealth <= 0 Then
                gameOver()
            End If
        Else
            Timer1.Interval = 2000
            My.Computer.Audio.Play("..\..\..\Assets\sound-effects\grunt.wav", AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'bad guy punching end
        picBad.Image = Image.FromFile("..\..\..\Assets\Enemies\Billy_The_Code_Punch_Static.gif")
        Timer2.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'good guy punching end
        picChar.Image = Image.FromFile("..\..\..\Assets\Player\Player_Punch_Static.gif")
        boolPunching = False
        Timer3.Enabled = False
    End Sub

    Private Sub Fight_1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space And boolPunching = False And lose = False Then
            'change to punching picture, reduce enemy health
            picChar.Image = Image.FromFile("..\..\..\Assets\Player\Player_Punch.gif")
            My.Computer.Audio.Play("..\..\..\Assets\sound-effects\slap.wav", AudioPlayMode.Background)
            intBadHealth -= 10
            lblBadHealth.Text = intBadHealth.ToString + "%"
            boolPunching = True
            Timer3.Enabled = True

            If intBadHealth <= 0 Then
                Timer1.Enabled = False
                Timer2.Enabled = False
                Timer3.Enabled = False
                win()
            End If

        End If

        'Put up shield
        If e.KeyCode = Keys.E And boolPunching = False And boolShield = False And lose = False Then
            picChar.Image = Image.FromFile("..\..\..\Assets\Player\Player_Punch_Block.gif")
            boolShield = True
        End If

        If e.KeyCode = Keys.R Then
            Dim frmReset As New Fight_1
            frmReset.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Fight_1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        'Drop shield
        If e.KeyCode = Keys.E Then
            boolShield = False
            picChar.Image = Image.FromFile("..\..\..\Assets\Player\Player_Punch_Static.gif")
        End If
    End Sub

    Private Sub gameOver()
        'Sets lose to true to avoid space bar presses after game over
        lose = True
        lblGameOver.Visible = True
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
    End Sub

    Private Sub win()
        MessageBox.Show("you win, press ok to continue")
        Dim frmStory8_5 As New Story8_5
        frmStory8_5.Show()
        Me.Close()
    End Sub
End Class