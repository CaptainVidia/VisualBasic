<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WindowsSplash
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.timerData = New System.Windows.Forms.Timer(Me.components)
        Me.lblAsianBois = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(119, 46)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(573, 55)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Data Type Study Program"
        '
        'timerData
        '
        Me.timerData.Enabled = True
        Me.timerData.Interval = 3000
        '
        'lblAsianBois
        '
        Me.lblAsianBois.AutoSize = True
        Me.lblAsianBois.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!)
        Me.lblAsianBois.Location = New System.Drawing.Point(186, 119)
        Me.lblAsianBois.Name = "lblAsianBois"
        Me.lblAsianBois.Size = New System.Drawing.Size(440, 51)
        Me.lblAsianBois.TabIndex = 1
        Me.lblAsianBois.Text = "Asian Bois and Group"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.inclass1_29.My.Resources.Resources.cubs
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(287, 185)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 236)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'WindowsSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 486)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblAsianBois)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "WindowsSplash"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents timerData As Timer
    Friend WithEvents lblAsianBois As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
