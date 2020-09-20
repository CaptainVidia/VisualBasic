'Program: Weekly Temperature Average
'Me: mainForm.vb
'Date: 17 Feb 2020
'Author: G.Tang
'Purpose: the user enters the temperature for each of the 5 week period. 
'       The program calculates the average of all the week and displays the 
'       result to user.
Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashScreen.ShowDialog()
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

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        week1TextBox.Clear()
        week2TextBox.Clear()
        week3TextBox.Clear()
        week4TextBox.Clear()
        week5TextBox.Clear()
        totalAverageLabel.Text = String.Empty

    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Try
            Dim week1 As Decimal = CDec(week1TextBox.Text)
            Dim week2 As Decimal = CDec(week2TextBox.Text)
            Dim week3 As Decimal = CDec(week3TextBox.Text)
            Dim week4 As Decimal = CDec(week4TextBox.Text)
            Dim week5 As Decimal = CDec(week5TextBox.Text)
            Dim average As Decimal = 5
            Dim totalAverage As Decimal

            totalAverage = (week1 + week2 + week3 + week4 + week5) / average

            totalAverageLabel.Text = totalAverage
        Catch ex As Exception
            MessageBox.Show("Input error occured!", "User Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            clearButton.PerformClick()

        End Try

    End Sub
End Class
