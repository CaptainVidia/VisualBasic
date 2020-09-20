'Program: Payroll Processor
'Me: mainForm.vb
'Date: 3/2/2020
'Author: G.Tang
'Purpose: A program to calculate the net pay 
'           of an employee based on user input of their 
'           hours worked And rate Of pay 
Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Const STD_HOURS_SINGLE As Single = 40.0
        Const OT_FACTOR_DECIMAL As Decimal = 1.5D
        Const FICA_TAX_DECIMAL As Decimal = 0.0765D
        Const FED_TAX_DECIMAL As Decimal = 0.18D
        Const STATE_TAX_DECIMAL As Decimal = 0.02D

        Dim hoursSingle As Single
        Dim payRateDecimal As Decimal
        Dim regHoursSingle As Decimal
        Dim otHoursSingle As Single
        Dim regPayDecimal As Decimal
        Dim otPayDecimal As Decimal
        Dim grossPayDecimal As Decimal
        Dim ficaTaxDecimal As Decimal
        Dim fedTaxDecimal As Decimal
        Dim stateTaxDecimal As Decimal
        Dim totalDeductDecimal As Decimal
        Dim netPayDecimal As Decimal

        Try
            hoursSingle = CSng(hoursTextBox.Text)
            payRateDecimal = CDec(rateTextBox.Text)


        Catch ex As Exception
            MessageBox.Show("Input Error!" + vbNewLine + "Re-input your hours and rate", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            hoursTextBox.Clear()
            rateTextBox.Clear()
            hoursTextBox.Focus()
        End Try

        If (hoursSingle <= STD_HOURS_SINGLE) Then
            regHoursSingle = hoursSingle
            otHoursSingle = 0
        Else
            regHoursSingle = STD_HOURS_SINGLE
            otHoursSingle = hoursSingle - STD_HOURS_SINGLE
        End If

        regPayDecimal = CDec(regHoursSingle * payRateDecimal)
        otPayDecimal = CDec(otHoursSingle * payRateDecimal * OT_FACTOR_DECIMAL)
        grossPayDecimal = regHoursSingle + otPayDecimal

        ficaTaxDecimal = grossPayDecimal * FICA_TAX_DECIMAL
        fedTaxDecimal = grossPayDecimal * FED_TAX_DECIMAL
        stateTaxDecimal = grossPayDecimal * STATE_TAX_DECIMAL
        totalDeductDecimal = ficaTaxDecimal + fedTaxDecimal + stateTaxDecimal

        netPayDecimal = grossPayDecimal - totalDeductDecimal

        regHoursValLabel.Text = regHoursSingle.ToString()
        otHoursValLabel.Text = otHoursSingle.ToString()
        regPayValLabel.Text = regPayDecimal.ToString("C")
        otPayValLabel.Text = otPayDecimal.ToString("C")
        grossPayValLabel.Text = grossPayDecimal.ToString("C")
        ficaTaxValLabel.Text = ficaTaxDecimal.ToString("C")
        fedTaxValLabel.Text = fedTaxDecimal.ToString("C")
        stateTaxValLabel.Text = stateTaxDecimal.ToString("C")
        totalDeductValLabel.Text = totalDeductDecimal.ToString("C")
        netPayValLabel.Text = netPayDecimal.ToString("C")

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        regHoursValLabel.Text = String.Empty
        otHoursValLabel.Text = String.Empty
        regPayValLabel.Text = String.Empty
        otPayValLabel.Text = String.Empty
        grossPayValLabel.Text = String.Empty
        ficaTaxValLabel.Text = String.Empty
        fedTaxValLabel.Text = String.Empty
        stateTaxValLabel.Text = String.Empty
        totalDeductValLabel.Text = String.Empty
        netPayValLabel.Text = String.Empty
        hoursTextBox.Text = "0"
        rateTextBox.Text = "0"

        hoursTextBox.Focus()
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
