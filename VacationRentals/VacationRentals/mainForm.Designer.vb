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
        Me.areaNamesGroupBox = New System.Windows.Forms.GroupBox()
        Me.alliedForcesCheckBox = New System.Windows.Forms.CheckBox()
        Me.marleyCheckBox = New System.Windows.Forms.CheckBox()
        Me.wallRoseCheckBox = New System.Windows.Forms.CheckBox()
        Me.wallSinaCheckBox = New System.Windows.Forms.CheckBox()
        Me.wallMariaCheckBox = New System.Windows.Forms.CheckBox()
        Me.residencyGroupBox = New System.Windows.Forms.GroupBox()
        Me.oneBedCheckBox = New System.Windows.Forms.CheckBox()
        Me.twoBedCheckBox = New System.Windows.Forms.CheckBox()
        Me.largeCheckBox = New System.Windows.Forms.CheckBox()
        Me.studioCheckBox = New System.Windows.Forms.CheckBox()
        Me.smallCheckBox = New System.Windows.Forms.CheckBox()
        Me.continueButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.neighResultLabel = New System.Windows.Forms.Label()
        Me.residencyResultLabel = New System.Windows.Forms.Label()
        Me.chosenResidencyLabel = New System.Windows.Forms.Label()
        Me.chosenAreaNamesLabel = New System.Windows.Forms.Label()
        Me.areaNamesGroupBox.SuspendLayout()
        Me.residencyGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'areaNamesGroupBox
        '
        Me.areaNamesGroupBox.Controls.Add(Me.alliedForcesCheckBox)
        Me.areaNamesGroupBox.Controls.Add(Me.marleyCheckBox)
        Me.areaNamesGroupBox.Controls.Add(Me.wallRoseCheckBox)
        Me.areaNamesGroupBox.Controls.Add(Me.wallSinaCheckBox)
        Me.areaNamesGroupBox.Controls.Add(Me.wallMariaCheckBox)
        Me.areaNamesGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.areaNamesGroupBox.Location = New System.Drawing.Point(22, 34)
        Me.areaNamesGroupBox.Name = "areaNamesGroupBox"
        Me.areaNamesGroupBox.Size = New System.Drawing.Size(271, 312)
        Me.areaNamesGroupBox.TabIndex = 1
        Me.areaNamesGroupBox.TabStop = False
        Me.areaNamesGroupBox.Text = "Area Names"
        '
        'alliedForcesCheckBox
        '
        Me.alliedForcesCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alliedForcesCheckBox.Location = New System.Drawing.Point(6, 211)
        Me.alliedForcesCheckBox.Name = "alliedForcesCheckBox"
        Me.alliedForcesCheckBox.Size = New System.Drawing.Size(247, 32)
        Me.alliedForcesCheckBox.TabIndex = 4
        Me.alliedForcesCheckBox.Text = "Mid-East Allied &Forces"
        Me.alliedForcesCheckBox.UseVisualStyleBackColor = True
        '
        'marleyCheckBox
        '
        Me.marleyCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marleyCheckBox.Location = New System.Drawing.Point(6, 163)
        Me.marleyCheckBox.Name = "marleyCheckBox"
        Me.marleyCheckBox.Size = New System.Drawing.Size(204, 32)
        Me.marleyCheckBox.TabIndex = 3
        Me.marleyCheckBox.Text = "Marle&y"
        Me.marleyCheckBox.UseVisualStyleBackColor = True
        '
        'wallRoseCheckBox
        '
        Me.wallRoseCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wallRoseCheckBox.Location = New System.Drawing.Point(6, 73)
        Me.wallRoseCheckBox.Name = "wallRoseCheckBox"
        Me.wallRoseCheckBox.Size = New System.Drawing.Size(184, 37)
        Me.wallRoseCheckBox.TabIndex = 1
        Me.wallRoseCheckBox.Text = "Wall &Rose"
        Me.wallRoseCheckBox.UseVisualStyleBackColor = True
        '
        'wallSinaCheckBox
        '
        Me.wallSinaCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wallSinaCheckBox.Location = New System.Drawing.Point(6, 116)
        Me.wallSinaCheckBox.Name = "wallSinaCheckBox"
        Me.wallSinaCheckBox.Size = New System.Drawing.Size(204, 32)
        Me.wallSinaCheckBox.TabIndex = 2
        Me.wallSinaCheckBox.Text = "Wall &Sina"
        Me.wallSinaCheckBox.UseVisualStyleBackColor = True
        '
        'wallMariaCheckBox
        '
        Me.wallMariaCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wallMariaCheckBox.Location = New System.Drawing.Point(6, 30)
        Me.wallMariaCheckBox.Name = "wallMariaCheckBox"
        Me.wallMariaCheckBox.Size = New System.Drawing.Size(162, 37)
        Me.wallMariaCheckBox.TabIndex = 0
        Me.wallMariaCheckBox.Text = "Wall &Maria"
        Me.wallMariaCheckBox.UseVisualStyleBackColor = True
        '
        'residencyGroupBox
        '
        Me.residencyGroupBox.Controls.Add(Me.oneBedCheckBox)
        Me.residencyGroupBox.Controls.Add(Me.twoBedCheckBox)
        Me.residencyGroupBox.Controls.Add(Me.largeCheckBox)
        Me.residencyGroupBox.Controls.Add(Me.studioCheckBox)
        Me.residencyGroupBox.Controls.Add(Me.smallCheckBox)
        Me.residencyGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.residencyGroupBox.Location = New System.Drawing.Point(312, 34)
        Me.residencyGroupBox.Name = "residencyGroupBox"
        Me.residencyGroupBox.Size = New System.Drawing.Size(246, 312)
        Me.residencyGroupBox.TabIndex = 2
        Me.residencyGroupBox.TabStop = False
        Me.residencyGroupBox.Text = "Residency"
        '
        'oneBedCheckBox
        '
        Me.oneBedCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oneBedCheckBox.Location = New System.Drawing.Point(6, 211)
        Me.oneBedCheckBox.Name = "oneBedCheckBox"
        Me.oneBedCheckBox.Size = New System.Drawing.Size(204, 44)
        Me.oneBedCheckBox.TabIndex = 4
        Me.oneBedCheckBox.Text = "&1-Bed Apartment"
        Me.oneBedCheckBox.UseVisualStyleBackColor = True
        '
        'twoBedCheckBox
        '
        Me.twoBedCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.twoBedCheckBox.Location = New System.Drawing.Point(6, 163)
        Me.twoBedCheckBox.Name = "twoBedCheckBox"
        Me.twoBedCheckBox.Size = New System.Drawing.Size(204, 42)
        Me.twoBedCheckBox.TabIndex = 3
        Me.twoBedCheckBox.Text = "&2-Bed Apartment"
        Me.twoBedCheckBox.UseVisualStyleBackColor = True
        '
        'largeCheckBox
        '
        Me.largeCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.largeCheckBox.Location = New System.Drawing.Point(6, 73)
        Me.largeCheckBox.Name = "largeCheckBox"
        Me.largeCheckBox.Size = New System.Drawing.Size(184, 37)
        Me.largeCheckBox.TabIndex = 1
        Me.largeCheckBox.Text = "Lar&ge Hotel"
        Me.largeCheckBox.UseVisualStyleBackColor = True
        '
        'studioCheckBox
        '
        Me.studioCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studioCheckBox.Location = New System.Drawing.Point(6, 116)
        Me.studioCheckBox.Name = "studioCheckBox"
        Me.studioCheckBox.Size = New System.Drawing.Size(204, 41)
        Me.studioCheckBox.TabIndex = 2
        Me.studioCheckBox.Text = "S&tudio"
        Me.studioCheckBox.UseVisualStyleBackColor = True
        '
        'smallCheckBox
        '
        Me.smallCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.smallCheckBox.Location = New System.Drawing.Point(6, 30)
        Me.smallCheckBox.Name = "smallCheckBox"
        Me.smallCheckBox.Size = New System.Drawing.Size(204, 37)
        Me.smallCheckBox.TabIndex = 0
        Me.smallCheckBox.Text = "Sma&ll Hotel"
        Me.smallCheckBox.UseVisualStyleBackColor = True
        '
        'continueButton
        '
        Me.continueButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.continueButton.Location = New System.Drawing.Point(599, 52)
        Me.continueButton.Name = "continueButton"
        Me.continueButton.Size = New System.Drawing.Size(140, 58)
        Me.continueButton.TabIndex = 3
        Me.continueButton.Text = "&Continue"
        Me.continueButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(599, 281)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(140, 58)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(599, 162)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(140, 58)
        Me.clearButton.TabIndex = 4
        Me.clearButton.Text = "Cle&ar"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'neighResultLabel
        '
        Me.neighResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.neighResultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.neighResultLabel.Location = New System.Drawing.Point(17, 406)
        Me.neighResultLabel.Name = "neighResultLabel"
        Me.neighResultLabel.Size = New System.Drawing.Size(498, 84)
        Me.neighResultLabel.TabIndex = 0
        '
        'residencyResultLabel
        '
        Me.residencyResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.residencyResultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.residencyResultLabel.Location = New System.Drawing.Point(17, 552)
        Me.residencyResultLabel.Name = "residencyResultLabel"
        Me.residencyResultLabel.Size = New System.Drawing.Size(498, 89)
        Me.residencyResultLabel.TabIndex = 0
        '
        'chosenResidencyLabel
        '
        Me.chosenResidencyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chosenResidencyLabel.Location = New System.Drawing.Point(17, 515)
        Me.chosenResidencyLabel.Name = "chosenResidencyLabel"
        Me.chosenResidencyLabel.Size = New System.Drawing.Size(498, 37)
        Me.chosenResidencyLabel.TabIndex = 0
        Me.chosenResidencyLabel.Text = "Chosen Residency:"
        '
        'chosenAreaNamesLabel
        '
        Me.chosenAreaNamesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chosenAreaNamesLabel.Location = New System.Drawing.Point(17, 379)
        Me.chosenAreaNamesLabel.Name = "chosenAreaNamesLabel"
        Me.chosenAreaNamesLabel.Size = New System.Drawing.Size(498, 27)
        Me.chosenAreaNamesLabel.TabIndex = 0
        Me.chosenAreaNamesLabel.Text = "Chosen Area Names:"
        '
        'mainForm
        '
        Me.AcceptButton = Me.continueButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(800, 708)
        Me.Controls.Add(Me.chosenAreaNamesLabel)
        Me.Controls.Add(Me.chosenResidencyLabel)
        Me.Controls.Add(Me.residencyResultLabel)
        Me.Controls.Add(Me.neighResultLabel)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.continueButton)
        Me.Controls.Add(Me.residencyGroupBox)
        Me.Controls.Add(Me.areaNamesGroupBox)
        Me.Name = "mainForm"
        Me.Text = "Vacation Rentals"
        Me.areaNamesGroupBox.ResumeLayout(False)
        Me.residencyGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents areaNamesGroupBox As GroupBox
    Friend WithEvents alliedForcesCheckBox As CheckBox
    Friend WithEvents marleyCheckBox As CheckBox
    Friend WithEvents wallRoseCheckBox As CheckBox
    Friend WithEvents wallSinaCheckBox As CheckBox
    Friend WithEvents wallMariaCheckBox As CheckBox
    Friend WithEvents residencyGroupBox As GroupBox
    Friend WithEvents oneBedCheckBox As CheckBox
    Friend WithEvents twoBedCheckBox As CheckBox
    Friend WithEvents largeCheckBox As CheckBox
    Friend WithEvents studioCheckBox As CheckBox
    Friend WithEvents smallCheckBox As CheckBox
    Friend WithEvents continueButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents neighResultLabel As Label
    Friend WithEvents residencyResultLabel As Label
    Friend WithEvents chosenResidencyLabel As Label
    Friend WithEvents chosenAreaNamesLabel As Label
End Class
