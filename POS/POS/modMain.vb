'Program: AOT Sculpture Sale
' Me:modMain.vb
' Date: 4/20/2020
'Author: G.Tang
'Purpose: to control the delievery of the application and to intitlaize global variables

Option Strict On
Option Explicit On

Module modMain
    '=========================== variables =============================================
    Public g_strItems(10, 3) As String
    Public g_decNetSale As Decimal
    'decStateTax changed to Agency Tax
    Public g_decStateTax As Decimal
    'decLocalTax changed to commission tax
    Public g_decSculptor As Decimal
    Public g_decGrossSale As Decimal
    Public g_decTendered As Decimal
    Public g_decChange As Decimal
    Public g_boolEndFlag As Boolean = False
    'decSTATETAX to decAgencyTax
    Public g_decTAX As Decimal = 0.2D
    'Public g_decSTATETAXRATE As Decimal = 0.2D
    'decLocalTax to Commission
    Public g_decSCULPTORTAX As Decimal = 0.15D
    'Public g_decLOCALTAXRATE As Decimal = 0.5D


    '==================================== modMain()==================================
    Public Sub Main()
        'frmSplash.ShowDialog() 'undo comment when splash is ready
        Do
            Call InitializeItemArray()
            frmPOS.ShowDialog()

        Loop Until g_boolEndFlag = True
    End Sub

    '======================== InitializeItemArray()
    Public Sub InitializeitemArray()
        g_strItems(0, 0) = "NULL"
        g_strItems(0, 1) = "NULL"
        g_strItems(0, 2) = "0"
        g_strItems(0, 3) = "0"

        g_strItems(1, 0) = "Mikasa Ackerman" 'item
        g_strItems(1, 1) = "299.99" 'price of item
        g_strItems(1, 2) = "0" 'how many people buy
        g_strItems(1, 3) = "0" 'subtotal price of item

        g_strItems(2, 0) = "Eren Yaeger"
        g_strItems(2, 1) = "99.99"
        g_strItems(2, 2) = "0"
        g_strItems(2, 3) = "0"

        g_strItems(3, 0) = "Levi Ackerman"
        g_strItems(3, 1) = "449.99"
        g_strItems(3, 2) = "0"
        g_strItems(3, 3) = "0"

        g_strItems(4, 0) = "Hange Zoe"
        g_strItems(4, 1) = "499.99"
        g_strItems(4, 2) = "0"
        g_strItems(4, 3) = "0"

        g_strItems(5, 0) = "Armin Arlert"
        g_strItems(5, 1) = "59.99"
        g_strItems(5, 2) = "0"
        g_strItems(5, 3) = "0"

        g_strItems(6, 0) = "Annie Leonhardt"
        g_strItems(6, 1) = "69.99"
        g_strItems(6, 2) = "0"
        g_strItems(6, 3) = "0"

        g_strItems(7, 0) = "Sasha Braus"
        g_strItems(7, 1) = "59.99"
        g_strItems(7, 2) = "0"
        g_strItems(7, 3) = "0"

        g_strItems(8, 0) = "Reiner Braun"
        g_strItems(8, 1) = "55.99"
        g_strItems(8, 2) = "0"
        g_strItems(8, 3) = "0"

        g_strItems(9, 0) = "Connie Springer"
        g_strItems(9, 1) = "50.99"
        g_strItems(9, 2) = "0"
        g_strItems(9, 3) = "0"

        g_strItems(10, 0) = "Petra Hall"
        g_strItems(10, 1) = "60.99"
        g_strItems(10, 2) = "0"
        g_strItems(10, 3) = "0"
    End Sub

End Module
