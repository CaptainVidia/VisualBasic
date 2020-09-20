Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        adCostPerWeekTextBox.Clear()
        adClick1TextBox.Clear()
        adClick2TextBox.Clear()
        adClick3TextBox.Clear()
        adClick4TextBox.Clear()
        adClick1Label.Text = " "
        adClick2Label.Text = " "
        adClick3Label.Text = " "
        adClick4Label.Text = " "


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

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Try

            Dim total1 As Decimal
            Dim total2 As Decimal
            Dim total3 As Decimal
            Dim total4 As Decimal


            total1 = CDec(adCostPerWeekTextBox.Text) / CDec(adClick1TextBox.Text)
            adClick1Label.Text = Math.Round(total1, 2, MidpointRounding.AwayFromZero).ToString()


            total2 = CDec(adCostPerWeekTextBox.Text) / CDec(adClick2TextBox.Text)
            adClick2Label.Text = Math.Round(total2, 2, MidpointRounding.AwayFromZero).ToString()

            total3 = CDec(adCostPerWeekTextBox.Text) / CDec(adClick3TextBox.Text)
            adClick3Label.Text = Math.Round(total3, 2, MidpointRounding.AwayFromZero).ToString()

            total4 = CDec(adCostPerWeekTextBox.Text) / CDec(adClick4TextBox.Text)
            adClick4Label.Text = Math.Round(total4, 2, MidpointRounding.AwayFromZero).ToString()


        Catch ex As Exception

            If IsNumeric(adCostPerWeekTextBox.Text) = False Then
                MessageBox.Show("Please enter numeric values!")
            End If
            If IsNumeric(adClick1TextBox.Text) = False Then
                MessageBox.Show("Please enter numeric values!")
            End If
            If IsNumeric(adClick2TextBox.Text) = False Then
                MessageBox.Show("Please enter numeric values!")
            End If
            If IsNumeric(adClick3TextBox.Text) = False Then
                MessageBox.Show("Please enter numeric values!")
            End If
            If IsNumeric(adClick4TextBox.Text) = False Then
                MessageBox.Show("Please enter numeric values!")
            End If

        End Try
    End Sub



End Class
