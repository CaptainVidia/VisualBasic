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
        Me.components = New System.ComponentModel.Container()
        Me.codeNumValLabel = New System.Windows.Forms.Label()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.creaturesCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.creatureLabel = New System.Windows.Forms.Label()
        Me.creatureCodeLabel = New System.Windows.Forms.Label()
        Me.creatureToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'codeNumValLabel
        '
        Me.codeNumValLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.codeNumValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.codeNumValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeNumValLabel.Location = New System.Drawing.Point(412, 68)
        Me.codeNumValLabel.Name = "codeNumValLabel"
        Me.codeNumValLabel.Size = New System.Drawing.Size(265, 53)
        Me.codeNumValLabel.TabIndex = 1
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(152, 348)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(155, 67)
        Me.clearButton.TabIndex = 2
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(485, 348)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(155, 67)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'creaturesCheckedListBox
        '
        Me.creaturesCheckedListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.creaturesCheckedListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creaturesCheckedListBox.FormattingEnabled = True
        Me.creaturesCheckedListBox.Location = New System.Drawing.Point(40, 68)
        Me.creaturesCheckedListBox.Name = "creaturesCheckedListBox"
        Me.creaturesCheckedListBox.Size = New System.Drawing.Size(318, 256)
        Me.creaturesCheckedListBox.TabIndex = 4
        '
        'creatureLabel
        '
        Me.creatureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creatureLabel.Location = New System.Drawing.Point(44, 25)
        Me.creatureLabel.Name = "creatureLabel"
        Me.creatureLabel.Size = New System.Drawing.Size(135, 40)
        Me.creatureLabel.TabIndex = 5
        Me.creatureLabel.Text = "Creatures"
        '
        'creatureCodeLabel
        '
        Me.creatureCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creatureCodeLabel.Location = New System.Drawing.Point(407, 25)
        Me.creatureCodeLabel.Name = "creatureCodeLabel"
        Me.creatureCodeLabel.Size = New System.Drawing.Size(203, 40)
        Me.creatureCodeLabel.TabIndex = 6
        Me.creatureCodeLabel.Text = "Creature Code"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.creatureCodeLabel)
        Me.Controls.Add(Me.creatureLabel)
        Me.Controls.Add(Me.creaturesCheckedListBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.codeNumValLabel)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Creature Coding"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents codeNumValLabel As Label
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents creaturesCheckedListBox As CheckedListBox
    Friend WithEvents creatureLabel As Label
    Friend WithEvents creatureCodeLabel As Label
    Friend WithEvents creatureToolTip As ToolTip
End Class
