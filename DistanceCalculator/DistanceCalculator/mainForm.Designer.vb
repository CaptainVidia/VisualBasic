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
        Me.vehicleSpeedLabel = New System.Windows.Forms.Label()
        Me.hoursTraveledLabel = New System.Windows.Forms.Label()
        Me.hoursTraveledValTextBox = New System.Windows.Forms.TextBox()
        Me.vehicleSpeedValTextBox = New System.Windows.Forms.TextBox()
        Me.resultListBox = New System.Windows.Forms.ListBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'vehicleSpeedLabel
        '
        Me.vehicleSpeedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehicleSpeedLabel.Location = New System.Drawing.Point(12, 86)
        Me.vehicleSpeedLabel.Name = "vehicleSpeedLabel"
        Me.vehicleSpeedLabel.Size = New System.Drawing.Size(265, 36)
        Me.vehicleSpeedLabel.TabIndex = 1
        Me.vehicleSpeedLabel.Text = "Enter Vehicle Speed:"
        '
        'hoursTraveledLabel
        '
        Me.hoursTraveledLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoursTraveledLabel.Location = New System.Drawing.Point(12, 135)
        Me.hoursTraveledLabel.Name = "hoursTraveledLabel"
        Me.hoursTraveledLabel.Size = New System.Drawing.Size(229, 36)
        Me.hoursTraveledLabel.TabIndex = 2
        Me.hoursTraveledLabel.Text = "Enter Hours Traveled:"
        '
        'hoursTraveledValTextBox
        '
        Me.hoursTraveledValTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoursTraveledValTextBox.Location = New System.Drawing.Point(298, 140)
        Me.hoursTraveledValTextBox.Name = "hoursTraveledValTextBox"
        Me.hoursTraveledValTextBox.Size = New System.Drawing.Size(124, 31)
        Me.hoursTraveledValTextBox.TabIndex = 1
        Me.hoursTraveledValTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'vehicleSpeedValTextBox
        '
        Me.vehicleSpeedValTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehicleSpeedValTextBox.Location = New System.Drawing.Point(298, 83)
        Me.vehicleSpeedValTextBox.Name = "vehicleSpeedValTextBox"
        Me.vehicleSpeedValTextBox.Size = New System.Drawing.Size(124, 31)
        Me.vehicleSpeedValTextBox.TabIndex = 0
        Me.vehicleSpeedValTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resultListBox
        '
        Me.resultListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultListBox.FormattingEnabled = True
        Me.resultListBox.ItemHeight = 16
        Me.resultListBox.Location = New System.Drawing.Point(461, 29)
        Me.resultListBox.Name = "resultListBox"
        Me.resultListBox.Size = New System.Drawing.Size(327, 388)
        Me.resultListBox.TabIndex = 5
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(12, 242)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(124, 79)
        Me.calculateButton.TabIndex = 2
        Me.calculateButton.Text = "C&alculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(298, 242)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(124, 79)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(153, 242)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(124, 79)
        Me.clearButton.TabIndex = 3
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.resultListBox)
        Me.Controls.Add(Me.vehicleSpeedValTextBox)
        Me.Controls.Add(Me.hoursTraveledValTextBox)
        Me.Controls.Add(Me.hoursTraveledLabel)
        Me.Controls.Add(Me.vehicleSpeedLabel)
        Me.Name = "mainForm"
        Me.Text = "Distance Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents vehicleSpeedLabel As Label
    Friend WithEvents hoursTraveledLabel As Label
    Friend WithEvents hoursTraveledValTextBox As TextBox
    Friend WithEvents vehicleSpeedValTextBox As TextBox
    Friend WithEvents resultListBox As ListBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents clearButton As Button
End Class
