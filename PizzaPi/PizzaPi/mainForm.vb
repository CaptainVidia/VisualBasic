'Program: Insurance
'Me: mainForm.vb
'Date: 17 Feb 2020
'Author: G.Tang
'Purpose: The user enters a diameter in inches. Then the program calculates the area
'           of a circle and displays the number of slices of pizza.
Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashScreen.ShowDialog()
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

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        diameterOfPizzaTextbox.Clear()
        totalNumberOfSlicesLabel.Text = " "
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Try
            Dim radius As Decimal
            Dim area As Decimal
            Dim total As Integer

            radius = diameterOfPizzaTextbox.Text / 2
            area = 3.14159 * (radius ^ 2)
            total = area / 14.125

            totalNumberOfSlicesLabel.Text = total.ToString()

        Catch ex As Exception
            MessageBox.Show("Input error occured!", "User Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            clearButton.PerformClick()

        End Try


    End Sub
End Class
