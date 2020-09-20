'Program: Pennies For A Day
'Me: mainForm.vb
'Date: 9-Mar-2020
'Author: G.Tang
' Purpose: A program calculates pennies, nickel, dime, and quarter for a day as a payroll.
'         Then the results are displayed to the user. 
Public Class frmMain
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSplash.ShowDialog()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const decPenny As Decimal = 0.01D
        Const decNickel As Decimal = 0.05D
        Const decDime As Decimal = 0.1D
        Const decQuarter As Decimal = 0.25D

        Dim decGross As Decimal = 0D
        Dim shoDays As Decimal = 0S
        Dim decDayPay As Decimal = 0D

        If chkClear.Checked Then
            lstPay.Items.Clear()
        End If

        If (radbtnPenny.Checked) Then
            decDayPay = decPenny
        ElseIf (radbtnNickel.checked) Then
            decDayPay = decNickel
        ElseIf (radbtnDime.Checked) Then
            decDayPay = decDime
        ElseIf (radbtnQuarter.checked) Then
            decDayPay = decQuarter
        Else
            MessageBox.Show("choose an amount of pay!", "User input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        shoDays = CShort(nupdDays.Value)
        lstPay.Items.Add(vbTab & "Homer Simpson's Coin Payroll")

        For shoCount = 1 To shoDays
            If shoCount = 1 Then
                decGross = decDayPay
            Else
                decGross = decGross * 2
            End If
            lstPay.Items.Add("Day: " & shoCount & vbTab & "Amount: " & decGross.ToString("C"))

        Next
        btnClear.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        radbtnPenny.Checked = True
        nupdDays.Value = 1
        lstPay.Items.Clear()
        radbtnPenny.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub frmMain_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Do you wish to quit?",
                           "Quit?", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) =
                           Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
