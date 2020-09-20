'Program: Probability Test
'Me: mainForm.vb
'Date: 16-Mar-2020
'Author: G.Tang
' Purpose: a progrsm to roll 2 die , 100 times and note the total tries each
'           of 11 in most instances be the most likely result. If we increased 
'           the number of rolls , the probability of 7 should be prevalent.

Option Strict On
Option Explicit On
Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
    End Sub

    Private Sub beginTestButton_Click(sender As Object, e As EventArgs) Handles beginTestButton.Click
        Dim rand As New Random
        Dim die1Short As Short
        Dim die2Short As Short
        Dim sumShort As Short
        Dim twoShort, threeShort, tenShort, fourShort,
            fiveShort, sixShort, sevenShort, eightShort,
            nineShort, elevenShort, tweleveShort As Short

        For countShort As Short = 1 To 100
            die1Short = CShort(rand.Next(6) + 1)
            die2Short = CShort(rand.Next(6) + 1)
            sumShort = die1Short + die2Short
            rollsListBox.Items.Add("Roll#" & countShort.ToString & ":" & vbTab & die1Short.ToString &
                                   " + " & die2Short.ToString & " = " &
                                   sumShort.ToString)
            Select Case (sumShort)
                Case 2
                    twoShort += 1S
                Case 3
                    threeShort += 1S
                Case 4
                    fourShort += 1S
                Case 5
                    fiveShort += 1S
                Case 6
                    sixShort += 1S
                Case 7
                    sevenShort += 1S
                Case 8
                    eightShort += 1S
                Case 9
                    nineShort += 1S
                Case 10
                    tenShort += 1S
                Case 11
                    elevenShort += 1S
                Case Else
                    tweleveShort += 1S


            End Select
        Next countShort
        twoValLabel.Text = twoShort.ToString()
        threeValLabel.Text = threeShort.ToString()
        fourValLabel.Text = fourShort.ToString()
        fiveValLabel.Text = fiveShort.ToString()
        sixValLabel.Text = sixShort.ToString()
        sevenValLabel.Text = sevenShort.ToString()
        eightValLabel.Text = eightShort.ToString()
        nineValLabel.Text = nineShort.ToString()
        tenValLabel.Text = tenShort.ToString()
        elevenValLabel.Text = elevenShort.ToString()
        twelveValLabel.Text = tweleveShort.ToString

        clearButton.Focus()


    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        rollsListBox.Items.Clear()
        twoValLabel.Text = String.Empty
        threeValLabel.Text = String.Empty
        fourValLabel.Text = String.Empty
        fiveValLabel.Text = String.Empty
        sixValLabel.Text = String.Empty
        sevenValLabel.Text = String.Empty
        eightValLabel.Text = String.Empty
        nineValLabel.Text = String.Empty
        tenValLabel.Text = String.Empty
        elevenValLabel.Text = String.Empty
        twelveValLabel.Text = String.Empty

        beginTestButton.Focus()

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

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
