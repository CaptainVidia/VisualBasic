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
        Me.lblCelsiusToFahrenheit = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtCelsiusToFahrenheit = New System.Windows.Forms.TextBox()
        Me.lblAnswerFahrenheit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCelsiusToFahrenheit
        '
        Me.lblCelsiusToFahrenheit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelsiusToFahrenheit.Location = New System.Drawing.Point(106, 118)
        Me.lblCelsiusToFahrenheit.Name = "lblCelsiusToFahrenheit"
        Me.lblCelsiusToFahrenheit.Size = New System.Drawing.Size(228, 33)
        Me.lblCelsiusToFahrenheit.TabIndex = 0
        Me.lblCelsiusToFahrenheit.Text = "Celsius To Fahrenheit"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(111, 319)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(145, 90)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(529, 319)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(145, 90)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(315, 319)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(145, 90)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtCelsiusToFahrenheit
        '
        Me.txtCelsiusToFahrenheit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelsiusToFahrenheit.Location = New System.Drawing.Point(111, 171)
        Me.txtCelsiusToFahrenheit.Name = "txtCelsiusToFahrenheit"
        Me.txtCelsiusToFahrenheit.Size = New System.Drawing.Size(223, 31)
        Me.txtCelsiusToFahrenheit.TabIndex = 0
        '
        'lblAnswerFahrenheit
        '
        Me.lblAnswerFahrenheit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnswerFahrenheit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswerFahrenheit.Location = New System.Drawing.Point(422, 169)
        Me.lblAnswerFahrenheit.Name = "lblAnswerFahrenheit"
        Me.lblAnswerFahrenheit.Size = New System.Drawing.Size(228, 33)
        Me.lblAnswerFahrenheit.TabIndex = 7
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAnswerFahrenheit)
        Me.Controls.Add(Me.txtCelsiusToFahrenheit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCelsiusToFahrenheit)
        Me.Name = "mainForm"
        Me.Text = "CelsiusToFahrenheit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCelsiusToFahrenheit As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtCelsiusToFahrenheit As TextBox
    Friend WithEvents lblAnswerFahrenheit As Label
End Class
