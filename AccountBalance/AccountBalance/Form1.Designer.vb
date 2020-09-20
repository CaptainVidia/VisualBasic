<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblCurrentBalance = New System.Windows.Forms.Label()
        Me.txtBoxCurrentBalance = New System.Windows.Forms.TextBox()
        Me.lblWithdraw = New System.Windows.Forms.Label()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.txtBoxDeposit = New System.Windows.Forms.TextBox()
        Me.txtBoxWithdraw = New System.Windows.Forms.TextBox()
        Me.lblNewBalance = New System.Windows.Forms.Label()
        Me.txtBoxNewBalance = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDescription2 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCurrentBalance
        '
        Me.lblCurrentBalance.AutoSize = True
        Me.lblCurrentBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblCurrentBalance.Location = New System.Drawing.Point(12, 183)
        Me.lblCurrentBalance.Name = "lblCurrentBalance"
        Me.lblCurrentBalance.Size = New System.Drawing.Size(169, 26)
        Me.lblCurrentBalance.TabIndex = 0
        Me.lblCurrentBalance.Text = "Current Balance"
        '
        'txtBoxCurrentBalance
        '
        Me.txtBoxCurrentBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtBoxCurrentBalance.Location = New System.Drawing.Point(17, 223)
        Me.txtBoxCurrentBalance.Name = "txtBoxCurrentBalance"
        Me.txtBoxCurrentBalance.Size = New System.Drawing.Size(164, 32)
        Me.txtBoxCurrentBalance.TabIndex = 1
        '
        'lblWithdraw
        '
        Me.lblWithdraw.AutoSize = True
        Me.lblWithdraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblWithdraw.Location = New System.Drawing.Point(12, 286)
        Me.lblWithdraw.Name = "lblWithdraw"
        Me.lblWithdraw.Size = New System.Drawing.Size(103, 26)
        Me.lblWithdraw.TabIndex = 2
        Me.lblWithdraw.Text = "Withdraw"
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblDeposit.Location = New System.Drawing.Point(156, 286)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(86, 26)
        Me.lblDeposit.TabIndex = 3
        Me.lblDeposit.Text = "Deposit"
        '
        'txtBoxDeposit
        '
        Me.txtBoxDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtBoxDeposit.Location = New System.Drawing.Point(152, 315)
        Me.txtBoxDeposit.Name = "txtBoxDeposit"
        Me.txtBoxDeposit.Size = New System.Drawing.Size(90, 32)
        Me.txtBoxDeposit.TabIndex = 4
        '
        'txtBoxWithdraw
        '
        Me.txtBoxWithdraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtBoxWithdraw.Location = New System.Drawing.Point(12, 315)
        Me.txtBoxWithdraw.Name = "txtBoxWithdraw"
        Me.txtBoxWithdraw.Size = New System.Drawing.Size(103, 32)
        Me.txtBoxWithdraw.TabIndex = 5
        '
        'lblNewBalance
        '
        Me.lblNewBalance.AutoSize = True
        Me.lblNewBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblNewBalance.Location = New System.Drawing.Point(7, 392)
        Me.lblNewBalance.Name = "lblNewBalance"
        Me.lblNewBalance.Size = New System.Drawing.Size(141, 26)
        Me.lblNewBalance.TabIndex = 6
        Me.lblNewBalance.Text = "New Balance"
        '
        'txtBoxNewBalance
        '
        Me.txtBoxNewBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtBoxNewBalance.Location = New System.Drawing.Point(9, 421)
        Me.txtBoxNewBalance.Name = "txtBoxNewBalance"
        Me.txtBoxNewBalance.Size = New System.Drawing.Size(139, 32)
        Me.txtBoxNewBalance.TabIndex = 7
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblDescription.Location = New System.Drawing.Point(157, 114)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(163, 20)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Enter Amounts Below"
        '
        'lblDescription2
        '
        Me.lblDescription2.AutoSize = True
        Me.lblDescription2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblDescription2.Location = New System.Drawing.Point(157, 134)
        Me.lblDescription2.Name = "lblDescription2"
        Me.lblDescription2.Size = New System.Drawing.Size(217, 20)
        Me.lblDescription2.TabIndex = 9
        Me.lblDescription2.Text = "If Amount is 0, Please enter 0"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCalculate.Location = New System.Drawing.Point(282, 308)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(118, 44)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnClear.Location = New System.Drawing.Point(236, 421)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 47)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblTitle.Location = New System.Drawing.Point(182, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(241, 29)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "Uncle Scooge's Bank"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnExit.Location = New System.Drawing.Point(358, 421)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 47)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 673)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblDescription2)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtBoxNewBalance)
        Me.Controls.Add(Me.lblNewBalance)
        Me.Controls.Add(Me.txtBoxWithdraw)
        Me.Controls.Add(Me.txtBoxDeposit)
        Me.Controls.Add(Me.lblDeposit)
        Me.Controls.Add(Me.lblWithdraw)
        Me.Controls.Add(Me.txtBoxCurrentBalance)
        Me.Controls.Add(Me.lblCurrentBalance)
        Me.Name = "Form1"
        Me.Text = "Uncle Scooge's Bank"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCurrentBalance As Label
    Friend WithEvents txtBoxCurrentBalance As TextBox
    Friend WithEvents lblWithdraw As Label
    Friend WithEvents lblDeposit As Label
    Friend WithEvents txtBoxDeposit As TextBox
    Friend WithEvents txtBoxWithdraw As TextBox
    Friend WithEvents lblNewBalance As Label
    Friend WithEvents txtBoxNewBalance As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblDescription2 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnExit As Button
End Class
