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
        Me.programInstructionsLabel = New System.Windows.Forms.Label()
        Me.averageCostPerWeekLabel = New System.Windows.Forms.Label()
        Me.adCostPerWeekTextBox = New System.Windows.Forms.TextBox()
        Me.numberOfAdClicksLabel = New System.Windows.Forms.Label()
        Me.number1Label = New System.Windows.Forms.Label()
        Me.number4Label = New System.Windows.Forms.Label()
        Me.number3Label = New System.Windows.Forms.Label()
        Me.number2Label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.adClick1TextBox = New System.Windows.Forms.TextBox()
        Me.adClick2TextBox = New System.Windows.Forms.TextBox()
        Me.adClick3TextBox = New System.Windows.Forms.TextBox()
        Me.adClick4TextBox = New System.Windows.Forms.TextBox()
        Me.adClick4Label = New System.Windows.Forms.Label()
        Me.adClick3Label = New System.Windows.Forms.Label()
        Me.adClick2Label = New System.Windows.Forms.Label()
        Me.adClick1Label = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'programInstructionsLabel
        '
        Me.programInstructionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programInstructionsLabel.Location = New System.Drawing.Point(30, 31)
        Me.programInstructionsLabel.Name = "programInstructionsLabel"
        Me.programInstructionsLabel.Size = New System.Drawing.Size(479, 49)
        Me.programInstructionsLabel.TabIndex = 0
        Me.programInstructionsLabel.Text = "This application calculates the amount of advertising revenue paid to a Web site " &
    "that displays links to a selected vendor."
        '
        'averageCostPerWeekLabel
        '
        Me.averageCostPerWeekLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.averageCostPerWeekLabel.Location = New System.Drawing.Point(30, 103)
        Me.averageCostPerWeekLabel.Name = "averageCostPerWeekLabel"
        Me.averageCostPerWeekLabel.Size = New System.Drawing.Size(213, 49)
        Me.averageCostPerWeekLabel.TabIndex = 1
        Me.averageCostPerWeekLabel.Text = "Advertising cost per week:"
        '
        'adCostPerWeekTextBox
        '
        Me.adCostPerWeekTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adCostPerWeekTextBox.Location = New System.Drawing.Point(307, 103)
        Me.adCostPerWeekTextBox.Name = "adCostPerWeekTextBox"
        Me.adCostPerWeekTextBox.Size = New System.Drawing.Size(142, 26)
        Me.adCostPerWeekTextBox.TabIndex = 1
        Me.adCostPerWeekTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numberOfAdClicksLabel
        '
        Me.numberOfAdClicksLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberOfAdClicksLabel.Location = New System.Drawing.Point(30, 259)
        Me.numberOfAdClicksLabel.Name = "numberOfAdClicksLabel"
        Me.numberOfAdClicksLabel.Size = New System.Drawing.Size(168, 81)
        Me.numberOfAdClicksLabel.TabIndex = 3
        Me.numberOfAdClicksLabel.Text = "Number of Ad Clicks during the past 4 weekly periods" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'number1Label
        '
        Me.number1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.number1Label.Location = New System.Drawing.Point(227, 229)
        Me.number1Label.Name = "number1Label"
        Me.number1Label.Size = New System.Drawing.Size(37, 37)
        Me.number1Label.TabIndex = 4
        Me.number1Label.Text = "1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'number4Label
        '
        Me.number4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.number4Label.Location = New System.Drawing.Point(228, 340)
        Me.number4Label.Name = "number4Label"
        Me.number4Label.Size = New System.Drawing.Size(37, 23)
        Me.number4Label.TabIndex = 5
        Me.number4Label.Text = "4"
        '
        'number3Label
        '
        Me.number3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.number3Label.Location = New System.Drawing.Point(227, 303)
        Me.number3Label.Name = "number3Label"
        Me.number3Label.Size = New System.Drawing.Size(37, 23)
        Me.number3Label.TabIndex = 6
        Me.number3Label.Text = "3"
        '
        'number2Label
        '
        Me.number2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.number2Label.Location = New System.Drawing.Point(227, 266)
        Me.number2Label.Name = "number2Label"
        Me.number2Label.Size = New System.Drawing.Size(37, 23)
        Me.number2Label.TabIndex = 7
        Me.number2Label.Text = "2"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(461, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 37)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Revenue"
        '
        'adClick1TextBox
        '
        Me.adClick1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adClick1TextBox.Location = New System.Drawing.Point(289, 226)
        Me.adClick1TextBox.Name = "adClick1TextBox"
        Me.adClick1TextBox.Size = New System.Drawing.Size(142, 26)
        Me.adClick1TextBox.TabIndex = 2
        Me.adClick1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'adClick2TextBox
        '
        Me.adClick2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adClick2TextBox.Location = New System.Drawing.Point(289, 263)
        Me.adClick2TextBox.Name = "adClick2TextBox"
        Me.adClick2TextBox.Size = New System.Drawing.Size(142, 26)
        Me.adClick2TextBox.TabIndex = 3
        Me.adClick2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'adClick3TextBox
        '
        Me.adClick3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adClick3TextBox.Location = New System.Drawing.Point(289, 300)
        Me.adClick3TextBox.Name = "adClick3TextBox"
        Me.adClick3TextBox.Size = New System.Drawing.Size(142, 26)
        Me.adClick3TextBox.TabIndex = 4
        Me.adClick3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'adClick4TextBox
        '
        Me.adClick4TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adClick4TextBox.Location = New System.Drawing.Point(289, 340)
        Me.adClick4TextBox.Name = "adClick4TextBox"
        Me.adClick4TextBox.Size = New System.Drawing.Size(142, 26)
        Me.adClick4TextBox.TabIndex = 5
        Me.adClick4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'adClick4Label
        '
        Me.adClick4Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adClick4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adClick4Label.Location = New System.Drawing.Point(461, 340)
        Me.adClick4Label.Name = "adClick4Label"
        Me.adClick4Label.Size = New System.Drawing.Size(169, 26)
        Me.adClick4Label.TabIndex = 13
        Me.adClick4Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'adClick3Label
        '
        Me.adClick3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adClick3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adClick3Label.Location = New System.Drawing.Point(461, 300)
        Me.adClick3Label.Name = "adClick3Label"
        Me.adClick3Label.Size = New System.Drawing.Size(169, 26)
        Me.adClick3Label.TabIndex = 14
        Me.adClick3Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'adClick2Label
        '
        Me.adClick2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adClick2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adClick2Label.Location = New System.Drawing.Point(461, 266)
        Me.adClick2Label.Name = "adClick2Label"
        Me.adClick2Label.Size = New System.Drawing.Size(169, 23)
        Me.adClick2Label.TabIndex = 15
        Me.adClick2Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'adClick1Label
        '
        Me.adClick1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adClick1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adClick1Label.Location = New System.Drawing.Point(461, 226)
        Me.adClick1Label.Name = "adClick1Label"
        Me.adClick1Label.Size = New System.Drawing.Size(169, 26)
        Me.adClick1Label.TabIndex = 16
        Me.adClick1Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(71, 423)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(127, 66)
        Me.calculateButton.TabIndex = 6
        Me.calculateButton.Text = "C&alculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(538, 423)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(127, 66)
        Me.exitButton.TabIndex = 8
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(289, 423)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(127, 66)
        Me.clearButton.TabIndex = 7
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 514)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.adClick1Label)
        Me.Controls.Add(Me.adClick2Label)
        Me.Controls.Add(Me.adClick3Label)
        Me.Controls.Add(Me.adClick4Label)
        Me.Controls.Add(Me.adClick4TextBox)
        Me.Controls.Add(Me.adClick3TextBox)
        Me.Controls.Add(Me.adClick2TextBox)
        Me.Controls.Add(Me.adClick1TextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.number2Label)
        Me.Controls.Add(Me.number3Label)
        Me.Controls.Add(Me.number4Label)
        Me.Controls.Add(Me.number1Label)
        Me.Controls.Add(Me.numberOfAdClicksLabel)
        Me.Controls.Add(Me.adCostPerWeekTextBox)
        Me.Controls.Add(Me.averageCostPerWeekLabel)
        Me.Controls.Add(Me.programInstructionsLabel)
        Me.Name = "mainForm"
        Me.Text = "Pay Per Click Advertising Revenue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents programInstructionsLabel As Label
    Friend WithEvents averageCostPerWeekLabel As Label
    Friend WithEvents adCostPerWeekTextBox As TextBox
    Friend WithEvents numberOfAdClicksLabel As Label
    Friend WithEvents number1Label As Label
    Friend WithEvents number4Label As Label
    Friend WithEvents number3Label As Label
    Friend WithEvents number2Label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents adClick1TextBox As TextBox
    Friend WithEvents adClick2TextBox As TextBox
    Friend WithEvents adClick3TextBox As TextBox
    Friend WithEvents adClick4TextBox As TextBox
    Friend WithEvents adClick4Label As Label
    Friend WithEvents adClick3Label As Label
    Friend WithEvents adClick2Label As Label
    Friend WithEvents adClick1Label As Label
    Friend WithEvents calculateButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents clearButton As Button
End Class
