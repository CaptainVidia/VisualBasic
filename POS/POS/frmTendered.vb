'Program: AOT Sculpture Sale
' Me:frmTendered.vb
' Date: 4/20/2020
'Author: G.Tang
'Purpose: allows the user to enter the paid amount to pay. It shows the user the details of the transaction.
Option Strict On
Option Explicit On
Public Class frmTendered
    Private m_strTendered As String 'building amppunt terndered
    Private m_isDecPtFlag As Boolean 'telling if decimal point has been added
    Private m_shoPlaceCt As Short 'counts number placements after decimal

    '================================= frmTendered_Activated() ==================================
    Private Sub frmTendered_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If Me.Visible = False Then Me.Visible = True
        'Call btnClear_Click(sender.e) 'uncomment when button ready
        'decSTATETAX changed to decAGENCYTAX
        g_decStateTax = CDec(g_decNetSale * g_decTAX * 100D + 0.5D) / 100D
        'the abpve line calculates and rounds the state tax to the nearest penny
        ' decLOCALTAX changed to decSCULPTORTAX
        g_decSculptor = CDec(g_decNetSale * g_decSCULPTORTAX * 100D + 0.5D) / 100D
        'the abpve line calculates and rounds the local tax to the nearest penny
        g_decGrossSale = g_decNetSale + g_decStateTax + g_decSculptor
        lblNetVal.Text = g_decNetSale.ToString("C")
        lblStateVal.Text = g_decStateTax.ToString("C")
        lblLocalVal.Text = g_decSculptor.ToString("C")
        lblTotalVal.Text = g_decGrossSale.ToString("C")

        For Each thisControl As System.Windows.Forms.Control In Me.Controls

            If CInt(thisControl.Tag) >= 0 And CInt(thisControl.Tag) < 11 Then
                thisControl.BackColor = Color.Yellow


            End If
            If CInt(thisControl.Tag) > 0 And CInt(thisControl.Tag) < 14 Then
                ttpTendered.SetToolTip(thisControl, thisControl.Text)
            End If
        Next thisControl

    End Sub
    '============================ btnBack_Click() ============================================
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmPOS.Show()
        Me.Close()
    End Sub
    '=========================================== UseCalculator() =============================
    Private Sub UseCalculator(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click,
        btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click

        Dim shoIndex As Short
        Dim btn As Button = CType(sender, Button)

        If m_isDecPtFlag = True Then m_shoPlaceCt += 1S 'adds one to count of digitd after pt

        If m_shoPlaceCt <= 2 Then
            shoIndex = CShort(btn.Tag)
            m_strTendered &= shoIndex.ToString
            lblTenderedVal.Text = m_strTendered
        End If
    End Sub
    '============================= btnDecPt() =========================================
    Private Sub btnDecPt_Click(sender As Object, e As EventArgs) Handles btnDecPt.Click
        m_strTendered &= "."
        btnDecPt.Enabled = False 'disable the decimal pr, since you can only have one
        m_isDecPtFlag = True 'activate the flag to start counting digits after the decimal pt

    End Sub

    '======================= btnClear_Click () =========================================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Dim myControl As Control
        m_strTendered = ""
        btnDecPt.Enabled = True
        lblTenderedVal.Text = "0.00"
        m_isDecPtFlag = False
        m_shoPlaceCt = 0


    End Sub

    '============================= btnNext_Click() ==================================
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Try
            g_decTendered = CDec(m_strTendered)
            If g_decTendered >= g_decGrossSale Then
                Me.Visible = False
                frmChange.ShowDialog()
            Else
                MessageBox.Show("Tendered amount must be more than gross sale!", "Tendered Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call btnClear_Click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("You must enter an amount to pay the bill!", "Tendered Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Class