<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splashForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splashForm))
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.customPictureBox = New System.Windows.Forms.PictureBox()
        Me.timerData = New System.Windows.Forms.Timer(Me.components)
        CType(Me.customPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(274, 326)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(252, 32)
        Me.nameLabel.TabIndex = 1
        Me.nameLabel.Text = "(C) G.Tang and Jaegers"
        '
        'titleLabel
        '
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(284, 275)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(252, 28)
        Me.titleLabel.TabIndex = 2
        Me.titleLabel.Text = "Retail Price Calculator"
        '
        'customPictureBox
        '
        Me.customPictureBox.Image = CType(resources.GetObject("customPictureBox.Image"), System.Drawing.Image)
        Me.customPictureBox.Location = New System.Drawing.Point(207, 60)
        Me.customPictureBox.Name = "customPictureBox"
        Me.customPictureBox.Size = New System.Drawing.Size(401, 196)
        Me.customPictureBox.TabIndex = 3
        Me.customPictureBox.TabStop = False
        '
        'timerData
        '
        Me.timerData.Enabled = True
        Me.timerData.Interval = 3000
        '
        'splashForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.customPictureBox)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Name = "splashForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.customPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents nameLabel As Label
    Friend WithEvents titleLabel As Label
    Friend WithEvents customPictureBox As PictureBox
    Friend WithEvents timerData As Timer
End Class
