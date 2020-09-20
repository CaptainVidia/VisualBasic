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
        Me.lengthStayLabel = New System.Windows.Forms.Label()
        Me.lengthStayValTextBox = New System.Windows.Forms.TextBox()
        Me.medicationLabel = New System.Windows.Forms.Label()
        Me.medicationValTextBox = New System.Windows.Forms.TextBox()
        Me.surgicalChargeLabel = New System.Windows.Forms.Label()
        Me.surgicalChargeValTextBox = New System.Windows.Forms.TextBox()
        Me.labFeeLabel = New System.Windows.Forms.Label()
        Me.labFeeTextBox = New System.Windows.Forms.TextBox()
        Me.physicalRehabLabel = New System.Windows.Forms.Label()
        Me.physicalRehabValTextBox = New System.Windows.Forms.TextBox()
        Me.totalValLabel = New System.Windows.Forms.Label()
        Me.calcuateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lengthStayLabel
        '
        Me.lengthStayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lengthStayLabel.Location = New System.Drawing.Point(66, 69)
        Me.lengthStayLabel.Name = "lengthStayLabel"
        Me.lengthStayLabel.Size = New System.Drawing.Size(246, 34)
        Me.lengthStayLabel.TabIndex = 2
        Me.lengthStayLabel.Text = "Length of Stay (Days):"
        '
        'lengthStayValTextBox
        '
        Me.lengthStayValTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lengthStayValTextBox.Location = New System.Drawing.Point(333, 66)
        Me.lengthStayValTextBox.Name = "lengthStayValTextBox"
        Me.lengthStayValTextBox.Size = New System.Drawing.Size(208, 31)
        Me.lengthStayValTextBox.TabIndex = 0
        Me.lengthStayValTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'medicationLabel
        '
        Me.medicationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medicationLabel.Location = New System.Drawing.Point(66, 115)
        Me.medicationLabel.Name = "medicationLabel"
        Me.medicationLabel.Size = New System.Drawing.Size(138, 34)
        Me.medicationLabel.TabIndex = 2
        Me.medicationLabel.Text = "Medication:"
        '
        'medicationValTextBox
        '
        Me.medicationValTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medicationValTextBox.Location = New System.Drawing.Point(333, 112)
        Me.medicationValTextBox.Name = "medicationValTextBox"
        Me.medicationValTextBox.Size = New System.Drawing.Size(208, 31)
        Me.medicationValTextBox.TabIndex = 1
        Me.medicationValTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'surgicalChargeLabel
        '
        Me.surgicalChargeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surgicalChargeLabel.Location = New System.Drawing.Point(66, 158)
        Me.surgicalChargeLabel.Name = "surgicalChargeLabel"
        Me.surgicalChargeLabel.Size = New System.Drawing.Size(193, 34)
        Me.surgicalChargeLabel.TabIndex = 2
        Me.surgicalChargeLabel.Text = "Surgical Charges: "
        '
        'surgicalChargeValTextBox
        '
        Me.surgicalChargeValTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surgicalChargeValTextBox.Location = New System.Drawing.Point(333, 155)
        Me.surgicalChargeValTextBox.Name = "surgicalChargeValTextBox"
        Me.surgicalChargeValTextBox.Size = New System.Drawing.Size(208, 31)
        Me.surgicalChargeValTextBox.TabIndex = 2
        Me.surgicalChargeValTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labFeeLabel
        '
        Me.labFeeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labFeeLabel.Location = New System.Drawing.Point(66, 202)
        Me.labFeeLabel.Name = "labFeeLabel"
        Me.labFeeLabel.Size = New System.Drawing.Size(150, 34)
        Me.labFeeLabel.TabIndex = 2
        Me.labFeeLabel.Text = "Labe Fees: "
        '
        'labFeeTextBox
        '
        Me.labFeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labFeeTextBox.Location = New System.Drawing.Point(333, 199)
        Me.labFeeTextBox.Name = "labFeeTextBox"
        Me.labFeeTextBox.Size = New System.Drawing.Size(208, 31)
        Me.labFeeTextBox.TabIndex = 3
        Me.labFeeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'physicalRehabLabel
        '
        Me.physicalRehabLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.physicalRehabLabel.Location = New System.Drawing.Point(66, 252)
        Me.physicalRehabLabel.Name = "physicalRehabLabel"
        Me.physicalRehabLabel.Size = New System.Drawing.Size(193, 34)
        Me.physicalRehabLabel.TabIndex = 2
        Me.physicalRehabLabel.Text = "Physical Rehab: "
        '
        'physicalRehabValTextBox
        '
        Me.physicalRehabValTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.physicalRehabValTextBox.Location = New System.Drawing.Point(333, 249)
        Me.physicalRehabValTextBox.Name = "physicalRehabValTextBox"
        Me.physicalRehabValTextBox.Size = New System.Drawing.Size(208, 31)
        Me.physicalRehabValTextBox.TabIndex = 4
        Me.physicalRehabValTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totalValLabel
        '
        Me.totalValLabel.BackColor = System.Drawing.Color.Transparent
        Me.totalValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalValLabel.Location = New System.Drawing.Point(137, 332)
        Me.totalValLabel.Name = "totalValLabel"
        Me.totalValLabel.Size = New System.Drawing.Size(475, 38)
        Me.totalValLabel.TabIndex = 4
        Me.totalValLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'calcuateButton
        '
        Me.calcuateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcuateButton.Location = New System.Drawing.Point(92, 416)
        Me.calcuateButton.Name = "calcuateButton"
        Me.calcuateButton.Size = New System.Drawing.Size(164, 75)
        Me.calcuateButton.TabIndex = 5
        Me.calcuateButton.Text = "C&alculate Charges"
        Me.calcuateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(297, 416)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(164, 75)
        Me.clearButton.TabIndex = 6
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(515, 416)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(164, 75)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AcceptButton = Me.calcuateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(800, 587)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcuateButton)
        Me.Controls.Add(Me.totalValLabel)
        Me.Controls.Add(Me.physicalRehabValTextBox)
        Me.Controls.Add(Me.labFeeTextBox)
        Me.Controls.Add(Me.surgicalChargeValTextBox)
        Me.Controls.Add(Me.medicationValTextBox)
        Me.Controls.Add(Me.lengthStayValTextBox)
        Me.Controls.Add(Me.physicalRehabLabel)
        Me.Controls.Add(Me.labFeeLabel)
        Me.Controls.Add(Me.surgicalChargeLabel)
        Me.Controls.Add(Me.medicationLabel)
        Me.Controls.Add(Me.lengthStayLabel)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hospital Charges"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lengthStayLabel As Label
    Friend WithEvents lengthStayValTextBox As TextBox
    Friend WithEvents medicationLabel As Label
    Friend WithEvents medicationValTextBox As TextBox
    Friend WithEvents surgicalChargeLabel As Label
    Friend WithEvents surgicalChargeValTextBox As TextBox
    Friend WithEvents labFeeLabel As Label
    Friend WithEvents labFeeTextBox As TextBox
    Friend WithEvents physicalRehabLabel As Label
    Friend WithEvents physicalRehabValTextBox As TextBox
    Friend WithEvents totalValLabel As Label
    Friend WithEvents calcuateButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
End Class
