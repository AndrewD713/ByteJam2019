Public Class Story7
    Private Sub Story7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.SelectionStart = 0
    End Sub

    Private Sub Cont_Click(sender As Object, e As EventArgs) Handles Cont.Click
        Dim frmQuickDraw3 As New quickdraw3
        frmQuickDraw3.Show()
        Me.Close()
    End Sub
End Class