'Program: Barely Aviation
'me. frmMain.vb
'Date: 13-Apr-2020
'Purpose: A sales and seating for the only aircraft owned by Barely Aviation.
'           The only ariplane they own flies to 4 desinations as stated below 
'           for the price show in economy class (base), first class seating (x4)
'           and business class (base x2)
'Lickskillet, OH(250)
'Toad Suck, AR(300)
'Peculiar, MO(100)
'Greasy, OK(400)

'Meals Available are:
'Beef
'Chicken
'Fish (pescatarian)
'Vegeterian

Option Strict On
Option Explicit On

Public Class frmMain
    'can make a 2D array but need to convert decimal to String = extra work
    'better to create 2 arrays = easier to do and read
    'name of avaiable flights
    Private m_decFirstSubtotal As Decimal
    Private m_decBusSubtotal As Decimal
    Private m_decEconSubtotal As Decimal
    Private m_decTotal As Decimal
    Private m_decGross As Decimal
    Private m_decProfit As Decimal
    Private m_shoFirstCT As Short
    Private m_shoBusCT As Short
    Private m_shoEconCT As Short
    Private m_shoTotal As Short
    Private m_decCostToFly As Decimal
    Private Const shoSEATS As Short = 36

    Private m_strPassenger(36, 2) As String 'a 2D array of the passenger names and meals

    Private a_strDestinations() As String = {"Lickskillet OH", "Toad Suck AR",
                                                "Peculiar, MO", "Greasy OK"}
    'Prices of flight
    Private a_decEconCost() As Decimal = {250D, 300D, 100D, 400D}

    '==================================================== frmMain() ========================
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For shoCount = 0 To 3 Step 1
            cboDestination.Items.Add(a_strDestinations(shoCount))
        Next
        For Each thisControl As System.Windows.Forms.Control In Me.Controls

            If CInt(thisControl.Tag) > 0 Then
                thisControl.BackColor = Color.LightBlue
                thisControl.Enabled = False 'disable seats until the destination
                thisControl.Text = "Seat" & vbNewLine & thisControl.Tag.ToString()

                ttpSeat.SetToolTip(thisControl, thisControl.Text)

            End If

        Next thisControl
        lstManifest.Visible = False
    End Sub

    Private Sub buySeat(sender As Object, e As EventArgs) Handles chkSeat9.CheckedChanged, chkSeat8.CheckedChanged,
        chkSeat7.CheckedChanged, chkSeat6.CheckedChanged, chkSeat5.CheckedChanged, chkSeat4.CheckedChanged,
        chkSeat36.CheckedChanged, chkSeat35.CheckedChanged, chkSeat34.CheckedChanged, chkSeat33.CheckedChanged,
        chkSeat32.CheckedChanged, chkSeat31.CheckedChanged, chkSeat30.CheckedChanged, chkSeat3.CheckedChanged,
        chkSeat29.CheckedChanged, chkSeat28.CheckedChanged, chkSeat27.CheckedChanged, chkSeat26.CheckedChanged,
        chkSeat25.CheckedChanged, chkSeat24.CheckedChanged, chkSeat23.CheckedChanged, chkSeat22.CheckedChanged,
        chkSeat21.CheckedChanged, chkSeat2.CheckedChanged, chkSeat19.CheckedChanged, chkSeat18.CheckedChanged,
        chkSeat17.CheckedChanged, chkSeat16.CheckedChanged, chkSeat15.CheckedChanged, chkSeat14.CheckedChanged,
        chkSeat13.CheckedChanged, chkSeat120.CheckedChanged, chkSeat12.CheckedChanged, chkSeat11.CheckedChanged,
        chkSeat10.CheckedChanged, chkSeat1.CheckedChanged
        Const decFIRSTFACTOR As Decimal = 4D
        Const decBUSFACTOR As Decimal = 2D


        Dim decEconCost As Decimal = a_decEconCost(cboDestination.SelectedIndex)

        m_decCostToFly = CDec(shoSEATS / 2 * decEconCost) 'cost to fly the plane

        Dim myControl As New CheckBox
        myControl = DirectCast(sender, CheckBox)
        Dim shoSeat As Short = CShort(myControl.Tag)

        If myControl.Checked Then
            Dim strName As String = InputBox("Enter purchaser name: ", "Input Name")
            Dim strMeal As String = InputBox("Select Meal: " & vbNewLine & "Beef" & vbNewLine & "Chicken" & vbNewLine &
                                             "Fish" & vbNewLine & "Vegan")

            myControl.BackColor = Color.Red
            ttpSeat.SetToolTip(myControl, strName & vbNewLine & strMeal)

            m_strPassenger(shoSeat, 0) = strName 'save te name into our pasenger array
            m_strPassenger(shoSeat, 1) = strMeal 'save the mean to same passenger

            Select Case (CInt(myControl.Tag))
                Case < 5
                    m_shoFirstCT += 1S
                    m_decFirstSubtotal += decEconCost * decFIRSTFACTOR
                    lblFirstCTVal.Text = m_shoFirstCT.ToString
                    lblFirstSoldVal.Text = m_decFirstSubtotal.ToString("C")


                Case < 13
                    m_shoBusCT += 1S
                    m_decBusSubtotal += decEconCost * decBUSFACTOR
                    lblBusCtVal.Text = m_shoFirstCT.ToString
                    lblBusSoldVal.Text = m_decBusSubtotal.ToString("C")

                Case Else
                    m_shoEconCT += 1S
                    m_decEconSubtotal += decEconCost
                    lblEconCTVal.Text = m_shoFirstCT.ToString
                    lblEconSoldVal.Text = m_decEconSubtotal.ToString("C")


            End Select
            UpdateManifest()
        Else


            myControl.BackColor = Color.LightBlue
            ttpSeat.SetToolTip(myControl, "")

            m_strPassenger(shoSeat, 0) = String.Empty 'save te name into our pasenger array
            m_strPassenger(shoSeat, 1) = String.Empty 'save the mean to same passenger

            Select Case (CInt(myControl.Tag))
                Case < 5
                    m_shoFirstCT -= 1S
                    m_decFirstSubtotal -= decEconCost * decFIRSTFACTOR
                    lblFirstCTVal.Text = m_shoFirstCT.ToString
                    lblFirstSoldVal.Text = m_decFirstSubtotal.ToString("C")


                Case < 13
                    m_shoBusCT -= 1S
                    m_decBusSubtotal -= decEconCost * decBUSFACTOR
                    lblBusCtVal.Text = m_shoFirstCT.ToString
                    lblBusSoldVal.Text = m_decBusSubtotal.ToString("C")

                Case Else
                    m_shoEconCT -= 1S
                    m_decEconSubtotal -= decEconCost
                    lblEconCTVal.Text = m_shoFirstCT.ToString
                    lblEconSoldVal.Text = m_decEconSubtotal.ToString("C")
            End Select
            UpdateManifest()
        End If
        m_decGross = m_decEconSubtotal + m_decFirstSubtotal + m_decBusSubtotal
        lblTotalSalesVal.Text = m_decGross.ToString("C")
        lblCostToFlyVal.Text = m_decCostToFly.ToString("C")

        m_decProfit = m_decGross - m_decCostToFly
        lblProfitVal.Text = m_decProfit.ToString("C")

    End Sub

    Private Sub cboDestination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDestination.SelectedIndexChanged

        Dim decEconSeat As Decimal
        Dim strDest As String
        Select Case cboDestination.SelectedIndex
            Case 0
                decEconSeat = 250D
                strDest = a_strDestinations(0)
            Case 1
                decEconSeat = 300D
                strDest = a_strDestinations(1)
            Case 2
                decEconSeat = 100D
                strDest = a_strDestinations(2)
            Case Else
                decEconSeat = 400D
                strDest = a_strDestinations(3)
        End Select
        'Me.Text = Me.Text & "  " & strDest & " Econ price: " & decEconSeat.ToString("C")

        cboDestination.Enabled = False

        For Each thisControl As System.Windows.Forms.Control In Me.Controls

            If CInt(thisControl.Tag) > 0 Then

                thisControl.Enabled = True ' re enable the seats after the desintation is picked
                thisControl.Text = "Seat" & vbNewLine & thisControl.Tag.ToString()

                ttpSeat.SetToolTip(thisControl, thisControl.Text)

            End If

        Next thisControl
    End Sub
    ' ====================== chkShowmanifest =======================================================
    Private Sub chkShowManifest_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowManifest.CheckedChanged
        lstManifest.Visible = chkShowManifest.Checked
    End Sub
    '======================================UpdateManifest()================================
    Private Sub UpdateManifest()
        Dim countShort As Short
        lstManifest.Items.Clear()

        For shoIndex As Short = 1 To 36 Step 1
            If m_strPassenger(shoIndex, 0) <> "" Then
                lstManifest.Items.Add("Seat" & " " & shoIndex & ":" & m_strPassenger(shoIndex, 0) & " " & m_strPassenger(shoIndex, 1))
            End If
        Next shoIndex
    End Sub
    '================================ btnClear() ==========================================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        If MessageBox.Show("Do you wish to Clear Form?",
                           "Clear Form?", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) =
                           Windows.Forms.DialogResult.Yes Then
            UpdateManifest()
            lstManifest.Items.Clear()
            cboDestination.Enabled = True
            cboDestination.Text = ""
            lblTotalSalesVal.Text = String.Empty
            lblCostToFlyVal.Text = String.Empty
            lblProfitVal.Text = String.Empty
            lblFirstCTVal.Text = String.Empty
            lblFirstSoldVal.Text = String.Empty
            lblBusCtVal.Text = String.Empty
            lblBusSoldVal.Text = String.Empty
            lblEconCTVal.Text = String.Empty
            lblEconSoldVal.Text = String.Empty
            cboDestination.Items.Clear()

            For shoCount = 0 To 3 Step 1

                cboDestination.Items.Add(a_strDestinations(shoCount))
            Next
            For Each thisControl As System.Windows.Forms.Control In Me.Controls

                If CInt(thisControl.Tag) > 0 Then
                    thisControl.BackColor = Color.LightBlue
                    thisControl.Enabled = False 'disable seats until the destination
                    thisControl.Text = "Seat" & vbNewLine & thisControl.Tag.ToString()

                    ttpSeat.SetToolTip(thisControl, thisControl.Text)

                End If

            Next thisControl



        End If

    End Sub
    '============================= btnNewPath =============================================
    Private Sub btnNewPath_Click(sender As Object, e As EventArgs) Handles btnNewPath.Click
        cboDestination.Enabled = True
    End Sub
    '======================================== btnExit() ===================================
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
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
'clear all button
'       try to give second chance on clear "Do you want to clear all" Confirm
'exit button