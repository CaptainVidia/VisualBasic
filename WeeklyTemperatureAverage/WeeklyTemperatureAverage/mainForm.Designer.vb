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
        Me.week1Label = New System.Windows.Forms.Label()
        Me.week2Label = New System.Windows.Forms.Label()
        Me.week3Label = New System.Windows.Forms.Label()
        Me.week4Label = New System.Windows.Forms.Label()
        Me.week5Label = New System.Windows.Forms.Label()
        Me.averageLabel = New System.Windows.Forms.Label()
        Me.totalAverageLabel = New System.Windows.Forms.Label()
        Me.week1TextBox = New System.Windows.Forms.TextBox()
        Me.week5TextBox = New System.Windows.Forms.TextBox()
        Me.week4TextBox = New System.Windows.Forms.TextBox()
        Me.week3TextBox = New System.Windows.Forms.TextBox()
        Me.week2TextBox = New System.Windows.Forms.TextBox()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'week1Label
        '
        Me.week1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.week1Label.Location = New System.Drawing.Point(99, 34)
        Me.week1Label.Name = "week1Label"
        Me.week1Label.Size = New System.Drawing.Size(100, 37)
        Me.week1Label.TabIndex = 0
        Me.week1Label.Text = "Week #1"
        '
        'week2Label
        '
        Me.week2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.week2Label.Location = New System.Drawing.Point(99, 81)
        Me.week2Label.Name = "week2Label"
        Me.week2Label.Size = New System.Drawing.Size(100, 37)
        Me.week2Label.TabIndex = 1
        Me.week2Label.Text = "Week #2"
        '
        'week3Label
        '
        Me.week3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.week3Label.Location = New System.Drawing.Point(99, 136)
        Me.week3Label.Name = "week3Label"
        Me.week3Label.Size = New System.Drawing.Size(100, 37)
        Me.week3Label.TabIndex = 2
        Me.week3Label.Text = "Week #3"
        '
        'week4Label
        '
        Me.week4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.week4Label.Location = New System.Drawing.Point(99, 188)
        Me.week4Label.Name = "week4Label"
        Me.week4Label.Size = New System.Drawing.Size(100, 37)
        Me.week4Label.TabIndex = 3
        Me.week4Label.Text = "Week #4"
        '
        'week5Label
        '
        Me.week5Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.week5Label.Location = New System.Drawing.Point(99, 244)
        Me.week5Label.Name = "week5Label"
        Me.week5Label.Size = New System.Drawing.Size(100, 37)
        Me.week5Label.TabIndex = 4
        Me.week5Label.Text = "Week #5"
        '
        'averageLabel
        '
        Me.averageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.averageLabel.Location = New System.Drawing.Point(99, 294)
        Me.averageLabel.Name = "averageLabel"
        Me.averageLabel.Size = New System.Drawing.Size(100, 37)
        Me.averageLabel.TabIndex = 5
        Me.averageLabel.Text = "Average:"
        '
        'totalAverageLabel
        '
        Me.totalAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalAverageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalAverageLabel.Location = New System.Drawing.Point(350, 291)
        Me.totalAverageLabel.Name = "totalAverageLabel"
        Me.totalAverageLabel.Size = New System.Drawing.Size(100, 31)
        Me.totalAverageLabel.TabIndex = 6
        Me.totalAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'week1TextBox
        '
        Me.week1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.week1TextBox.Location = New System.Drawing.Point(350, 40)
        Me.week1TextBox.Name = "week1TextBox"
        Me.week1TextBox.Size = New System.Drawing.Size(100, 31)
        Me.week1TextBox.TabIndex = 1
        Me.week1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'week5TextBox
        '
        Me.week5TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.week5TextBox.Location = New System.Drawing.Point(350, 231)
        Me.week5TextBox.Name = "week5TextBox"
        Me.week5TextBox.Size = New System.Drawing.Size(100, 31)
        Me.week5TextBox.TabIndex = 5
        Me.week5TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'week4TextBox
        '
        Me.week4TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.week4TextBox.Location = New System.Drawing.Point(350, 188)
        Me.week4TextBox.Name = "week4TextBox"
        Me.week4TextBox.Size = New System.Drawing.Size(100, 31)
        Me.week4TextBox.TabIndex = 4
        Me.week4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'week3TextBox
        '
        Me.week3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.week3TextBox.Location = New System.Drawing.Point(350, 136)
        Me.week3TextBox.Name = "week3TextBox"
        Me.week3TextBox.Size = New System.Drawing.Size(100, 31)
        Me.week3TextBox.TabIndex = 3
        Me.week3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'week2TextBox
        '
        Me.week2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.week2TextBox.Location = New System.Drawing.Point(350, 87)
        Me.week2TextBox.Name = "week2TextBox"
        Me.week2TextBox.Size = New System.Drawing.Size(100, 31)
        Me.week2TextBox.TabIndex = 2
        Me.week2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(280, 377)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(112, 48)
        Me.clearButton.TabIndex = 8
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(455, 377)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(112, 48)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(104, 377)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(112, 48)
        Me.calculateButton.TabIndex = 7
        Me.calculateButton.Text = "C&alculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.week2TextBox)
        Me.Controls.Add(Me.week3TextBox)
        Me.Controls.Add(Me.week4TextBox)
        Me.Controls.Add(Me.week5TextBox)
        Me.Controls.Add(Me.week1TextBox)
        Me.Controls.Add(Me.totalAverageLabel)
        Me.Controls.Add(Me.averageLabel)
        Me.Controls.Add(Me.week5Label)
        Me.Controls.Add(Me.week4Label)
        Me.Controls.Add(Me.week3Label)
        Me.Controls.Add(Me.week2Label)
        Me.Controls.Add(Me.week1Label)
        Me.Name = "mainForm"
        Me.Text = "Weekly Temperature Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents week1Label As Label
    Friend WithEvents week2Label As Label
    Friend WithEvents week3Label As Label
    Friend WithEvents week4Label As Label
    Friend WithEvents week5Label As Label
    Friend WithEvents averageLabel As Label
    Friend WithEvents totalAverageLabel As Label
    Friend WithEvents week1TextBox As TextBox
    Friend WithEvents week5TextBox As TextBox
    Friend WithEvents week4TextBox As TextBox
    Friend WithEvents week3TextBox As TextBox
    Friend WithEvents week2TextBox As TextBox
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents calculateButton As Button
End Class
