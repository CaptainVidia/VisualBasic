'Program: AOT Sculpture Sale
' Me:frmPOS.vb
' Date: 4/20/2020
'Author: G.Tang
'Purpose: The main sales screen for the application
Option Strict On
Option Explicit On
Public Class frmPOS
    Private m_decTempNet As Decimal
    Dim btnClick As Boolean

    '======================= frmPOS_FormClosing() =========================================================
    Private Sub frmPOS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dlgDecision As System.Windows.Forms.DialogResult

        dlgDecision = MessageBox.Show("Yes to close" & vbNewLine & "No to start new sale" &
            vbNewLine & "Cancel to continue", "Buh Bye!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)


        Select Case (dlgDecision)
            Case Windows.Forms.DialogResult.Yes
                g_boolEndFlag = True
            Case Windows.Forms.DialogResult.No
                e.Cancel = True
            Case Else
                btnClear_Click(sender, e) 'uncomment when you have a clear button
        End Select


    End Sub

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSplash.ShowDialog()
        MessageBox.Show("Welcome to Jaeger Shop! We sell custom made statues of various Attack on Titan characters from the anime." & vbNewLine &
                         "Sculptures are live size up to 8 feet" & vbNewLine &
                        "Disclaimer: You will be charged extra if you want multple character statues" & vbNewLine & "Happy Shopping, SHINZHOU SASAGEYO!! ", "G.Tang & Jaegers")
        For Each thisControl As System.Windows.Forms.Control In Me.Controls

            If CInt(thisControl.Tag) > 0 And CInt(thisControl.Tag) < 11 Then
                thisControl.BackColor = Color.Black
                'thisControl.Enabled = False 'disable seats until the destination
                thisControl.Text = g_strItems(CInt(thisControl.Tag), 0)
            End If
            ttpItem.SetToolTip(thisControl, thisControl.Text)
        Next thisControl
        'lstManifest.Visible = False
        btnNext.Enabled = False
    End Sub
    '========================= itemSold_Click=====================================================================
    Private Sub itemSold_Click(sender As Object, e As EventArgs) Handles btnItem9.Click, btnItem8.Click, btnItem7.Click, btnItem6.Click, btnItem5.Click,
        btnItem4.Click, btnItem3.Click, btnItem2.Click, btnItem10.Click, btnItem1.Click
        Dim shoIndex As Short
        Dim btnClick As Boolean = True

        btnNext.Enabled = True
        'code can be reduced to minimal below
        'If sender Is btnItem1 Then
        '    shoIndex = 1
        'ElseIf sender Is btnItem2 Then
        '    shoIndex = 2
        'End If..... Or easier would be below code

        Dim myControl As New Button

        myControl = DirectCast(sender, Button)
        shoIndex = CShort(myControl.Tag)


        If chkSubtract.Checked = False Then
            g_strItems(shoIndex, 2) = CStr(CShort(g_strItems(shoIndex, 2)) + 1S)
            m_decTempNet += CDec(g_strItems(shoIndex, 1))
            lblItemVal.Text = g_strItems(shoIndex, 1)

        ElseIf g_strItems(shoIndex, 2) > "0" Then

            g_strItems(shoIndex, 2) = CStr(CShort(g_strItems(shoIndex, 2)) - 1S)
            m_decTempNet -= CDec(g_strItems(shoIndex, 1))
            lblItemVal.Text = "-" & g_strItems(shoIndex, 1)

        Else
            MessageBox.Show("You do not have any of those to deduct", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If
        chkSubtract.Checked = False

        lblNetVal.Text = m_decTempNet.ToString("C")


        g_strItems(shoIndex, 3) = (CDec(g_strItems(shoIndex, 1)) * CDec(g_strItems(shoIndex, 2))).ToString
        lstItemsSold.Items.Clear()
        For shoCount As Short = 1 To 10
            Dim strLine As String = ""
            If g_strItems(shoCount, 2) <> "0" Then
                strLine = "Statue" & Space(2) & g_strItems(shoCount, 2) & Space(2) & g_strItems(shoCount, 0) & Space(2) &
                    g_strItems(shoCount, 1) & Space(2) &
                FormatCurrency(g_strItems(shoCount, 3))
            End If
            lstItemsSold.Items.Add(strLine)
        Next shoCount 'shoCount here but it is not neccessary, makes it easy to know when loop ends

    End Sub

    Private Sub chkSubtract_CheckedChanged(sender As Object, e As EventArgs) Handles chkSubtract.CheckedChanged
        If chkSubtract.Checked Then
            chkSubtract.BackColor = Color.Red
        Else
            chkSubtract.BackColor = Color.LightGreen
        End If
    End Sub
    '============================ btnClear() ============================================
    Public Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Call modMain.InitializeitemArray()
        g_decNetSale = 0
        m_decTempNet = 0
        lstItemsSold.Items.Clear()
        lblItemVal.Text = "0.00"
        lblNetVal.Text = "0.00"

    End Sub

    '=============================== btnNext_Click () ===================================
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        g_decNetSale = m_decTempNet
        frmTendered.ShowDialog()

    End Sub
End Class

