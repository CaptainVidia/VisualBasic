<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.radbtnPenny = New System.Windows.Forms.RadioButton()
        Me.radbtnNickel = New System.Windows.Forms.RadioButton()
        Me.radbtnDime = New System.Windows.Forms.RadioButton()
        Me.radbtnQuarter = New System.Windows.Forms.RadioButton()
        Me.nupdDays = New System.Windows.Forms.NumericUpDown()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lstPay = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkClear = New System.Windows.Forms.CheckBox()
        CType(Me.nupdDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radbtnPenny
        '
        Me.radbtnPenny.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radbtnPenny.Location = New System.Drawing.Point(109, 76)
        Me.radbtnPenny.Name = "radbtnPenny"
        Me.radbtnPenny.Size = New System.Drawing.Size(178, 34)
        Me.radbtnPenny.TabIndex = 0
        Me.radbtnPenny.TabStop = True
        Me.radbtnPenny.Text = "&Penny"
        Me.radbtnPenny.UseVisualStyleBackColor = True
        '
        'radbtnNickel
        '
        Me.radbtnNickel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radbtnNickel.Location = New System.Drawing.Point(109, 116)
        Me.radbtnNickel.Name = "radbtnNickel"
        Me.radbtnNickel.Size = New System.Drawing.Size(178, 34)
        Me.radbtnNickel.TabIndex = 1
        Me.radbtnNickel.TabStop = True
        Me.radbtnNickel.Text = "&Nickel"
        Me.radbtnNickel.UseVisualStyleBackColor = True
        '
        'radbtnDime
        '
        Me.radbtnDime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radbtnDime.Location = New System.Drawing.Point(109, 156)
        Me.radbtnDime.Name = "radbtnDime"
        Me.radbtnDime.Size = New System.Drawing.Size(178, 34)
        Me.radbtnDime.TabIndex = 2
        Me.radbtnDime.TabStop = True
        Me.radbtnDime.Text = "&Dime"
        Me.radbtnDime.UseVisualStyleBackColor = True
        '
        'radbtnQuarter
        '
        Me.radbtnQuarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radbtnQuarter.Location = New System.Drawing.Point(109, 196)
        Me.radbtnQuarter.Name = "radbtnQuarter"
        Me.radbtnQuarter.Size = New System.Drawing.Size(178, 34)
        Me.radbtnQuarter.TabIndex = 3
        Me.radbtnQuarter.TabStop = True
        Me.radbtnQuarter.Text = "&Quarter"
        Me.radbtnQuarter.UseVisualStyleBackColor = True
        '
        'nupdDays
        '
        Me.nupdDays.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nupdDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupdDays.Location = New System.Drawing.Point(286, 119)
        Me.nupdDays.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.nupdDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupdDays.Name = "nupdDays"
        Me.nupdDays.ReadOnly = True
        Me.nupdDays.Size = New System.Drawing.Size(51, 31)
        Me.nupdDays.TabIndex = 7
        Me.nupdDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nupdDays.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblDays
        '
        Me.lblDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDays.Location = New System.Drawing.Point(281, 76)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(100, 37)
        Me.lblDays.TabIndex = 0
        Me.lblDays.Text = "D&ays"
        '
        'lstPay
        '
        Me.lstPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPay.FormattingEnabled = True
        Me.lstPay.Location = New System.Drawing.Point(400, 60)
        Me.lstPay.Name = "lstPay"
        Me.lstPay.ScrollAlwaysVisible = True
        Me.lstPay.Size = New System.Drawing.Size(241, 407)
        Me.lstPay.TabIndex = 8
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(44, 296)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(243, 50)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate Pay"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(44, 352)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(243, 50)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(44, 408)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(243, 50)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkClear
        '
        Me.chkClear.Location = New System.Drawing.Point(688, 60)
        Me.chkClear.Name = "chkClear"
        Me.chkClear.Size = New System.Drawing.Size(104, 24)
        Me.chkClear.TabIndex = 9
        Me.chkClear.Text = "Clea&r List"
        Me.chkClear.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(883, 499)
        Me.Controls.Add(Me.chkClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstPay)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.nupdDays)
        Me.Controls.Add(Me.radbtnQuarter)
        Me.Controls.Add(Me.radbtnNickel)
        Me.Controls.Add(Me.radbtnDime)
        Me.Controls.Add(Me.radbtnPenny)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pennies For The Day"
        CType(Me.nupdDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radbtnPenny As RadioButton
    Friend WithEvents radbtnNickel As RadioButton
    Friend WithEvents radbtnDime As RadioButton
    Friend WithEvents radbtnQuarter As RadioButton
    Friend WithEvents nupdDays As NumericUpDown
    Friend WithEvents lblDays As Label
    Friend WithEvents lstPay As ListBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkClear As CheckBox
End Class
