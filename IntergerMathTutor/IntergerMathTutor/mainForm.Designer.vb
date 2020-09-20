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
        Me.choiceOpGroupBox = New System.Windows.Forms.GroupBox()
        Me.divideRadioButton = New System.Windows.Forms.RadioButton()
        Me.subtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.multiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.addRadioButton = New System.Windows.Forms.RadioButton()
        Me.instructionLabel = New System.Windows.Forms.Label()
        Me.answerTextBox = New System.Windows.Forms.TextBox()
        Me.checkButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.correctAnswersValLabel = New System.Windows.Forms.Label()
        Me.correctAnswersLabel = New System.Windows.Forms.Label()
        Me.answer5TextBox = New System.Windows.Forms.TextBox()
        Me.answer3TextBox = New System.Windows.Forms.TextBox()
        Me.answer7TextBox = New System.Windows.Forms.TextBox()
        Me.answer9TextBox = New System.Windows.Forms.TextBox()
        Me.answer2TextBox = New System.Windows.Forms.TextBox()
        Me.answer6TextBox = New System.Windows.Forms.TextBox()
        Me.answer4TextBox = New System.Windows.Forms.TextBox()
        Me.answer8TextBox = New System.Windows.Forms.TextBox()
        Me.answer10TextBox = New System.Windows.Forms.TextBox()
        Me.problemListBox = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.checkAnswerLabel = New System.Windows.Forms.Label()
        Me.checkAnswer2Label = New System.Windows.Forms.Label()
        Me.checkAnswer5Label = New System.Windows.Forms.Label()
        Me.checkAnswer6Label = New System.Windows.Forms.Label()
        Me.checkAnswer3Label = New System.Windows.Forms.Label()
        Me.checkAnswer4Label = New System.Windows.Forms.Label()
        Me.checkAnswer7Label = New System.Windows.Forms.Label()
        Me.checkAnswer8Label = New System.Windows.Forms.Label()
        Me.checkAnswer9Label = New System.Windows.Forms.Label()
        Me.checkAnswer10Label = New System.Windows.Forms.Label()
        Me.choiceOpGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'choiceOpGroupBox
        '
        Me.choiceOpGroupBox.Controls.Add(Me.divideRadioButton)
        Me.choiceOpGroupBox.Controls.Add(Me.subtractRadioButton)
        Me.choiceOpGroupBox.Controls.Add(Me.multiplyRadioButton)
        Me.choiceOpGroupBox.Controls.Add(Me.addRadioButton)
        Me.choiceOpGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.choiceOpGroupBox.Location = New System.Drawing.Point(21, 27)
        Me.choiceOpGroupBox.Name = "choiceOpGroupBox"
        Me.choiceOpGroupBox.Size = New System.Drawing.Size(767, 83)
        Me.choiceOpGroupBox.TabIndex = 0
        Me.choiceOpGroupBox.TabStop = False
        Me.choiceOpGroupBox.Text = "Choose An Integer Operation"
        '
        'divideRadioButton
        '
        Me.divideRadioButton.Location = New System.Drawing.Point(571, 30)
        Me.divideRadioButton.Name = "divideRadioButton"
        Me.divideRadioButton.Size = New System.Drawing.Size(118, 39)
        Me.divideRadioButton.TabIndex = 3
        Me.divideRadioButton.TabStop = True
        Me.divideRadioButton.Text = "&Division"
        Me.divideRadioButton.UseVisualStyleBackColor = True
        '
        'subtractRadioButton
        '
        Me.subtractRadioButton.Location = New System.Drawing.Point(183, 30)
        Me.subtractRadioButton.Name = "subtractRadioButton"
        Me.subtractRadioButton.Size = New System.Drawing.Size(145, 39)
        Me.subtractRadioButton.TabIndex = 1
        Me.subtractRadioButton.TabStop = True
        Me.subtractRadioButton.Text = "&Subtraction"
        Me.subtractRadioButton.UseVisualStyleBackColor = True
        '
        'multiplyRadioButton
        '
        Me.multiplyRadioButton.Location = New System.Drawing.Point(368, 30)
        Me.multiplyRadioButton.Name = "multiplyRadioButton"
        Me.multiplyRadioButton.Size = New System.Drawing.Size(164, 39)
        Me.multiplyRadioButton.TabIndex = 2
        Me.multiplyRadioButton.TabStop = True
        Me.multiplyRadioButton.Text = "&Multiplication"
        Me.multiplyRadioButton.UseVisualStyleBackColor = True
        '
        'addRadioButton
        '
        Me.addRadioButton.Location = New System.Drawing.Point(19, 30)
        Me.addRadioButton.Name = "addRadioButton"
        Me.addRadioButton.Size = New System.Drawing.Size(118, 39)
        Me.addRadioButton.TabIndex = 0
        Me.addRadioButton.TabStop = True
        Me.addRadioButton.Text = "&Addition"
        Me.addRadioButton.UseVisualStyleBackColor = True
        '
        'instructionLabel
        '
        Me.instructionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instructionLabel.Location = New System.Drawing.Point(17, 113)
        Me.instructionLabel.Name = "instructionLabel"
        Me.instructionLabel.Size = New System.Drawing.Size(597, 23)
        Me.instructionLabel.TabIndex = 1
        Me.instructionLabel.Text = "Please type in your anwser to the following math probelms. Integer answers only:"
        '
        'answerTextBox
        '
        Me.answerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answerTextBox.Location = New System.Drawing.Point(203, 136)
        Me.answerTextBox.Name = "answerTextBox"
        Me.answerTextBox.Size = New System.Drawing.Size(111, 26)
        Me.answerTextBox.TabIndex = 1
        Me.answerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'checkButton
        '
        Me.checkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkButton.Location = New System.Drawing.Point(782, 223)
        Me.checkButton.Name = "checkButton"
        Me.checkButton.Size = New System.Drawing.Size(161, 57)
        Me.checkButton.TabIndex = 2
        Me.checkButton.Text = "&Check Your Anwser"
        Me.checkButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextButton.Location = New System.Drawing.Point(782, 139)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(161, 57)
        Me.nextButton.TabIndex = 3
        Me.nextButton.Text = "&Next Problem"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(782, 302)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(161, 57)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'correctAnswersValLabel
        '
        Me.correctAnswersValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.correctAnswersValLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correctAnswersValLabel.Location = New System.Drawing.Point(182, 497)
        Me.correctAnswersValLabel.Name = "correctAnswersValLabel"
        Me.correctAnswersValLabel.Size = New System.Drawing.Size(128, 23)
        Me.correctAnswersValLabel.TabIndex = 5
        '
        'correctAnswersLabel
        '
        Me.correctAnswersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correctAnswersLabel.Location = New System.Drawing.Point(23, 498)
        Me.correctAnswersLabel.Name = "correctAnswersLabel"
        Me.correctAnswersLabel.Size = New System.Drawing.Size(135, 23)
        Me.correctAnswersLabel.TabIndex = 6
        Me.correctAnswersLabel.Text = "Correct Answers: "
        '
        'answer5TextBox
        '
        Me.answer5TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answer5TextBox.Location = New System.Drawing.Point(204, 268)
        Me.answer5TextBox.Name = "answer5TextBox"
        Me.answer5TextBox.Size = New System.Drawing.Size(111, 26)
        Me.answer5TextBox.TabIndex = 1
        Me.answer5TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'answer3TextBox
        '
        Me.answer3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answer3TextBox.Location = New System.Drawing.Point(203, 202)
        Me.answer3TextBox.Name = "answer3TextBox"
        Me.answer3TextBox.Size = New System.Drawing.Size(111, 26)
        Me.answer3TextBox.TabIndex = 1
        Me.answer3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'answer7TextBox
        '
        Me.answer7TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answer7TextBox.Location = New System.Drawing.Point(204, 334)
        Me.answer7TextBox.Name = "answer7TextBox"
        Me.answer7TextBox.Size = New System.Drawing.Size(111, 26)
        Me.answer7TextBox.TabIndex = 1
        Me.answer7TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'answer9TextBox
        '
        Me.answer9TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answer9TextBox.Location = New System.Drawing.Point(205, 400)
        Me.answer9TextBox.Name = "answer9TextBox"
        Me.answer9TextBox.Size = New System.Drawing.Size(111, 26)
        Me.answer9TextBox.TabIndex = 1
        Me.answer9TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'answer2TextBox
        '
        Me.answer2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answer2TextBox.Location = New System.Drawing.Point(204, 170)
        Me.answer2TextBox.Name = "answer2TextBox"
        Me.answer2TextBox.Size = New System.Drawing.Size(111, 26)
        Me.answer2TextBox.TabIndex = 1
        Me.answer2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'answer6TextBox
        '
        Me.answer6TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answer6TextBox.Location = New System.Drawing.Point(205, 302)
        Me.answer6TextBox.Name = "answer6TextBox"
        Me.answer6TextBox.Size = New System.Drawing.Size(111, 26)
        Me.answer6TextBox.TabIndex = 1
        Me.answer6TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'answer4TextBox
        '
        Me.answer4TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answer4TextBox.Location = New System.Drawing.Point(204, 236)
        Me.answer4TextBox.Name = "answer4TextBox"
        Me.answer4TextBox.Size = New System.Drawing.Size(111, 26)
        Me.answer4TextBox.TabIndex = 1
        Me.answer4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'answer8TextBox
        '
        Me.answer8TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answer8TextBox.Location = New System.Drawing.Point(205, 368)
        Me.answer8TextBox.Name = "answer8TextBox"
        Me.answer8TextBox.Size = New System.Drawing.Size(111, 26)
        Me.answer8TextBox.TabIndex = 1
        Me.answer8TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'answer10TextBox
        '
        Me.answer10TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answer10TextBox.Location = New System.Drawing.Point(206, 434)
        Me.answer10TextBox.Name = "answer10TextBox"
        Me.answer10TextBox.Size = New System.Drawing.Size(111, 26)
        Me.answer10TextBox.TabIndex = 1
        Me.answer10TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'problemListBox
        '
        Me.problemListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.problemListBox.FormattingEnabled = True
        Me.problemListBox.ItemHeight = 20
        Me.problemListBox.Location = New System.Drawing.Point(21, 139)
        Me.problemListBox.Name = "problemListBox"
        Me.problemListBox.Size = New System.Drawing.Size(176, 324)
        Me.problemListBox.TabIndex = 9
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'checkAnswerLabel
        '
        Me.checkAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.checkAnswerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkAnswerLabel.Location = New System.Drawing.Point(320, 136)
        Me.checkAnswerLabel.Name = "checkAnswerLabel"
        Me.checkAnswerLabel.Size = New System.Drawing.Size(417, 23)
        Me.checkAnswerLabel.TabIndex = 11
        '
        'checkAnswer2Label
        '
        Me.checkAnswer2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.checkAnswer2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkAnswer2Label.Location = New System.Drawing.Point(321, 172)
        Me.checkAnswer2Label.Name = "checkAnswer2Label"
        Me.checkAnswer2Label.Size = New System.Drawing.Size(416, 23)
        Me.checkAnswer2Label.TabIndex = 11
        '
        'checkAnswer5Label
        '
        Me.checkAnswer5Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.checkAnswer5Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkAnswer5Label.Location = New System.Drawing.Point(320, 271)
        Me.checkAnswer5Label.Name = "checkAnswer5Label"
        Me.checkAnswer5Label.Size = New System.Drawing.Size(416, 23)
        Me.checkAnswer5Label.TabIndex = 11
        '
        'checkAnswer6Label
        '
        Me.checkAnswer6Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.checkAnswer6Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkAnswer6Label.Location = New System.Drawing.Point(321, 307)
        Me.checkAnswer6Label.Name = "checkAnswer6Label"
        Me.checkAnswer6Label.Size = New System.Drawing.Size(416, 23)
        Me.checkAnswer6Label.TabIndex = 11
        '
        'checkAnswer3Label
        '
        Me.checkAnswer3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.checkAnswer3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkAnswer3Label.Location = New System.Drawing.Point(321, 204)
        Me.checkAnswer3Label.Name = "checkAnswer3Label"
        Me.checkAnswer3Label.Size = New System.Drawing.Size(416, 23)
        Me.checkAnswer3Label.TabIndex = 11
        '
        'checkAnswer4Label
        '
        Me.checkAnswer4Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.checkAnswer4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkAnswer4Label.Location = New System.Drawing.Point(322, 240)
        Me.checkAnswer4Label.Name = "checkAnswer4Label"
        Me.checkAnswer4Label.Size = New System.Drawing.Size(416, 23)
        Me.checkAnswer4Label.TabIndex = 11
        '
        'checkAnswer7Label
        '
        Me.checkAnswer7Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.checkAnswer7Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkAnswer7Label.Location = New System.Drawing.Point(321, 337)
        Me.checkAnswer7Label.Name = "checkAnswer7Label"
        Me.checkAnswer7Label.Size = New System.Drawing.Size(416, 23)
        Me.checkAnswer7Label.TabIndex = 11
        '
        'checkAnswer8Label
        '
        Me.checkAnswer8Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.checkAnswer8Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkAnswer8Label.Location = New System.Drawing.Point(322, 373)
        Me.checkAnswer8Label.Name = "checkAnswer8Label"
        Me.checkAnswer8Label.Size = New System.Drawing.Size(416, 23)
        Me.checkAnswer8Label.TabIndex = 11
        '
        'checkAnswer9Label
        '
        Me.checkAnswer9Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.checkAnswer9Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkAnswer9Label.Location = New System.Drawing.Point(320, 400)
        Me.checkAnswer9Label.Name = "checkAnswer9Label"
        Me.checkAnswer9Label.Size = New System.Drawing.Size(416, 23)
        Me.checkAnswer9Label.TabIndex = 11
        '
        'checkAnswer10Label
        '
        Me.checkAnswer10Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.checkAnswer10Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkAnswer10Label.Location = New System.Drawing.Point(321, 436)
        Me.checkAnswer10Label.Name = "checkAnswer10Label"
        Me.checkAnswer10Label.Size = New System.Drawing.Size(416, 23)
        Me.checkAnswer10Label.TabIndex = 11
        '
        'mainForm
        '
        Me.AcceptButton = Me.checkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(1145, 682)
        Me.Controls.Add(Me.checkAnswer10Label)
        Me.Controls.Add(Me.checkAnswer8Label)
        Me.Controls.Add(Me.checkAnswer4Label)
        Me.Controls.Add(Me.checkAnswer6Label)
        Me.Controls.Add(Me.checkAnswer2Label)
        Me.Controls.Add(Me.checkAnswer9Label)
        Me.Controls.Add(Me.checkAnswer7Label)
        Me.Controls.Add(Me.checkAnswer3Label)
        Me.Controls.Add(Me.checkAnswer5Label)
        Me.Controls.Add(Me.checkAnswerLabel)
        Me.Controls.Add(Me.problemListBox)
        Me.Controls.Add(Me.correctAnswersLabel)
        Me.Controls.Add(Me.correctAnswersValLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.checkButton)
        Me.Controls.Add(Me.answer10TextBox)
        Me.Controls.Add(Me.answer8TextBox)
        Me.Controls.Add(Me.answer4TextBox)
        Me.Controls.Add(Me.answer6TextBox)
        Me.Controls.Add(Me.answer2TextBox)
        Me.Controls.Add(Me.answer9TextBox)
        Me.Controls.Add(Me.answer7TextBox)
        Me.Controls.Add(Me.answer3TextBox)
        Me.Controls.Add(Me.answer5TextBox)
        Me.Controls.Add(Me.answerTextBox)
        Me.Controls.Add(Me.instructionLabel)
        Me.Controls.Add(Me.choiceOpGroupBox)
        Me.Name = "mainForm"
        Me.Text = "Integer Math Tutor"
        Me.choiceOpGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents choiceOpGroupBox As GroupBox
    Friend WithEvents divideRadioButton As RadioButton
    Friend WithEvents subtractRadioButton As RadioButton
    Friend WithEvents multiplyRadioButton As RadioButton
    Friend WithEvents addRadioButton As RadioButton
    Friend WithEvents instructionLabel As Label
    Friend WithEvents answerTextBox As TextBox
    Friend WithEvents checkButton As Button
    Friend WithEvents nextButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents correctAnswersValLabel As Label
    Friend WithEvents correctAnswersLabel As Label
    Friend WithEvents answer5TextBox As TextBox
    Friend WithEvents answer3TextBox As TextBox
    Friend WithEvents answer7TextBox As TextBox
    Friend WithEvents answer9TextBox As TextBox
    Friend WithEvents answer2TextBox As TextBox
    Friend WithEvents answer6TextBox As TextBox
    Friend WithEvents answer4TextBox As TextBox
    Friend WithEvents answer8TextBox As TextBox
    Friend WithEvents answer10TextBox As TextBox
    Friend WithEvents problemListBox As ListBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents checkAnswerLabel As Label
    Friend WithEvents checkAnswer2Label As Label
    Friend WithEvents checkAnswer5Label As Label
    Friend WithEvents checkAnswer6Label As Label
    Friend WithEvents checkAnswer3Label As Label
    Friend WithEvents checkAnswer4Label As Label
    Friend WithEvents checkAnswer7Label As Label
    Friend WithEvents checkAnswer8Label As Label
    Friend WithEvents checkAnswer9Label As Label
    Friend WithEvents checkAnswer10Label As Label
End Class
