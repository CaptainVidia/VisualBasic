'Program: Acme Stadium Seating
'Me: frmMain.vb
'Author: G.Tang
'Purpose: A program that the user enters the number of 3 different classes
'       of seats sold an d the program calculates the subtotal for each class.
'       If the user decides to be funny and enter an invalid data, the program
'       will give an error message.
'       and the total revenue.
'       Class A: seats are $15
'       Class B: seats are $12
'       Class C: seats are $9
'

Option Explicit On
Option Strict On


Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmSplash.ShowDialog()

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

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        txtBoxClassA.Clear()
        txtBoxClassB.Clear()
        txtBoxClassC.Clear()
        lblRevAVal.Text = String.Empty
        lblRevBVal.Text = String.Empty
        lblRevCVal.Text = String.Empty
        lblTotal.Text = String.Empty

        txtBoxClassA.Focus()


    End Sub

    Private Sub btnCalculate_Click_1(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim ClassATicketTotal As Decimal
        Dim ClassBTicketTotal As Decimal
        Dim ClassCTicketTotal As Decimal
        Dim TotalRevenue As Decimal

        Dim ClassACosts As Decimal = 15
        Dim ClassBCosts As Decimal = 12
        Dim ClassCCosts As Decimal = 9
        Try
            ClassATicketTotal = CDec(txtBoxClassA.Text) * ClassACosts
            ClassBTicketTotal = CDec(txtBoxClassB.Text) * ClassBCosts
            ClassCTicketTotal = CDec(txtBoxClassC.Text) * ClassCCosts
            TotalRevenue = (CDec(txtBoxClassA.Text) * ClassACosts) + (CDec(txtBoxClassB.Text) * ClassBCosts) + (CDec(txtBoxClassC.Text) * ClassCCosts)

            lblRevAVal.Text = ClassATicketTotal.ToString("c")
            lblRevBVal.Text = ClassBTicketTotal.ToString("c")
            lblRevCVal.Text = ClassCTicketTotal.ToString("c")
            lblTotal.Text = TotalRevenue.ToString("c")
        Catch
            MessageBox.Show("Error: Please enter whole numbers! You cannot buy a half ticket!")
        End Try


    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBoxClassA.Clear()
        txtBoxClassB.Clear()
        txtBoxClassC.Clear()
        lblRevAVal.Text = " "
        lblRevBVal.Text = " "
        lblRevCVal.Text = " "

    End Sub
End Class
