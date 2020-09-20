'Program: Hospital Charges
'Me: mainForm.vb
'Date: 4-Apr-2020
'Author: G.Tang
' Purpose: Allows the user to enter length of stay, medication, surgical charges, lab fees
'          and physical rehab fees and calculates the total cost. 
Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click

        lengthStayValTextBox.Text = String.Empty
        medicationValTextBox.Text = String.Empty
        surgicalChargeValTextBox.Text = String.Empty
        labFeeTextBox.Text = String.Empty
        physicalRehabValTextBox.Text = String.Empty
        totalValLabel.Text = String.Empty
        lengthStayValTextBox.Focus()

    End Sub

    Private Sub calcuateButton_Click(sender As Object, e As EventArgs) Handles calcuateButton.Click
        Dim StayCharge As Decimal
        Dim MiscCharge As Decimal
        Dim TotalCost As Decimal

        Try
            StayCharge = CalculateStayCharges(lengthStayValTextBox.Text)
            MiscCharge = CalculateMiscCharges(medicationValTextBox.Text, surgicalChargeValTextBox.Text, labFeeTextBox.Text, physicalRehabValTextBox.Text)
            TotalCost = CalculateTotalCharges(StayCharge, MiscCharge)

        Catch ex As Exception
            MessageBox.Show("Please enter numeric values only!", "Input Error!")
        End Try




        totalValLabel.Text = "Total: " + TotalCost.ToString("C")
        clearButton.Focus()
    End Sub
    Function CalculateStayCharges(ByVal lengthOfStay As String) As Decimal
        Dim StayCharges As Decimal
        Dim NumDays As Decimal

        Try
            NumDays = lengthOfStay

        Catch ex As Exception
            MessageBox.Show("All charges must be Zero or more", "Input Error!")

        End Try

        If NumDays < 0 Then
            MessageBox.Show("Length of Stay cannot be less than zero", "User Input Error")

            Return 0
        End If

        StayCharges = NumDays * 350

        Return StayCharges
        End
    End Function
    Function CalculateMiscCharges(ByVal Meds As Decimal, ByVal Surgical As Decimal, ByVal LabFees As Decimal, ByVal Rehab As Decimal) As Decimal
        Dim MiscCharges As Decimal

        Try
            Meds = CDec(medicationValTextBox.Text)

            Surgical = CDec(surgicalChargeValTextBox.Text)

            LabFees = CDec(labFeeTextBox.Text)

            Rehab = CDec(physicalRehabValTextBox.Text)

        Catch ex As Exception
            MessageBox.Show("All charges must be zero or more", "User Error!")

        End Try

        If Meds < 0 Or Surgical < 0 Or LabFees < 0 Or Rehab < 0 Then
            MessageBox.Show("All fess must be zero or greater!", "Input Error!")

        End If
        MiscCharges = Meds + Surgical + LabFees + Rehab
        Return MiscCharges
    End Function

    Function CalculateTotalCharges(ByVal StayCharges As Decimal, ByVal MiscCharges As Decimal) As Decimal
        Dim Total As Decimal

        Total = StayCharges + MiscCharges
        Return Total

    End Function
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
