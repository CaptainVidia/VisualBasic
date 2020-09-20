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
        Me.grpBoxTicketsSold = New System.Windows.Forms.GroupBox()
        Me.txtBoxClassB = New System.Windows.Forms.TextBox()
        Me.txtBoxClassC = New System.Windows.Forms.TextBox()
        Me.txtBoxClassA = New System.Windows.Forms.TextBox()
        Me.lblClassB = New System.Windows.Forms.Label()
        Me.lblClassC = New System.Windows.Forms.Label()
        Me.lblClassA = New System.Windows.Forms.Label()
        Me.grpBoxRevenue = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRevCVal = New System.Windows.Forms.Label()
        Me.lblRevBVal = New System.Windows.Forms.Label()
        Me.lblRevAVal = New System.Windows.Forms.Label()
        Me.lblClassB2 = New System.Windows.Forms.Label()
        Me.lblClassC2 = New System.Windows.Forms.Label()
        Me.lblClassA2 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpBoxTicketsSold.SuspendLayout()
        Me.grpBoxRevenue.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBoxTicketsSold
        '
        Me.grpBoxTicketsSold.Controls.Add(Me.txtBoxClassB)
        Me.grpBoxTicketsSold.Controls.Add(Me.txtBoxClassC)
        Me.grpBoxTicketsSold.Controls.Add(Me.txtBoxClassA)
        Me.grpBoxTicketsSold.Controls.Add(Me.lblClassB)
        Me.grpBoxTicketsSold.Controls.Add(Me.lblClassC)
        Me.grpBoxTicketsSold.Controls.Add(Me.lblClassA)
        Me.grpBoxTicketsSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxTicketsSold.Location = New System.Drawing.Point(30, 41)
        Me.grpBoxTicketsSold.Name = "grpBoxTicketsSold"
        Me.grpBoxTicketsSold.Size = New System.Drawing.Size(282, 297)
        Me.grpBoxTicketsSold.TabIndex = 0
        Me.grpBoxTicketsSold.TabStop = False
        Me.grpBoxTicketsSold.Text = "Tickets Sold: "
        '
        'txtBoxClassB
        '
        Me.txtBoxClassB.Location = New System.Drawing.Point(136, 105)
        Me.txtBoxClassB.Name = "txtBoxClassB"
        Me.txtBoxClassB.Size = New System.Drawing.Size(100, 31)
        Me.txtBoxClassB.TabIndex = 2
        '
        'txtBoxClassC
        '
        Me.txtBoxClassC.Location = New System.Drawing.Point(136, 169)
        Me.txtBoxClassC.Name = "txtBoxClassC"
        Me.txtBoxClassC.Size = New System.Drawing.Size(100, 31)
        Me.txtBoxClassC.TabIndex = 3
        '
        'txtBoxClassA
        '
        Me.txtBoxClassA.Location = New System.Drawing.Point(136, 48)
        Me.txtBoxClassA.Name = "txtBoxClassA"
        Me.txtBoxClassA.Size = New System.Drawing.Size(100, 31)
        Me.txtBoxClassA.TabIndex = 1
        '
        'lblClassB
        '
        Me.lblClassB.AutoSize = True
        Me.lblClassB.Location = New System.Drawing.Point(6, 111)
        Me.lblClassB.Name = "lblClassB"
        Me.lblClassB.Size = New System.Drawing.Size(98, 25)
        Me.lblClassB.TabIndex = 2
        Me.lblClassB.Text = "Class B: "
        '
        'lblClassC
        '
        Me.lblClassC.AutoSize = True
        Me.lblClassC.Location = New System.Drawing.Point(6, 175)
        Me.lblClassC.Name = "lblClassC"
        Me.lblClassC.Size = New System.Drawing.Size(99, 25)
        Me.lblClassC.TabIndex = 1
        Me.lblClassC.Text = "Class C: "
        '
        'lblClassA
        '
        Me.lblClassA.AutoSize = True
        Me.lblClassA.Location = New System.Drawing.Point(6, 48)
        Me.lblClassA.Name = "lblClassA"
        Me.lblClassA.Size = New System.Drawing.Size(98, 25)
        Me.lblClassA.TabIndex = 0
        Me.lblClassA.Text = "Class A: "
        '
        'grpBoxRevenue
        '
        Me.grpBoxRevenue.Controls.Add(Me.lblTotal)
        Me.grpBoxRevenue.Controls.Add(Me.Label2)
        Me.grpBoxRevenue.Controls.Add(Me.lblRevCVal)
        Me.grpBoxRevenue.Controls.Add(Me.lblRevBVal)
        Me.grpBoxRevenue.Controls.Add(Me.lblRevAVal)
        Me.grpBoxRevenue.Controls.Add(Me.lblClassB2)
        Me.grpBoxRevenue.Controls.Add(Me.lblClassC2)
        Me.grpBoxRevenue.Controls.Add(Me.lblClassA2)
        Me.grpBoxRevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxRevenue.Location = New System.Drawing.Point(463, 41)
        Me.grpBoxRevenue.Name = "grpBoxRevenue"
        Me.grpBoxRevenue.Size = New System.Drawing.Size(282, 297)
        Me.grpBoxRevenue.TabIndex = 6
        Me.grpBoxRevenue.TabStop = False
        Me.grpBoxRevenue.Text = "Revenue Generated:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(136, 195)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(140, 25)
        Me.lblTotal.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Total: "
        '
        'lblRevCVal
        '
        Me.lblRevCVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRevCVal.Location = New System.Drawing.Point(136, 120)
        Me.lblRevCVal.Name = "lblRevCVal"
        Me.lblRevCVal.Size = New System.Drawing.Size(140, 25)
        Me.lblRevCVal.TabIndex = 2
        '
        'lblRevBVal
        '
        Me.lblRevBVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRevBVal.Location = New System.Drawing.Point(136, 85)
        Me.lblRevBVal.Name = "lblRevBVal"
        Me.lblRevBVal.Size = New System.Drawing.Size(140, 25)
        Me.lblRevBVal.TabIndex = 1
        '
        'lblRevAVal
        '
        Me.lblRevAVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRevAVal.Location = New System.Drawing.Point(136, 48)
        Me.lblRevAVal.Name = "lblRevAVal"
        Me.lblRevAVal.Size = New System.Drawing.Size(140, 25)
        Me.lblRevAVal.TabIndex = 1
        '
        'lblClassB2
        '
        Me.lblClassB2.AutoSize = True
        Me.lblClassB2.Location = New System.Drawing.Point(6, 86)
        Me.lblClassB2.Name = "lblClassB2"
        Me.lblClassB2.Size = New System.Drawing.Size(98, 25)
        Me.lblClassB2.TabIndex = 2
        Me.lblClassB2.Text = "Class B: "
        '
        'lblClassC2
        '
        Me.lblClassC2.AutoSize = True
        Me.lblClassC2.Location = New System.Drawing.Point(6, 120)
        Me.lblClassC2.Name = "lblClassC2"
        Me.lblClassC2.Size = New System.Drawing.Size(99, 25)
        Me.lblClassC2.TabIndex = 1
        Me.lblClassC2.Text = "Class C: "
        '
        'lblClassA2
        '
        Me.lblClassA2.AutoSize = True
        Me.lblClassA2.Location = New System.Drawing.Point(7, 48)
        Me.lblClassA2.Name = "lblClassA2"
        Me.lblClassA2.Size = New System.Drawing.Size(98, 25)
        Me.lblClassA2.TabIndex = 0
        Me.lblClassA2.Text = "Class A: "
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(196, 345)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(114, 77)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate &Revenue"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(347, 345)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(114, 77)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(503, 345)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 77)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpBoxRevenue)
        Me.Controls.Add(Me.grpBoxTicketsSold)
        Me.Name = "frmMain"
        Me.Text = "1"
        Me.grpBoxTicketsSold.ResumeLayout(False)
        Me.grpBoxTicketsSold.PerformLayout()
        Me.grpBoxRevenue.ResumeLayout(False)
        Me.grpBoxRevenue.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpBoxTicketsSold As GroupBox
    Friend WithEvents txtBoxClassB As TextBox
    Friend WithEvents txtBoxClassC As TextBox
    Friend WithEvents txtBoxClassA As TextBox
    Friend WithEvents lblClassB As Label
    Friend WithEvents lblClassC As Label
    Friend WithEvents lblClassA As Label
    Friend WithEvents grpBoxRevenue As GroupBox
    Friend WithEvents lblClassB2 As Label
    Friend WithEvents lblClassC2 As Label
    Friend WithEvents lblClassA2 As Label
    Friend WithEvents lblRevAVal As Label
    Friend WithEvents lblRevCVal As Label
    Friend WithEvents lblRevBVal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
