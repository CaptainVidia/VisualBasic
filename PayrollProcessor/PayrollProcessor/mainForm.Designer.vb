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
        Me.rateLabel = New System.Windows.Forms.Label()
        Me.rateTextBox = New System.Windows.Forms.TextBox()
        Me.hoursWorkedLabel = New System.Windows.Forms.Label()
        Me.hoursTextBox = New System.Windows.Forms.TextBox()
        Me.regHoursLabel = New System.Windows.Forms.Label()
        Me.regHoursValLabel = New System.Windows.Forms.Label()
        Me.otHoursValLabel = New System.Windows.Forms.Label()
        Me.otHoursLabel = New System.Windows.Forms.Label()
        Me.regPayValLabel = New System.Windows.Forms.Label()
        Me.regPayLabel = New System.Windows.Forms.Label()
        Me.otPayValLabel = New System.Windows.Forms.Label()
        Me.otPayLabel = New System.Windows.Forms.Label()
        Me.stateTaxValLabel = New System.Windows.Forms.Label()
        Me.stateTaxLabel = New System.Windows.Forms.Label()
        Me.fedTaxValLabel = New System.Windows.Forms.Label()
        Me.fedTaxLabel = New System.Windows.Forms.Label()
        Me.ficaTaxValLabel = New System.Windows.Forms.Label()
        Me.ficaTaxLabel = New System.Windows.Forms.Label()
        Me.grossPayValLabel = New System.Windows.Forms.Label()
        Me.grossPayLabel = New System.Windows.Forms.Label()
        Me.netPayValLabel = New System.Windows.Forms.Label()
        Me.netPayLabel = New System.Windows.Forms.Label()
        Me.totalDeductValLabel = New System.Windows.Forms.Label()
        Me.totalDeductLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rateLabel
        '
        Me.rateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rateLabel.Location = New System.Drawing.Point(30, 196)
        Me.rateLabel.Name = "rateLabel"
        Me.rateLabel.Size = New System.Drawing.Size(172, 37)
        Me.rateLabel.TabIndex = 3
        Me.rateLabel.Text = "Rate:"
        '
        'rateTextBox
        '
        Me.rateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rateTextBox.Location = New System.Drawing.Point(30, 236)
        Me.rateTextBox.Name = "rateTextBox"
        Me.rateTextBox.Size = New System.Drawing.Size(172, 31)
        Me.rateTextBox.TabIndex = 2
        Me.rateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'hoursWorkedLabel
        '
        Me.hoursWorkedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoursWorkedLabel.Location = New System.Drawing.Point(30, 65)
        Me.hoursWorkedLabel.Name = "hoursWorkedLabel"
        Me.hoursWorkedLabel.Size = New System.Drawing.Size(172, 37)
        Me.hoursWorkedLabel.TabIndex = 5
        Me.hoursWorkedLabel.Text = "Hours Worked:"
        '
        'hoursTextBox
        '
        Me.hoursTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoursTextBox.Location = New System.Drawing.Point(30, 105)
        Me.hoursTextBox.Name = "hoursTextBox"
        Me.hoursTextBox.Size = New System.Drawing.Size(172, 31)
        Me.hoursTextBox.TabIndex = 1
        Me.hoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'regHoursLabel
        '
        Me.regHoursLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regHoursLabel.Location = New System.Drawing.Point(366, 30)
        Me.regHoursLabel.Name = "regHoursLabel"
        Me.regHoursLabel.Size = New System.Drawing.Size(172, 37)
        Me.regHoursLabel.TabIndex = 6
        Me.regHoursLabel.Text = "Regular Hours:"
        '
        'regHoursValLabel
        '
        Me.regHoursValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.regHoursValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regHoursValLabel.Location = New System.Drawing.Point(366, 70)
        Me.regHoursValLabel.Name = "regHoursValLabel"
        Me.regHoursValLabel.Size = New System.Drawing.Size(172, 37)
        Me.regHoursValLabel.TabIndex = 7
        '
        'otHoursValLabel
        '
        Me.otHoursValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.otHoursValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otHoursValLabel.Location = New System.Drawing.Point(366, 147)
        Me.otHoursValLabel.Name = "otHoursValLabel"
        Me.otHoursValLabel.Size = New System.Drawing.Size(172, 37)
        Me.otHoursValLabel.TabIndex = 9
        '
        'otHoursLabel
        '
        Me.otHoursLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otHoursLabel.Location = New System.Drawing.Point(366, 107)
        Me.otHoursLabel.Name = "otHoursLabel"
        Me.otHoursLabel.Size = New System.Drawing.Size(172, 37)
        Me.otHoursLabel.TabIndex = 8
        Me.otHoursLabel.Text = "Overtime Hours:"
        '
        'regPayValLabel
        '
        Me.regPayValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.regPayValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regPayValLabel.Location = New System.Drawing.Point(366, 224)
        Me.regPayValLabel.Name = "regPayValLabel"
        Me.regPayValLabel.Size = New System.Drawing.Size(172, 37)
        Me.regPayValLabel.TabIndex = 11
        '
        'regPayLabel
        '
        Me.regPayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regPayLabel.Location = New System.Drawing.Point(366, 184)
        Me.regPayLabel.Name = "regPayLabel"
        Me.regPayLabel.Size = New System.Drawing.Size(172, 37)
        Me.regPayLabel.TabIndex = 10
        Me.regPayLabel.Text = "Regular Pay:"
        '
        'otPayValLabel
        '
        Me.otPayValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.otPayValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otPayValLabel.Location = New System.Drawing.Point(361, 317)
        Me.otPayValLabel.Name = "otPayValLabel"
        Me.otPayValLabel.Size = New System.Drawing.Size(172, 37)
        Me.otPayValLabel.TabIndex = 13
        '
        'otPayLabel
        '
        Me.otPayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otPayLabel.Location = New System.Drawing.Point(361, 277)
        Me.otPayLabel.Name = "otPayLabel"
        Me.otPayLabel.Size = New System.Drawing.Size(172, 37)
        Me.otPayLabel.TabIndex = 12
        Me.otPayLabel.Text = "Overtime Pay:"
        '
        'stateTaxValLabel
        '
        Me.stateTaxValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stateTaxValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stateTaxValLabel.Location = New System.Drawing.Point(571, 317)
        Me.stateTaxValLabel.Name = "stateTaxValLabel"
        Me.stateTaxValLabel.Size = New System.Drawing.Size(172, 37)
        Me.stateTaxValLabel.TabIndex = 21
        '
        'stateTaxLabel
        '
        Me.stateTaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stateTaxLabel.Location = New System.Drawing.Point(571, 277)
        Me.stateTaxLabel.Name = "stateTaxLabel"
        Me.stateTaxLabel.Size = New System.Drawing.Size(172, 37)
        Me.stateTaxLabel.TabIndex = 20
        Me.stateTaxLabel.Text = "State Tax:"
        '
        'fedTaxValLabel
        '
        Me.fedTaxValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fedTaxValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fedTaxValLabel.Location = New System.Drawing.Point(576, 224)
        Me.fedTaxValLabel.Name = "fedTaxValLabel"
        Me.fedTaxValLabel.Size = New System.Drawing.Size(172, 37)
        Me.fedTaxValLabel.TabIndex = 19
        '
        'fedTaxLabel
        '
        Me.fedTaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fedTaxLabel.Location = New System.Drawing.Point(576, 184)
        Me.fedTaxLabel.Name = "fedTaxLabel"
        Me.fedTaxLabel.Size = New System.Drawing.Size(172, 37)
        Me.fedTaxLabel.TabIndex = 18
        Me.fedTaxLabel.Text = "Federal Tax:"
        '
        'ficaTaxValLabel
        '
        Me.ficaTaxValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ficaTaxValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficaTaxValLabel.Location = New System.Drawing.Point(576, 147)
        Me.ficaTaxValLabel.Name = "ficaTaxValLabel"
        Me.ficaTaxValLabel.Size = New System.Drawing.Size(172, 37)
        Me.ficaTaxValLabel.TabIndex = 17
        '
        'ficaTaxLabel
        '
        Me.ficaTaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficaTaxLabel.Location = New System.Drawing.Point(576, 107)
        Me.ficaTaxLabel.Name = "ficaTaxLabel"
        Me.ficaTaxLabel.Size = New System.Drawing.Size(172, 37)
        Me.ficaTaxLabel.TabIndex = 16
        Me.ficaTaxLabel.Text = "Financial Tax:"
        '
        'grossPayValLabel
        '
        Me.grossPayValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grossPayValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grossPayValLabel.Location = New System.Drawing.Point(576, 70)
        Me.grossPayValLabel.Name = "grossPayValLabel"
        Me.grossPayValLabel.Size = New System.Drawing.Size(172, 37)
        Me.grossPayValLabel.TabIndex = 15
        '
        'grossPayLabel
        '
        Me.grossPayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grossPayLabel.Location = New System.Drawing.Point(576, 30)
        Me.grossPayLabel.Name = "grossPayLabel"
        Me.grossPayLabel.Size = New System.Drawing.Size(172, 37)
        Me.grossPayLabel.TabIndex = 14
        Me.grossPayLabel.Text = "Gross Pay:"
        '
        'netPayValLabel
        '
        Me.netPayValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.netPayValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.netPayValLabel.Location = New System.Drawing.Point(571, 412)
        Me.netPayValLabel.Name = "netPayValLabel"
        Me.netPayValLabel.Size = New System.Drawing.Size(172, 37)
        Me.netPayValLabel.TabIndex = 25
        '
        'netPayLabel
        '
        Me.netPayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.netPayLabel.Location = New System.Drawing.Point(571, 372)
        Me.netPayLabel.Name = "netPayLabel"
        Me.netPayLabel.Size = New System.Drawing.Size(172, 37)
        Me.netPayLabel.TabIndex = 24
        Me.netPayLabel.Text = "Net Pay:"
        '
        'totalDeductValLabel
        '
        Me.totalDeductValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalDeductValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalDeductValLabel.Location = New System.Drawing.Point(361, 412)
        Me.totalDeductValLabel.Name = "totalDeductValLabel"
        Me.totalDeductValLabel.Size = New System.Drawing.Size(172, 37)
        Me.totalDeductValLabel.TabIndex = 23
        '
        'totalDeductLabel
        '
        Me.totalDeductLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalDeductLabel.Location = New System.Drawing.Point(361, 372)
        Me.totalDeductLabel.Name = "totalDeductLabel"
        Me.totalDeductLabel.Size = New System.Drawing.Size(185, 37)
        Me.totalDeductLabel.TabIndex = 22
        Me.totalDeductLabel.Text = "Total Deductions:"
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(44, 522)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(158, 82)
        Me.calculateButton.TabIndex = 3
        Me.calculateButton.Text = "C&alculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(261, 522)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(158, 82)
        Me.clearButton.TabIndex = 4
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(471, 522)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(158, 82)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(800, 629)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.netPayValLabel)
        Me.Controls.Add(Me.netPayLabel)
        Me.Controls.Add(Me.totalDeductValLabel)
        Me.Controls.Add(Me.totalDeductLabel)
        Me.Controls.Add(Me.stateTaxValLabel)
        Me.Controls.Add(Me.stateTaxLabel)
        Me.Controls.Add(Me.fedTaxValLabel)
        Me.Controls.Add(Me.fedTaxLabel)
        Me.Controls.Add(Me.ficaTaxValLabel)
        Me.Controls.Add(Me.ficaTaxLabel)
        Me.Controls.Add(Me.grossPayValLabel)
        Me.Controls.Add(Me.grossPayLabel)
        Me.Controls.Add(Me.otPayValLabel)
        Me.Controls.Add(Me.otPayLabel)
        Me.Controls.Add(Me.regPayValLabel)
        Me.Controls.Add(Me.regPayLabel)
        Me.Controls.Add(Me.otHoursValLabel)
        Me.Controls.Add(Me.otHoursLabel)
        Me.Controls.Add(Me.regHoursValLabel)
        Me.Controls.Add(Me.regHoursLabel)
        Me.Controls.Add(Me.hoursWorkedLabel)
        Me.Controls.Add(Me.hoursTextBox)
        Me.Controls.Add(Me.rateLabel)
        Me.Controls.Add(Me.rateTextBox)
        Me.Name = "mainForm"
        Me.Text = "Payroll Processor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rateLabel As Label
    Friend WithEvents rateTextBox As TextBox
    Friend WithEvents hoursWorkedLabel As Label
    Friend WithEvents hoursTextBox As TextBox
    Friend WithEvents regHoursLabel As Label
    Friend WithEvents regHoursValLabel As Label
    Friend WithEvents otHoursValLabel As Label
    Friend WithEvents otHoursLabel As Label
    Friend WithEvents regPayValLabel As Label
    Friend WithEvents regPayLabel As Label
    Friend WithEvents otPayValLabel As Label
    Friend WithEvents otPayLabel As Label
    Friend WithEvents stateTaxValLabel As Label
    Friend WithEvents stateTaxLabel As Label
    Friend WithEvents fedTaxValLabel As Label
    Friend WithEvents fedTaxLabel As Label
    Friend WithEvents ficaTaxValLabel As Label
    Friend WithEvents ficaTaxLabel As Label
    Friend WithEvents grossPayValLabel As Label
    Friend WithEvents grossPayLabel As Label
    Friend WithEvents netPayValLabel As Label
    Friend WithEvents netPayLabel As Label
    Friend WithEvents totalDeductValLabel As Label
    Friend WithEvents totalDeductLabel As Label
    Friend WithEvents calculateButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
End Class
