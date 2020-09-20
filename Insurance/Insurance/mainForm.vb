'Program: Insurance
'Me: mainForm.vb
'Date: 17 Feb 2020
'Author: G.Tang
'Purpose: A program that calculates the insurance on owner's homes or buildings.
'The user can enter the replacement cost of the building and then displays the 
'the minimum amount of insurance he or she should buy for their property.

Public Class mainForm
    Private Sub mainForm_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Do you wish to quit?",
                           "Quit?", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) =
                           Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashScreen.ShowDialog()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Try
            Dim percentDecimal As Decimal = CDec(percentTextBox.Text()) / 100D
            Dim costDecimal As Decimal = CDec(costTextBox.Text())

            Dim insuranceAmtDecimal As Decimal = percentDecimal * costDecimal

            insuranceValLabel.Text = insuranceAmtDecimal.ToString("C")

            clearButton.Focus()

        Catch ex As Exception
            MessageBox.Show("Input error occured!", "User Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            clearButton.PerformClick()

        End Try
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        percentTextBox.Text = "80"
        costTextBox.Text = "0"
        insuranceValLabel.Text = String.Empty
        percentTextBox.Focus()
    End Sub
End Class
