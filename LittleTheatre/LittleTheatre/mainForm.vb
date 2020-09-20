'Program: Little Theatre Ticket Sales
'me. mainForm.vb
'Date: 6-Apr-2020
'Purpose: A program to track the ticket sales and occupants of the seats
'           of a 30 seat theatre
Option Explicit On
Option Strict On

'mainForm_Load()
Public Class mainForm
    'm_ = can be declared to use anywhere as long in this class
    'CT = count
    'Private instead dim
    ' do this so the value does not reset to 0
    Private m_premSubDecimal As Decimal
    Private m_normSubDecimal As Decimal
    Private m_econSubDecimal As Decimal
    Private m_totalGrossDecimal As Decimal

    Private m_premCTShort As Short
    Private m_normCTShort As Short
    Private m_econCTShort As Short
    Private m_totalCTShort As Short

    Private m_patronString(30) As String 'an array of the patron names
    Dim countShort As Short

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
        For Each thisControl As System.Windows.Forms.Control In Me.Controls

            If CInt(thisControl.Tag) > 0 Then
                thisControl.BackColor = Color.Yellow
                thisControl.Text = "Seat" & vbNewLine & thisControl.Tag.ToString()

                seatToolTip.SetToolTip(thisControl, thisControl.Text)

            End If

        Next thisControl

    End Sub

    'buySeats()
    Private Sub buySeat(sender As Object, e As EventArgs) Handles seat9CheckBox.CheckedChanged, seat8CheckBox.CheckedChanged,
        seat7CheckBox.CheckedChanged, seat6CheckBox.CheckedChanged, seat5CheckBox.CheckedChanged, seat4CheckBox.CheckedChanged,
        seat3CheckBox.CheckedChanged, seat30CheckBox.CheckedChanged, seat2CheckBox.CheckedChanged, seat29CheckBox.CheckedChanged,
        seat28CheckBox.CheckedChanged, seat27CheckBox.CheckedChanged, seat26CheckBox.CheckedChanged, seat25CheckBox.CheckedChanged,
        seat24CheckBox.CheckedChanged, seat23CheckBox.CheckedChanged, seat22CheckBox.CheckedChanged, seat21CheckBox.CheckedChanged,
        seat20CheckBox.CheckedChanged, seat1CheckBox.CheckedChanged, seat19CheckBox.CheckedChanged, seat18CheckBox.CheckedChanged,
        seat17CheckBox.CheckedChanged, seat16CheckBox.CheckedChanged, seat15CheckBox.CheckedChanged, seat14CheckBox.CheckedChanged,
        seat13CheckBox.CheckedChanged, seat12CheckBox.CheckedChanged, seat11CheckBox.CheckedChanged, seat10CheckBox.CheckedChanged

        Dim purchaserString(30) As String 'created 31 indexed spaces for saving string data
        Const PREM_DECIMAL As Decimal = 20D
        Const NORM_DECIMAL As Decimal = 15D
        Const ECON_DECIMAL As Decimal = 10D


        Dim myControl As New CheckBox
        myControl = DirectCast(sender, CheckBox)
        Dim seatInteger As Integer = CInt(myControl.Tag)
        If myControl.Checked Then
            Dim nameString As String = InputBox("Enter purchaser name: ", "Input Name")
            seatInteger = CInt(myControl.Tag)
            myControl.BackColor = Color.Red
            seatToolTip.SetToolTip(myControl, nameString)

            m_patronString(seatInteger) = nameString 'save te name into our patron string

            Select Case (CInt(myControl.Tag))
                Case < 13
                    m_premCTShort += 1S
                    m_premSubDecimal += PREM_DECIMAL
                    premSoldValLabel.Text = m_premCTShort.ToString
                    premSubtotalValLabel.Text = m_premSubDecimal.ToString("C")

                Case < 24
                    m_normCTShort += 1S
                    m_normSubDecimal += NORM_DECIMAL
                    normSoldValLabel.Text = m_normCTShort.ToString
                    normSubtotalValLabel.Text = m_normSubDecimal.ToString("C")

                Case Else
                    m_econCTShort += 1S
                    m_econSubDecimal += ECON_DECIMAL
                    econSoldValLabel.Text = m_econCTShort.ToString
                    econSubtotalValLabel.Text = m_econSubDecimal.ToString("C")

            End Select
            UpdateSeatingChart()
        Else

            myControl.BackColor = Color.Yellow
            seatToolTip.SetToolTip(myControl, "Seat" & vbNewLine & myControl.Tag.ToString())
            m_patronString(seatInteger) = String.Empty

            Select Case (CInt(myControl.Tag))
                Case < 13
                    m_premCTShort -= 1S
                    m_premSubDecimal -= PREM_DECIMAL
                    premSoldValLabel.Text = m_premCTShort.ToString
                    premSubtotalValLabel.Text = m_premSubDecimal.ToString("C")

                Case < 25
                    m_normCTShort -= 1S
                    m_normSubDecimal -= NORM_DECIMAL
                    normSoldValLabel.Text = m_normCTShort.ToString
                    normSubtotalValLabel.Text = m_normSubDecimal.ToString("C")

                Case Else
                    m_econCTShort -= 1S
                    m_econSubDecimal -= ECON_DECIMAL
                    econSoldValLabel.Text = m_econCTShort.ToString
                    econSubtotalValLabel.Text = m_econSubDecimal.ToString("C")

            End Select
            UpdateSeatingChart()
        End If
        m_totalCTShort = m_premCTShort + m_normCTShort + m_econCTShort
        m_totalGrossDecimal = m_premSubDecimal + m_normSubDecimal + m_econSubDecimal
        totalSoldValLabel.Text = m_totalCTShort.ToString
        totalSubtotalValLabel.Text = m_totalGrossDecimal.ToString("C")


    End Sub

    Private Sub chartCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles chartCheckBox.CheckedChanged
        'chartList.Visible = chartCheckBox.Checked   'toggles Check Listbox. true and flase visibility
        If chartCheckBox.Checked Then
            chartListBox.Visible = True
        Else
            chartListBox.Visible = False
        End If
    End Sub

    'UpdateSeatingChart()
    Private Sub UpdateSeatingChart()
        Dim countShort As Short
        chartListBox.Items.Clear()

        For countShort = 1 To 30
            chartListBox.Items.Add("Seat# " & countShort.ToString & " " & m_patronString(countShort))
        Next countShort
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        'cleat Listbox

        ReDim m_patronString(30)
        Dim countShort As Short
        chartListBox.Items.Clear()
        For countShort = 1 To 30
            chartListBox.Items.Add("Seat# " & countShort.ToString & " " & m_patronString(countShort))
        Next countShort

        'clear labels
        premSoldValLabel.Text = String.Empty
        premSubtotalValLabel.Text = String.Empty
        normSoldValLabel.Text = String.Empty
        normSubtotalValLabel.Text = String.Empty
        econSoldValLabel.Text = String.Empty
        econSubtotalValLabel.Text = String.Empty
        totalSoldValLabel.Text = String.Empty
        totalSubtotalValLabel.Text = String.Empty

        'clear seats buttons
        For Each thisControl As System.Windows.Forms.Control In Me.Controls

            If CInt(thisControl.Tag) > 0 Then
                thisControl.BackColor = Color.Yellow
                thisControl.Text = "Seat" & vbNewLine & thisControl.Tag.ToString()

                seatToolTip.SetToolTip(thisControl, thisControl.Text)
            End If

        Next thisControl
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
'clearbtn
'To reset the m_patron array to all empty elements
'Redim m_patronString(30)
'Clear all Labels
'Clear all m_tyoe variables
'Uncheck all checkboxes "seats"