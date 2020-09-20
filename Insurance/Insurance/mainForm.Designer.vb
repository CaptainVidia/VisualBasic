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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.percentLabel = New System.Windows.Forms.Label()
        Me.recommendedInsuranceLabel = New System.Windows.Forms.Label()
        Me.replacementCostLabel = New System.Windows.Forms.Label()
        Me.costTextBox = New System.Windows.Forms.TextBox()
        Me.percentTextBox = New System.Windows.Forms.TextBox()
        Me.insuranceValLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(492, 273)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(136, 49)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(110, 273)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(136, 49)
        Me.clearButton.TabIndex = 4
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(301, 273)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(136, 49)
        Me.calculateButton.TabIndex = 5
        Me.calculateButton.Text = "C&alculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'percentLabel
        '
        Me.percentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percentLabel.Location = New System.Drawing.Point(55, 50)
        Me.percentLabel.Name = "percentLabel"
        Me.percentLabel.Size = New System.Drawing.Size(382, 22)
        Me.percentLabel.TabIndex = 0
        Me.percentLabel.Text = "Enter Percent of Replacement:"
        '
        'recommendedInsuranceLabel
        '
        Me.recommendedInsuranceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recommendedInsuranceLabel.Location = New System.Drawing.Point(55, 158)
        Me.recommendedInsuranceLabel.Name = "recommendedInsuranceLabel"
        Me.recommendedInsuranceLabel.Size = New System.Drawing.Size(417, 22)
        Me.recommendedInsuranceLabel.TabIndex = 0
        Me.recommendedInsuranceLabel.Text = "Buy this much replacement insurance:"
        '
        'replacementCostLabel
        '
        Me.replacementCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.replacementCostLabel.Location = New System.Drawing.Point(55, 101)
        Me.replacementCostLabel.Name = "replacementCostLabel"
        Me.replacementCostLabel.Size = New System.Drawing.Size(335, 22)
        Me.replacementCostLabel.TabIndex = 0
        Me.replacementCostLabel.Text = "Enter cost of replacement:"
        '
        'costTextBox
        '
        Me.costTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costTextBox.Location = New System.Drawing.Point(533, 98)
        Me.costTextBox.Name = "costTextBox"
        Me.costTextBox.Size = New System.Drawing.Size(100, 31)
        Me.costTextBox.TabIndex = 2
        Me.costTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'percentTextBox
        '
        Me.percentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percentTextBox.Location = New System.Drawing.Point(533, 47)
        Me.percentTextBox.Name = "percentTextBox"
        Me.percentTextBox.Size = New System.Drawing.Size(100, 31)
        Me.percentTextBox.TabIndex = 1
        Me.percentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'insuranceValLabel
        '
        Me.insuranceValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.insuranceValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insuranceValLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.insuranceValLabel.Location = New System.Drawing.Point(530, 157)
        Me.insuranceValLabel.Name = "insuranceValLabel"
        Me.insuranceValLabel.Size = New System.Drawing.Size(103, 34)
        Me.insuranceValLabel.TabIndex = 7
        Me.insuranceValLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mainForm
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.insuranceValLabel)
        Me.Controls.Add(Me.percentTextBox)
        Me.Controls.Add(Me.costTextBox)
        Me.Controls.Add(Me.replacementCostLabel)
        Me.Controls.Add(Me.recommendedInsuranceLabel)
        Me.Controls.Add(Me.percentLabel)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Name = "mainForm"
        Me.Text = "Insurance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents calculateButton As Button
    Friend WithEvents percentLabel As Label
    Friend WithEvents recommendedInsuranceLabel As Label
    Friend WithEvents replacementCostLabel As Label
    Friend WithEvents costTextBox As TextBox
    Friend WithEvents percentTextBox As TextBox
    Friend WithEvents insuranceValLabel As Label
End Class
