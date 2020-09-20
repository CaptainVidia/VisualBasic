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
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.numberOfBooksPurchasedLabel = New System.Windows.Forms.Label()
        Me.booksPurchasedTextBox = New System.Windows.Forms.TextBox()
        Me.totalPointsEarnedLabel = New System.Windows.Forms.Label()
        Me.totalPointsEarnedResultLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(141, 329)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(127, 87)
        Me.calculateButton.TabIndex = 2
        Me.calculateButton.Text = "C&alculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(504, 329)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(127, 87)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(317, 329)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(127, 87)
        Me.clearButton.TabIndex = 3
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'numberOfBooksPurchasedLabel
        '
        Me.numberOfBooksPurchasedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberOfBooksPurchasedLabel.Location = New System.Drawing.Point(12, 82)
        Me.numberOfBooksPurchasedLabel.Name = "numberOfBooksPurchasedLabel"
        Me.numberOfBooksPurchasedLabel.Size = New System.Drawing.Size(460, 28)
        Me.numberOfBooksPurchasedLabel.TabIndex = 0
        Me.numberOfBooksPurchasedLabel.Text = "Enter number book purchased this month: "
        '
        'booksPurchasedTextBox
        '
        Me.booksPurchasedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.booksPurchasedTextBox.Location = New System.Drawing.Point(437, 79)
        Me.booksPurchasedTextBox.Name = "booksPurchasedTextBox"
        Me.booksPurchasedTextBox.Size = New System.Drawing.Size(246, 31)
        Me.booksPurchasedTextBox.TabIndex = 1
        Me.booksPurchasedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totalPointsEarnedLabel
        '
        Me.totalPointsEarnedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPointsEarnedLabel.Location = New System.Drawing.Point(207, 147)
        Me.totalPointsEarnedLabel.Name = "totalPointsEarnedLabel"
        Me.totalPointsEarnedLabel.Size = New System.Drawing.Size(210, 28)
        Me.totalPointsEarnedLabel.TabIndex = 0
        Me.totalPointsEarnedLabel.Text = "Total Points Earned: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'totalPointsEarnedResultLabel
        '
        Me.totalPointsEarnedResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalPointsEarnedResultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPointsEarnedResultLabel.Location = New System.Drawing.Point(437, 147)
        Me.totalPointsEarnedResultLabel.Name = "totalPointsEarnedResultLabel"
        Me.totalPointsEarnedResultLabel.Size = New System.Drawing.Size(246, 28)
        Me.totalPointsEarnedResultLabel.TabIndex = 0
        Me.totalPointsEarnedResultLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'mainForm
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.totalPointsEarnedResultLabel)
        Me.Controls.Add(Me.totalPointsEarnedLabel)
        Me.Controls.Add(Me.booksPurchasedTextBox)
        Me.Controls.Add(Me.numberOfBooksPurchasedLabel)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Name = "mainForm"
        Me.Text = "Book Club Points"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calculateButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents numberOfBooksPurchasedLabel As Label
    Friend WithEvents booksPurchasedTextBox As TextBox
    Friend WithEvents totalPointsEarnedLabel As Label
    Friend WithEvents totalPointsEarnedResultLabel As Label
End Class
