'Program: Celsius to Fahrenheit
'Me: formMain.vb
'Author: G.Tang
'Date: 2/10/2020
'Purpose: A program that converts from celsius to fahrenheit. Then displays the result to the user.
'           If the user decides to be funny and type an invalid data, the program will give error message
'           telling them to enter only numbers.
'
Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashScreen.ShowDialog()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim ConvertCToF As Decimal
        Dim i As Decimal = 1.8
        Dim k As Decimal = 32

        Try
            ConvertCToF = (i * txtCelsiusToFahrenheit.Text) + k

            lblAnswerFahrenheit.Text = ConvertCToF.ToString

        Catch

            MessageBox.Show("Error! Please enter only numbers!")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAnswerFahrenheit.Text = " "
        txtCelsiusToFahrenheit.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
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
