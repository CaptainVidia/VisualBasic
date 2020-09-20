'Program: Book Club Points
'Me: mainForm.vb
'Date: 2-Mar-2020
'Author: G.Tang
' Purpose: Allows the user to enter the number of books purchased, then the program
'           runs and displays the number of points the user earned.
Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
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

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Const pointsLevel0 As Single = 0
        Const pointsLevel1 As Single = 5
        Const pointsLevel2 As Single = 15
        Const pointsLevel3 As Single = 30
        Const pointsLevel4 As Single = 60
        Dim numberOfBooks As Single = CSng(booksPurchasedTextBox.Text)
        Dim totalPoints As Single

        Try



            If numberOfBooks = 0 Then
                totalPoints = pointsLevel0



            ElseIf numberOfBooks = 1 Then
                totalPoints = pointsLevel1



            ElseIf numberOfBooks = 2 Then
                totalPoints = pointsLevel2



            ElseIf numberOfBooks = 3 Then
                totalPoints = pointsLevel3


            Else
                totalPoints = pointsLevel4



            End If



        Catch ex As Exception
            MessageBox.Show("Please enter a valid whole number", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            booksPurchasedTextBox.Clear()
            booksPurchasedTextBox.Focus()
        End Try
        totalPointsEarnedResultLabel.Text = totalPoints.ToString()
        clearButton.Focus()

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        booksPurchasedTextBox.Text = "0"
        booksPurchasedTextBox.Focus()
        totalPointsEarnedResultLabel.Text = String.Empty
    End Sub
End Class
