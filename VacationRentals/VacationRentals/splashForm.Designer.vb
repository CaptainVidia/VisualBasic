﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.timerData = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.nameLabel.Location = New System.Drawing.Point(468, 104)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(88, 27)
        Me.nameLabel.TabIndex = 1
        Me.nameLabel.Text = "G.Tang"
        '
        'titleLabel
        '
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.titleLabel.Location = New System.Drawing.Point(419, 66)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(180, 38)
        Me.titleLabel.TabIndex = 2
        Me.titleLabel.Text = "Vacation Rentals"
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
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(999, 632)
        Me.ControlBox = False
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Name = "splashForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents nameLabel As Label
    Friend WithEvents titleLabel As Label
    Friend WithEvents timerData As Timer
End Class
