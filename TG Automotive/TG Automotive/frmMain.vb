'Program: TG Automotive
'Me: mainForm.vb
'Date: 4-Apr-2020
'Author: G.Tang
' Purpose: allows the user to choose between the options and enter the price
'           for parts and labor (dollars and minutes). Then the program will 
'           calculate all prices and the total will be displayed.
Public Class frmMain

    Private Const decOILPRICE As Decimal = 36D
    Private Const decLUBEPRICE As Decimal = 28D
    Private Const decRADPRICE As Decimal = 50D
    Private Const decTRANSPRICE As Decimal = 120D
    Private Const decINSPECTPRICE As Decimal = 15D
    Private Const decMUFFLERPRICE As Decimal = 200D
    Private Const decTIREPRICE As Decimal = 20D
    Private Const decLABORPRICE As Decimal = 60D
    Private Const decTAXRATE As Decimal = 0.1D
    Private m_decParts As Decimal = 0D
    Private m_decLabor As Decimal = 0D

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSplash.ShowDialog()
        lblOilCost.Text = decOILPRICE.ToString("C")
        lblLubeCost.Text = decLUBEPRICE.ToString("C")
        lblRadFlushCost.Text = decRADPRICE.ToString("C")
        lblTransFlushCost.Text = decTRANSPRICE.ToString("C")
        lblInspecCost.Text = decINSPECTPRICE.ToString("C")
        lblMufflerCost.Text = decMUFFLERPRICE.ToString("C")
        lblTireCost.Text = decTIREPRICE.ToString("C")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decTransSubtotal As Decimal = Calculate_Rad_Trans()
        Dim decOilSubtotal As Decimal = Calculate_Oil_Lube()
        Dim decMiscSubtotal As Decimal = Calculate_Misc()

        Calculate_Parts_Labor()
        Dim decSvcAndLabor As Decimal = Calculate_Svc_Subtotal(decOilSubtotal, decTransSubtotal, decMiscSubtotal)
        'Me.Text = decSvcAndLabor.ToString("C")
        Dim decTax As Decimal = CalculateTax()
        Dim decTotalFees As Decimal = decSvcAndLabor + m_decParts + decTax

        DisplaySummary(decSvcAndLabor, decTax, decTotalFees)
        btnClear.Focus()
    End Sub

    'Calculate_Oil_Lube()
    Private Function Calculate_Oil_Lube() As Decimal
        Dim decOilSubtotal As Decimal = 0D
        If chkOil.Checked Then
            decOilSubtotal = decOILPRICE

        End If

        If chkLube.Checked Then
            decOilSubtotal += decLUBEPRICE
        End If
        Return decOilSubtotal
    End Function

    ' Calculate_Rad_Trans()
    Private Function Calculate_Rad_Trans() As Decimal
        Dim decTransSubtotal As Decimal = 0D
        If chkRadFlush.Checked Then
            decTransSubtotal = decRADPRICE

        End If

        If chkTransFlush.Checked Then
            decTransSubtotal += decTRANSPRICE
        End If

        Return decTransSubtotal
    End Function

    ' Calculate_Misc_Trans()
    Private Function Calculate_Misc() As Decimal
        Dim decMiscSubtotal As Decimal = 0D
        If chkInspection.Checked Then
            decMiscSubtotal = decINSPECTPRICE
        End If

        If chkMuffler.Checked Then
            decMiscSubtotal += decMUFFLERPRICE
        End If

        If chkTire.Checked Then
            decMiscSubtotal += decTIREPRICE
        End If

        Return decMiscSubtotal
    End Function

    'Calculate_Parts_Labor
    Private Sub Calculate_Parts_Labor()
        Const sngMIN2HOUR As Single = 60.0F
        Dim decPartsCost As Decimal = 0D
        Dim sngMinutes As Single = 0F

        Try
            decPartsCost = CDec(txtParts.Text)
            sngMinutes = CSng(txtLabor.Text)
        Catch ex As Exception
            MessageBox.Show("Invalid Entry!", "User Error!", MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            txtParts.Clear()
            txtLabor.Clear()
            txtParts.Focus()

        End Try
        m_decParts = decPartsCost

        m_decLabor = CDec(sngMinutes / sngMIN2HOUR * decLABORPRICE)
    End Sub

    'Calculate ServiceTotal
    Private Function Calculate_Svc_Subtotal(decOilSubtotal As Decimal, decTransSubtotal As Decimal, decMiscSubtotal As Decimal) As Decimal
        Dim decsvcSubtotal As Decimal

        decsvcSubtotal = decOilSubtotal + decTransSubtotal + decMiscSubtotal + m_decLabor

        Return decsvcSubtotal
    End Function
    ' Caluclate tax
    Private Function CalculateTax() As Decimal


        Dim decTax As Decimal = m_decParts * decTAXRATE

        Return decTax

    End Function

    'DisplaySummary() - sub no return values
    Private Sub DisplaySummary(decSvc As Decimal, decTax As Decimal, decTotal As Decimal)
        lblSrvcLaborVal.Text = decSvc.ToString("C")
        lblPartsSumVal.Text = m_decParts.ToString("C")
        lblTaxVal.Text = decTax.ToString("C")
        lblTotalFeesVal.Text = decTotal.ToString("C")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Yes/NO Exit Validation
    Private Sub frmMain_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Do you wish to quit?",
                           "Quit?", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) =
                           Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    'btnClear
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        m_decParts = 0
        m_decLabor = 0

        txtLabor.Text = "0"
        txtParts.Text = "0"
        chkInspection.Checked = False
        chkMuffler.Checked = False
        chkTire.Checked = False
        chkOil.Checked = False
        chkLube.Checked = False
        chkRadFlush.Checked = False
        chkTransFlush.Checked = False
        lblSrvcLaborVal.Text = String.Empty
        lblPartsSumVal.Text = String.Empty
        lblTaxVal.Text = String.Empty
        lblTotalFeesVal.Text = String.Empty

        grpbxOilLub.Focus()

    End Sub
End Class
