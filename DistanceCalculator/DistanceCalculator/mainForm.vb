'Program: Distance Calculator
'Me: splashForm.vb
'Date: 9-Mar-2020
'Author: G.Tang
' Purpose: Allows the user to enter valid input for Hours Traveled and 
'           Vehicle Speed. Then the program follows the formula 
'           Distance = Time * Speed. The results are displayed to the user.

Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim vehicleSpeed As Decimal = CDec(vehicleSpeedValTextBox.Text)
        Dim totalDistnace As Decimal
        Dim shoDays As Decimal = 0S
        Try

            shoDays = CSng(hoursTraveledValTextBox.Text)
            For shoCount = 1 To shoDays
                If shoCount = 1 Then
                    totalDistnace = vehicleSpeed
                Else
                    totalDistnace = vehicleSpeed * shoCount
                End If
                resultListBox.Items.Add("Hours: " & vbNewLine & shoCount & vbTab & "Distance Traveled: " & vbNewLine & totalDistnace.ToString())

            Next
        Catch
            MessageBox.Show("Please enter valid values!", "User input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            vehicleSpeedValTextBox.Clear()
            hoursTraveledValTextBox.Clear()
            vehicleSpeedValTextBox.Focus()
        End Try

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
        resultListBox.Items.Clear()
        vehicleSpeedValTextBox.Clear()
        hoursTraveledValTextBox.Clear()
        vehicleSpeedValTextBox.Focus()
    End Sub
End Class
