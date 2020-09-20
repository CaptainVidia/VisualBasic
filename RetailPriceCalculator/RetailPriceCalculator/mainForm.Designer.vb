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
        Me.wsCostItemLabel = New System.Windows.Forms.Label()
        Me.wsCostItemValTextBox = New System.Windows.Forms.TextBox()
        Me.markupLabel = New System.Windows.Forms.Label()
        Me.markupValTextBox = New System.Windows.Forms.TextBox()
        Me.retailPriceLabel = New System.Windows.Forms.Label()
        Me.retaiPriceValLabel = New System.Windows.Forms.Label()
        Me.getRetailButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'wsCostItemLabel
        '
        Me.wsCostItemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wsCostItemLabel.Location = New System.Drawing.Point(54, 61)
        Me.wsCostItemLabel.Name = "wsCostItemLabel"
        Me.wsCostItemLabel.Size = New System.Drawing.Size(252, 23)
        Me.wsCostItemLabel.TabIndex = 0
        Me.wsCostItemLabel.Text = "WholeSale Cost of Item:"
        '
        'wsCostItemValTextBox
        '
        Me.wsCostItemValTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wsCostItemValTextBox.Location = New System.Drawing.Point(312, 58)
        Me.wsCostItemValTextBox.Name = "wsCostItemValTextBox"
        Me.wsCostItemValTextBox.Size = New System.Drawing.Size(158, 31)
        Me.wsCostItemValTextBox.TabIndex = 0
        Me.wsCostItemValTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'markupLabel
        '
        Me.markupLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.markupLabel.Location = New System.Drawing.Point(54, 113)
        Me.markupLabel.Name = "markupLabel"
        Me.markupLabel.Size = New System.Drawing.Size(138, 23)
        Me.markupLabel.TabIndex = 0
        Me.markupLabel.Text = "Markup %"
        '
        'markupValTextBox
        '
        Me.markupValTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.markupValTextBox.Location = New System.Drawing.Point(312, 110)
        Me.markupValTextBox.Name = "markupValTextBox"
        Me.markupValTextBox.Size = New System.Drawing.Size(158, 31)
        Me.markupValTextBox.TabIndex = 1
        Me.markupValTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'retailPriceLabel
        '
        Me.retailPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retailPriceLabel.Location = New System.Drawing.Point(54, 167)
        Me.retailPriceLabel.Name = "retailPriceLabel"
        Me.retailPriceLabel.Size = New System.Drawing.Size(154, 23)
        Me.retailPriceLabel.TabIndex = 0
        Me.retailPriceLabel.Text = "Retail Price: "
        '
        'retaiPriceValLabel
        '
        Me.retaiPriceValLabel.BackColor = System.Drawing.Color.White
        Me.retaiPriceValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.retaiPriceValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retaiPriceValLabel.Location = New System.Drawing.Point(312, 158)
        Me.retaiPriceValLabel.Name = "retaiPriceValLabel"
        Me.retaiPriceValLabel.Size = New System.Drawing.Size(158, 32)
        Me.retaiPriceValLabel.TabIndex = 2
        Me.retaiPriceValLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'getRetailButton
        '
        Me.getRetailButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.getRetailButton.Location = New System.Drawing.Point(89, 293)
        Me.getRetailButton.Name = "getRetailButton"
        Me.getRetailButton.Size = New System.Drawing.Size(143, 79)
        Me.getRetailButton.TabIndex = 3
        Me.getRetailButton.Text = "&Get Retail"
        Me.getRetailButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(269, 293)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(143, 79)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(430, 293)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(143, 79)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AcceptButton = Me.getRetailButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.getRetailButton)
        Me.Controls.Add(Me.retaiPriceValLabel)
        Me.Controls.Add(Me.markupValTextBox)
        Me.Controls.Add(Me.wsCostItemValTextBox)
        Me.Controls.Add(Me.retailPriceLabel)
        Me.Controls.Add(Me.markupLabel)
        Me.Controls.Add(Me.wsCostItemLabel)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retail Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents wsCostItemLabel As Label
    Friend WithEvents wsCostItemValTextBox As TextBox
    Friend WithEvents markupLabel As Label
    Friend WithEvents markupValTextBox As TextBox
    Friend WithEvents retailPriceLabel As Label
    Friend WithEvents retaiPriceValLabel As Label
    Friend WithEvents getRetailButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents clearButton As Button
End Class
