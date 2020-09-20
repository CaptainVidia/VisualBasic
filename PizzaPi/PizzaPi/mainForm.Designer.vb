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
        Me.diameterLabel = New System.Windows.Forms.Label()
        Me.numberOfSlicesLabel = New System.Windows.Forms.Label()
        Me.diameterOfPizzaTextbox = New System.Windows.Forms.TextBox()
        Me.totalNumberOfSlicesLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.inchesLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'diameterLabel
        '
        Me.diameterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diameterLabel.Location = New System.Drawing.Point(82, 70)
        Me.diameterLabel.Name = "diameterLabel"
        Me.diameterLabel.Size = New System.Drawing.Size(199, 35)
        Me.diameterLabel.TabIndex = 0
        Me.diameterLabel.Text = "Diameter of Pizza"
        '
        'numberOfSlicesLabel
        '
        Me.numberOfSlicesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberOfSlicesLabel.Location = New System.Drawing.Point(480, 70)
        Me.numberOfSlicesLabel.Name = "numberOfSlicesLabel"
        Me.numberOfSlicesLabel.Size = New System.Drawing.Size(199, 35)
        Me.numberOfSlicesLabel.TabIndex = 1
        Me.numberOfSlicesLabel.Text = "Number of Slices"
        '
        'diameterOfPizzaTextbox
        '
        Me.diameterOfPizzaTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diameterOfPizzaTextbox.Location = New System.Drawing.Point(87, 120)
        Me.diameterOfPizzaTextbox.Name = "diameterOfPizzaTextbox"
        Me.diameterOfPizzaTextbox.Size = New System.Drawing.Size(170, 31)
        Me.diameterOfPizzaTextbox.TabIndex = 1
        Me.diameterOfPizzaTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totalNumberOfSlicesLabel
        '
        Me.totalNumberOfSlicesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalNumberOfSlicesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalNumberOfSlicesLabel.Location = New System.Drawing.Point(480, 116)
        Me.totalNumberOfSlicesLabel.Name = "totalNumberOfSlicesLabel"
        Me.totalNumberOfSlicesLabel.Size = New System.Drawing.Size(199, 35)
        Me.totalNumberOfSlicesLabel.TabIndex = 3
        Me.totalNumberOfSlicesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(87, 277)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(124, 55)
        Me.calculateButton.TabIndex = 2
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(555, 277)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(124, 55)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(320, 277)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(124, 55)
        Me.clearButton.TabIndex = 3
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'inchesLabel
        '
        Me.inchesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inchesLabel.Location = New System.Drawing.Point(263, 120)
        Me.inchesLabel.Name = "inchesLabel"
        Me.inchesLabel.Size = New System.Drawing.Size(81, 31)
        Me.inchesLabel.TabIndex = 5
        Me.inchesLabel.Text = "inches"
        Me.inchesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.inchesLabel)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.totalNumberOfSlicesLabel)
        Me.Controls.Add(Me.diameterOfPizzaTextbox)
        Me.Controls.Add(Me.numberOfSlicesLabel)
        Me.Controls.Add(Me.diameterLabel)
        Me.Name = "mainForm"
        Me.Text = "Pizza Pi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents diameterLabel As Label
    Friend WithEvents numberOfSlicesLabel As Label
    Friend WithEvents diameterOfPizzaTextbox As TextBox
    Friend WithEvents totalNumberOfSlicesLabel As Label
    Friend WithEvents calculateButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents inchesLabel As Label
End Class
