'Program: Integer Math Tutor
'Me: mainForm.vb
'Date: 16-Mar-2020
'Author: G.Tang
' Purpose: Allows the user to choose between which operator and give thme the problem. The 
'          program will tell the user if the answer to the problem is either correct or incorrect.
Public Class mainForm
    Const MAXRANGE As Integer = 100
    Const MINVAL As Integer = 20
    Dim rand As New Random
    Dim answer As Integer = 0
    Dim counter As Integer = 0




    Private Sub checkButton_Click(sender As Object, e As EventArgs) Handles checkButton.Click
        Dim userAnwser As Integer = 0





        '' Checking all 10 anwsers 
        '' show answers/completeed

    End Sub


    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()

    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click


        problemListBox.Items.Clear()

        answerTextBox.Clear()
        answer2TextBox.Clear()
        answer3TextBox.Clear()
        answer4TextBox.Clear()
        answer5TextBox.Clear()
        answer6TextBox.Clear()
        answer7TextBox.Clear()
        answer8TextBox.Clear()
        answer9TextBox.Clear()
        answer10TextBox.Clear()



        For countShort As Short = 1 To 10
            Dim shoCounter As Short = 1
            Dim op1 As Short
            Dim op2 As Short
            op2 = (rand.Next(6) + 1)
            op1 = (rand.Next(6) + 1)


            If addRadioButton.Checked Then


                problemListBox.Items.Add(op1.ToString & " + " & op2.ToString & " =")
                    answer = op1 + op2
                    shoCounter = shoCounter + 1



            ElseIf subtractRadioButton.Checked Then

                problemListBox.Items.Add(op1.ToString & " - " & op2.ToString & " =")
                    answer = op1 - op2
                    shoCounter = shoCounter + 1


            ElseIf multiplyRadioButton.Checked Then


                op1 = op1 / 2
                    op2 = op2 / 2
                    problemListBox.Items.Add(op1.ToString & " * " & op2.ToString & " =")
                    answer = op1 * op2
                    shoCounter = shoCounter + 1


            ElseIf divideRadioButton.Checked Then

                Do
                        op2 = rand.Next(50) + 1

                    Loop Until op1 Mod op2 = 0 And op2 < op1
                    problemListBox.Items.Add(op1.ToString & " / " & op2.ToString & " =")
                    answer = op1 / op2
                    shoCounter = shoCounter + 1

            End If

        Next countShort
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    Private Sub mainForm_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Do you wish to quit?",
                           "Quit?", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) =
                           Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
