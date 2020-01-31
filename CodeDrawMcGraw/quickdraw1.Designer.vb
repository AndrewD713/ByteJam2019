<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class quickdraw1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quickdraw1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.picbox_Bad = New System.Windows.Forms.PictureBox()
        CType(Me.picbox_Bad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblGameOver.Font = New System.Drawing.Font("Castellar", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.Color.White
        Me.lblGameOver.Location = New System.Drawing.Point(748, 9)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(409, 78)
        Me.lblGameOver.TabIndex = 8
        Me.lblGameOver.Text = "      GAME OVER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press 'R' to restart" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblGameOver.Visible = False
        '
        'picbox_Bad
        '
        Me.picbox_Bad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picbox_Bad.BackColor = System.Drawing.Color.Transparent
        Me.picbox_Bad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picbox_Bad.Image = Global.CodeDrawMcGraw.My.Resources.Resources.Big_Hex_Draw_Static
        Me.picbox_Bad.Location = New System.Drawing.Point(767, 321)
        Me.picbox_Bad.Name = "picbox_Bad"
        Me.picbox_Bad.Size = New System.Drawing.Size(370, 721)
        Me.picbox_Bad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox_Bad.TabIndex = 4
        Me.picbox_Bad.TabStop = False
        '
        'quickdraw1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CodeDrawMcGraw.My.Resources.Resources.Street_Scene
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.picbox_Bad)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "quickdraw1"
        Me.Text = "Code Draw McGraw"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picbox_Bad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picbox_Bad As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblGameOver As Label
End Class
