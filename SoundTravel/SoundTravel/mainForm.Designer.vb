<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.distanceLabel = New System.Windows.Forms.Label()
        Me.distanceTextBox = New System.Windows.Forms.TextBox()
        Me.mediumSoundLabel = New System.Windows.Forms.Label()
        Me.airRadioButton = New System.Windows.Forms.RadioButton()
        Me.waterRadioButton = New System.Windows.Forms.RadioButton()
        Me.steelRadioButton = New System.Windows.Forms.RadioButton()
        Me.diamondRadioButton = New System.Windows.Forms.RadioButton()
        Me.timeElaspedLabel = New System.Windows.Forms.Label()
        Me.timeValLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'distanceLabel
        '
        Me.distanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distanceLabel.Location = New System.Drawing.Point(108, 19)
        Me.distanceLabel.Name = "distanceLabel"
        Me.distanceLabel.Size = New System.Drawing.Size(382, 23)
        Me.distanceLabel.TabIndex = 0
        Me.distanceLabel.Text = "&Enter the distance to travel on feet"
        '
        'distanceTextBox
        '
        Me.distanceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distanceTextBox.Location = New System.Drawing.Point(535, 22)
        Me.distanceTextBox.Name = "distanceTextBox"
        Me.distanceTextBox.Size = New System.Drawing.Size(153, 31)
        Me.distanceTextBox.TabIndex = 1
        Me.distanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mediumSoundLabel
        '
        Me.mediumSoundLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mediumSoundLabel.Location = New System.Drawing.Point(108, 71)
        Me.mediumSoundLabel.Name = "mediumSoundLabel"
        Me.mediumSoundLabel.Size = New System.Drawing.Size(483, 29)
        Me.mediumSoundLabel.TabIndex = 0
        Me.mediumSoundLabel.Text = "Choose the medium sound is to travel through: "
        '
        'airRadioButton
        '
        Me.airRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.airRadioButton.Location = New System.Drawing.Point(252, 115)
        Me.airRadioButton.Name = "airRadioButton"
        Me.airRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.airRadioButton.TabIndex = 2
        Me.airRadioButton.TabStop = True
        Me.airRadioButton.Text = "&Air"
        Me.airRadioButton.UseVisualStyleBackColor = True
        '
        'waterRadioButton
        '
        Me.waterRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waterRadioButton.Location = New System.Drawing.Point(252, 148)
        Me.waterRadioButton.Name = "waterRadioButton"
        Me.waterRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.waterRadioButton.TabIndex = 3
        Me.waterRadioButton.TabStop = True
        Me.waterRadioButton.Text = "&Water"
        Me.waterRadioButton.UseVisualStyleBackColor = True
        '
        'steelRadioButton
        '
        Me.steelRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.steelRadioButton.Location = New System.Drawing.Point(252, 178)
        Me.steelRadioButton.Name = "steelRadioButton"
        Me.steelRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.steelRadioButton.TabIndex = 4
        Me.steelRadioButton.TabStop = True
        Me.steelRadioButton.Text = "&Steel"
        Me.steelRadioButton.UseVisualStyleBackColor = True
        '
        'diamondRadioButton
        '
        Me.diamondRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diamondRadioButton.Location = New System.Drawing.Point(252, 208)
        Me.diamondRadioButton.Name = "diamondRadioButton"
        Me.diamondRadioButton.Size = New System.Drawing.Size(133, 24)
        Me.diamondRadioButton.TabIndex = 5
        Me.diamondRadioButton.TabStop = True
        Me.diamondRadioButton.Text = "&Diamond"
        Me.diamondRadioButton.UseVisualStyleBackColor = True
        '
        'timeElaspedLabel
        '
        Me.timeElaspedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeElaspedLabel.Location = New System.Drawing.Point(141, 276)
        Me.timeElaspedLabel.Name = "timeElaspedLabel"
        Me.timeElaspedLabel.Size = New System.Drawing.Size(177, 30)
        Me.timeElaspedLabel.TabIndex = 0
        Me.timeElaspedLabel.Text = "Time Elasped:"
        '
        'timeValLabel
        '
        Me.timeValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.timeValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeValLabel.Location = New System.Drawing.Point(338, 276)
        Me.timeValLabel.Name = "timeValLabel"
        Me.timeValLabel.Size = New System.Drawing.Size(253, 30)
        Me.timeValLabel.TabIndex = 9
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(101, 340)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(141, 41)
        Me.calculateButton.TabIndex = 6
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(547, 340)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(141, 41)
        Me.exitButton.TabIndex = 8
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(311, 340)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(141, 41)
        Me.clearButton.TabIndex = 7
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.timeValLabel)
        Me.Controls.Add(Me.timeElaspedLabel)
        Me.Controls.Add(Me.diamondRadioButton)
        Me.Controls.Add(Me.steelRadioButton)
        Me.Controls.Add(Me.waterRadioButton)
        Me.Controls.Add(Me.airRadioButton)
        Me.Controls.Add(Me.mediumSoundLabel)
        Me.Controls.Add(Me.distanceTextBox)
        Me.Controls.Add(Me.distanceLabel)
        Me.Name = "mainForm"
        Me.Text = "Sound Travel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents distanceLabel As Label
    Friend WithEvents distanceTextBox As TextBox
    Friend WithEvents mediumSoundLabel As Label
    Friend WithEvents airRadioButton As RadioButton
    Friend WithEvents waterRadioButton As RadioButton
    Friend WithEvents steelRadioButton As RadioButton
    Friend WithEvents diamondRadioButton As RadioButton
    Friend WithEvents timeElaspedLabel As Label
    Friend WithEvents timeValLabel As Label
    Friend WithEvents calculateButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents clearButton As Button
End Class
