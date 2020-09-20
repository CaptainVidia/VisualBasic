<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.monthLabel = New System.Windows.Forms.Label()
        Me.rainFallStatisticsLabel = New System.Windows.Forms.Label()
        Me.monthListBox = New System.Windows.Forms.ListBox()
        Me.shoDataButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.nupdMonth = New System.Windows.Forms.NumericUpDown()
        Me.resultListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.avgListBox = New System.Windows.Forms.ListBox()
        CType(Me.nupdMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'monthLabel
        '
        Me.monthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthLabel.Location = New System.Drawing.Point(83, 51)
        Me.monthLabel.Name = "monthLabel"
        Me.monthLabel.Size = New System.Drawing.Size(124, 23)
        Me.monthLabel.TabIndex = 1
        Me.monthLabel.Text = "Month:"
        '
        'rainFallStatisticsLabel
        '
        Me.rainFallStatisticsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rainFallStatisticsLabel.Location = New System.Drawing.Point(471, 51)
        Me.rainFallStatisticsLabel.Name = "rainFallStatisticsLabel"
        Me.rainFallStatisticsLabel.Size = New System.Drawing.Size(181, 23)
        Me.rainFallStatisticsLabel.TabIndex = 3
        Me.rainFallStatisticsLabel.Text = "Rainfall Statistics"
        '
        'monthListBox
        '
        Me.monthListBox.FormattingEnabled = True
        Me.monthListBox.Location = New System.Drawing.Point(302, 77)
        Me.monthListBox.Name = "monthListBox"
        Me.monthListBox.Size = New System.Drawing.Size(168, 212)
        Me.monthListBox.TabIndex = 4
        '
        'shoDataButton
        '
        Me.shoDataButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shoDataButton.Location = New System.Drawing.Point(302, 337)
        Me.shoDataButton.Name = "shoDataButton"
        Me.shoDataButton.Size = New System.Drawing.Size(125, 82)
        Me.shoDataButton.TabIndex = 5
        Me.shoDataButton.Text = "&Show Data"
        Me.shoDataButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(660, 337)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(125, 82)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(482, 337)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(125, 82)
        Me.clearButton.TabIndex = 7
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'nupdMonth
        '
        Me.nupdMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupdMonth.Location = New System.Drawing.Point(99, 96)
        Me.nupdMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nupdMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupdMonth.Name = "nupdMonth"
        Me.nupdMonth.Size = New System.Drawing.Size(138, 31)
        Me.nupdMonth.TabIndex = 8
        Me.nupdMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nupdMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'resultListBox
        '
        Me.resultListBox.FormattingEnabled = True
        Me.resultListBox.Location = New System.Drawing.Point(476, 77)
        Me.resultListBox.Name = "resultListBox"
        Me.resultListBox.Size = New System.Drawing.Size(168, 212)
        Me.resultListBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Month"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(650, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 28)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Average"
        '
        'avgListBox
        '
        Me.avgListBox.FormattingEnabled = True
        Me.avgListBox.Location = New System.Drawing.Point(650, 77)
        Me.avgListBox.Name = "avgListBox"
        Me.avgListBox.Size = New System.Drawing.Size(123, 212)
        Me.avgListBox.TabIndex = 13
        '
        'mainForm
        '
        Me.AcceptButton = Me.shoDataButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.avgListBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.resultListBox)
        Me.Controls.Add(Me.nupdMonth)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.shoDataButton)
        Me.Controls.Add(Me.monthListBox)
        Me.Controls.Add(Me.rainFallStatisticsLabel)
        Me.Controls.Add(Me.monthLabel)
        Me.Name = "mainForm"
        Me.Text = "Rainfall Statistics"
        CType(Me.nupdMonth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents monthLabel As Label
    Friend WithEvents rainFallStatisticsLabel As Label
    Friend WithEvents monthListBox As ListBox
    Friend WithEvents shoDataButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents nupdMonth As NumericUpDown
    Friend WithEvents resultListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents avgListBox As ListBox
End Class
