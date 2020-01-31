Public Class Travel_2
    Dim lstObjects As New List(Of PictureBox)
    Dim lstBackground As New List(Of PictureBox)

    Private Sub Travel_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
        Timer1.Enabled = True
    End Sub

    Private Sub init()
        'adds pictureboxes to list
        lstObjects.AddRange({picObj1, picObj2, picObj3, picObj4, picObj5, picObj6, picObj7, picObj8, picObj9})
        AutoScroll = False
        My.Computer.Audio.Play("..\..\..\Assets\sound-effects\Gallop.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        'moves all obstacles to the left

        If picObj1.Left < Me.Width Then
            For Each pic In lstObjects
                pic.Left = pic.Left - 7

                'LOSE
                If pic.Bounds.IntersectsWith(picChar.Bounds) Then
                    gameOver()
                    Exit Sub
                End If
                'WIN
                If picFinishLine.Bounds.IntersectsWith(picChar.Bounds) Then
                    win()
                    Exit Sub
                End If
            Next
        Else
            For Each pic In lstObjects
                pic.Left = 0
            Next
        End If

        picFinishLine.Left = picFinishLine.Left - 7
    End Sub

    Private Sub gameOver()
        'sets game over state
        My.Computer.Audio.Stop()
        lblGameOver.Visible = True
        Timer1.Enabled = False
    End Sub

    Private Sub win()
        My.Computer.Audio.Stop()
        Timer1.Enabled = False
        MessageBox.Show("You win! Press enter to continue.")
        Dim frmStory5 As New Story5
        frmStory5.Show()
        Me.Close()
    End Sub

    Private Sub Travel_2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If Timer1.Enabled Then
            'Moves the main character until they reach the bottom of the ground
            If e.KeyCode = Keys.Down Then
                If picChar.Bottom < picGround.Bottom Then
                    picChar.Top += 14
                End If
            End If

            'Moves the main character until they reach the top of the ground
            If e.KeyCode = Keys.Up Then
                If picChar.Top > picGround.Top Then
                    picChar.Top += -14
                End If
            End If
        End If

        'Restart the form
        If e.KeyCode = Keys.R Then
            My.Computer.Audio.Stop()
            Dim frmReset As New Travel_2
            frmReset.Show()
            Me.Close()
        End If
    End Sub
End Class