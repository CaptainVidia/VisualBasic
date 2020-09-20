<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtBoxPrice = New System.Windows.Forms.TextBox()
        Me.txtBoxSalesTax = New System.Windows.Forms.TextBox()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtBoxTotal = New System.Windows.Forms.TextBox()
        Me.btnAddToPrice = New System.Windows.Forms.Button()
        Me.lblAddToPrice = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.txtBoxGrandTotal = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblTitle.Location = New System.Drawing.Point(194, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(237, 24)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Uncle Scrooge's Sales Tax"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnCalculate.Location = New System.Drawing.Point(70, 268)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 50)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblPrice.Location = New System.Drawing.Point(65, 127)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(135, 26)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "Price of Item"
        '
        'txtBoxPrice
        '
        Me.txtBoxPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtBoxPrice.Location = New System.Drawing.Point(70, 160)
        Me.txtBoxPrice.Name = "txtBoxPrice"
        Me.txtBoxPrice.Size = New System.Drawing.Size(100, 32)
        Me.txtBoxPrice.TabIndex = 4
        '
        'txtBoxSalesTax
        '
        Me.txtBoxSalesTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtBoxSalesTax.Location = New System.Drawing.Point(70, 230)
        Me.txtBoxSalesTax.Name = "txtBoxSalesTax"
        Me.txtBoxSalesTax.Size = New System.Drawing.Size(100, 32)
        Me.txtBoxSalesTax.TabIndex = 5
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblSalesTax.Location = New System.Drawing.Point(68, 201)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(193, 26)
        Me.lblSalesTax.TabIndex = 6
        Me.lblSalesTax.Text = "Sales Tax in (0.00)"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblTotal.Location = New System.Drawing.Point(72, 330)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(59, 26)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total"
        '
        'txtBoxTotal
        '
        Me.txtBoxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtBoxTotal.Location = New System.Drawing.Point(73, 359)
        Me.txtBoxTotal.Name = "txtBoxTotal"
        Me.txtBoxTotal.Size = New System.Drawing.Size(100, 32)
        Me.txtBoxTotal.TabIndex = 8
        '
        'btnAddToPrice
        '
        Me.btnAddToPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddToPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnAddToPrice.Location = New System.Drawing.Point(70, 437)
        Me.btnAddToPrice.Name = "btnAddToPrice"
        Me.btnAddToPrice.Size = New System.Drawing.Size(122, 43)
        Me.btnAddToPrice.TabIndex = 9
        Me.btnAddToPrice.Text = "Calculate"
        Me.btnAddToPrice.UseVisualStyleBackColor = False
        '
        'lblAddToPrice
        '
        Me.lblAddToPrice.AutoSize = True
        Me.lblAddToPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblAddToPrice.Location = New System.Drawing.Point(72, 408)
        Me.lblAddToPrice.Name = "lblAddToPrice"
        Me.lblAddToPrice.Size = New System.Drawing.Size(137, 26)
        Me.lblAddToPrice.TabIndex = 10
        Me.lblAddToPrice.Text = "Add To Price"
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblGrandTotal.Location = New System.Drawing.Point(318, 127)
        Me.lblGrandTotal.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(125, 26)
        Me.lblGrandTotal.TabIndex = 12
        Me.lblGrandTotal.Text = "Grand Total"
        '
        'txtBoxGrandTotal
        '
        Me.txtBoxGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtBoxGrandTotal.Location = New System.Drawing.Point(313, 160)
        Me.txtBoxGrandTotal.Name = "txtBoxGrandTotal"
        Me.txtBoxGrandTotal.Size = New System.Drawing.Size(154, 32)
        Me.txtBoxGrandTotal.TabIndex = 12
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnClear.Location = New System.Drawing.Point(421, 422)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 50)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnExit.Location = New System.Drawing.Point(285, 422)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 50)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(600, 704)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtBoxGrandTotal)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.lblAddToPrice)
        Me.Controls.Add(Me.btnAddToPrice)
        Me.Controls.Add(Me.txtBoxTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.txtBoxSalesTax)
        Me.Controls.Add(Me.txtBoxPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form"
        Me.Text = "Uncle Scooge's Sale Tax"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtBoxPrice As TextBox
    Friend WithEvents txtBoxSalesTax As TextBox
    Friend WithEvents lblSalesTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtBoxTotal As TextBox
    Friend WithEvents btnAddToPrice As Button
    Friend WithEvents lblAddToPrice As Label
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents txtBoxGrandTotal As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
