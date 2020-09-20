'Program: Acme Stadium Seating
'Me: mainForm.vb
'Date: 2/10/2020
'Author: G.Tang
'Purpose: A program that calculates the total amount of tickets of child and adults. Then 
'          displays the result to the user in gross revenue total and net total. If user decides
'           to be funny and enter invalid data then the program will display an error message
'
Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashScreen.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decAdultTicket As Decimal
        Dim decChildTicket As Decimal
        Dim decTotalGrossRevenue As Decimal
        Dim decNetAdultTicket As Decimal
        Dim decNetChildTicket As Decimal
        Dim decTotalNetRevenue As Decimal
        Dim decPercent As Decimal = 0.2

        Try

            decAdultTicket = CDec(txtBoxPricePerTicketAdult.Text) * CDec(txtBoxTicketsSoldAdult.Text)
            decChildTicket = CDec(txtBoxPricePerTicketChild.Text) * CDec(txtBoxTicketsSoldChild.Text)
            decTotalGrossRevenue = decAdultTicket + decChildTicket
            decNetAdultTicket = decAdultTicket * decPercent
            decNetChildTicket = decChildTicket * decPercent
            decTotalNetRevenue = decNetAdultTicket + decNetChildTicket



            lblAdultTicketSalesPrint.Text = decAdultTicket.ToString("c")
            lblChildTicketSalesPrint.Text = decChildTicket.ToString("c")
            lblTotalGrossRevPrint.Text = decTotalGrossRevenue.ToString("c")
            lblAdultTicketSalesNetPrint.Text = decNetAdultTicket.ToString("c")
            lblChildTicketSalesNetPrint.Text = decNetChildTicket.ToString("c")
            lblTotalNetRevPrint.Text = decTotalNetRevenue.ToString("c")

        Catch
            MessageBox.Show("Error: Please enter either a valid amount or whole number for ticket! Remember you cannot buy a half ticket!")
        End Try



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBoxPricePerTicketAdult.Clear()
        txtBoxTicketsSoldAdult.Clear()
        txtBoxPricePerTicketChild.Clear()
        txtBoxTicketsSoldChild.Clear()
        lblAdultTicketSalesPrint.Text = " "
        lblChildTicketSalesPrint.Text = " "
        lblTotalGrossRevPrint.Text = " "
        lblAdultTicketSalesNetPrint.Text = " "
        lblChildTicketSalesNetPrint.Text = " "
        lblTotalNetRevPrint.Text = " "
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub mainForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Do you wish to quit?",
                           "Quit?", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) =
                           Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
