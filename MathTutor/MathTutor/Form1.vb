'Program: Maath Tutor
'Date: 2/3/2021
'Author: G.Tang
'Purpose: A program that allows the user to look at the math problem.
'       Then when the user clicks show answer, it shows the answer.
Public Class Form1
    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        lblAnswer.Text = "4"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub Form1_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Do you wish to quit?",
                           "Quit?", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) =
                           Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnTryAgain_Click(sender As Object, e As EventArgs) Handles btnTryAgain.Click
        lblAnswer.Text = "?"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashScreen.ShowDialog()

    End Sub
End Class
