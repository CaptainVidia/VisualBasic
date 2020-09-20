'Program: AOT Sculpture Sale
' Me:frmChange.vb
' Date: 4/20/2020
'Author: G.Tang
'Purpose: a form to calulcate the chnage form the sales subtracted
'the tendered amount And Then "dispense " the proper denominations

Public Class frmChange

    '======================== frmChange_Activated()
    Private Sub frmChange_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Constants
        Const DOLLAR As Decimal = 1D
        Const QUARTER As Decimal = 0.25D
        Const DIME As Decimal = 0.1D
        Const NICKEL As Decimal = 0.5D


        'Variables
        Dim decTempChange As Decimal
        Dim shoDollar As Short
        Dim shoQuarter As Short
        Dim shoDime As Short
        Dim shoNickel As Short
        Dim shoPenny As Short
        Dim decQuarter As Decimal
        Dim decDime As Decimal
        Dim decNickel As Decimal

        If Me.Visible = False Then Me.Visible = True
        g_decChange = g_decTendered - g_decGrossSale
        lblChangeDueVal.Text = g_decChange.ToString("C")
        lblTotalVal.Text = g_decGrossSale.ToString("C")
        lblTenderedVal.Text = g_decTendered.ToString("C")

        decTempChange = g_decChange
        shoDollar = CShort(decTempChange - (decTempChange Mod DOLLAR))
        lblDollarsVal.Text = shoDollar.ToString()

        decTempChange = decTempChange - (CDec(shoDollar) * DOLLAR)
        decQuarter = decTempChange - (decTempChange Mod QUARTER)
        shoQuarter = CShort(decQuarter / QUARTER)

        'If shoQuarter < 0 Then
        '    shoQuarter = 0
        'End If

        lblQuartersVal.Text = shoQuarter.ToString()


        decTempChange = decTempChange - (CDec(shoQuarter) * QUARTER)
        decDime = decTempChange - (decTempChange Mod DIME)
        shoDime = CShort(decDime / DIME)

        'If shoDime < 0 Then
        '    shoDime = 0
        'End If

        lblDimesVal.Text = shoDime.ToString()

        decTempChange = decTempChange - (CDec(shoNickel) * QUARTER)
        decNickel = decTempChange - (decTempChange Mod NICKEL)
        shoNickel = CShort(decNickel / NICKEL)
        'If shoNickel < 0 Then
        '    shoNickel = 0
        'End If
        lblNickelsVal.Text = shoNickel.ToString()

        shoPenny = CShort(decTempChange * 100)

        'If shoPenny < 0 Then
        '    shoPenny = 0
        'End If
        lblPenniesVal.Text = shoPenny.ToString()



    End Sub

    '====================================== btnNext_Click =========================
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        frmReceipt.ShowDialog()
    End Sub

    Private Sub frmChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class