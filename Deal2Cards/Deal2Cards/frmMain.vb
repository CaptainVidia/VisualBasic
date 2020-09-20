Public Class frmMain
    Private randNumDealer As Integer
    Private randSuitDealer As Integer

    Private randNumPlayer As Integer
    Private randSuitPlayer As Integer

    Private cardValDealer As Integer
    Private cardValPlayer As Integer

    Private resultCardNum As String
    Private randCardSuit As String

    Private randPlayerCardSuit As String
    Private resultPlayerCardNum As String
    Private a_strCardVal() As String = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven",
        "Eight", "Nine", "Ten", "Jack", "Queen", "King"}
    Private a_strSuits() As String = {"Spades", "Diamonds", "Hearts","Clubs"}
    Private Const dealerWins As Integer = 0
    Private Const playerWins As Integer = 0
    Private dealerTotalWins As Integer

    Private totalPlayerWins As Integer

    Private Sub btnDeal_Click(sender As Object, e As EventArgs) Handles btnDeal.Click
        Dim cards(0 To 51) As String
        Dim c1 As String
        Dim c2 As String
        Dim temp As String
        btnEvaluate.Enabled = True
        'randNumDealer = Int((14 * Rnd()) + 1)
        randNumPlayer = Int((14 * Rnd()) + 1)

        randSuitDealer = Int((4 * Rnd()) + 1)
        randSuitPlayer = Int((4 * Rnd()) + 1)
        For i = 0 To 3
            For j = 0 To 12
                cards(13 * i + j) = a_strCardVal(j) & a_strSuits(i)
            Next j
        Next i

        For i = 1 To 1000
            randNumDealer = Int((14 * Rnd()) + 1)
            c2 = Int((14 * Rnd()) + 1)
            temp = cards(randNumDealer)
            cards(randNumDealer) = cards(c2)
            cards(c2) = temp
        Next i


        Select Case (randNumDealer)
            Case = 11
                resultCardNum = "King"
            Case = 12
                resultCardNum = "Queen"
            Case = 13
                resultCardNum = "Jack"
            Case = 1
                resultCardNum = "Ace"
            Case Else
                resultCardNum = randNumDealer
        End Select

        Select Case (randNumPlayer)
            Case = 11
                resultPlayerCardNum = "King"
            Case = 12
                resultPlayerCardNum = "Queen"
            Case = 13
                resultPlayerCardNum = "Jack"
            Case = 1
                resultPlayerCardNum = "Ace"
            Case Else
                resultPlayerCardNum = randNumPlayer
        End Select

        Select Case (randSuitDealer)
            Case 1
                randCardSuit = "Diamonds"
            Case 2
                randCardSuit = "Clubs"
            Case 3
                randCardSuit = "Spades"
            Case 4
                randCardSuit = "Hearts"

        End Select

        Select Case (randSuitPlayer)
            Case 1
                randPlayerCardSuit = "Hearts"
            Case 2
                randPlayerCardSuit = "Spades"
            Case 3
                randPlayerCardSuit = "Clubs"
            Case 4
                randPlayerCardSuit = "Diamonds"

        End Select

        For shoCount = 1 To 2

            lstPlayer.Items.Add("Card" & ":" & shoCount & " " & resultPlayerCardNum & " of " & randPlayerCardSuit)
            lstDealer.Items.Add("Card" & ":" & shoCount & " " & resultCardNum & " of " & randCardSuit)
        Next
        btnDeal.Enabled = False
        btnEvaluate.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click


        Static totalDealerWins As Integer = 0
        Static totalPlayerWins As Integer = 0

        Dim dealerCardVal As String = lblDealerTotalVal.Text
        Dim playerCardVal As String = lblPlayerTotalVal.Text

        cardValDealer = randNumDealer + randNumDealer
        cardValPlayer = randNumPlayer + randNumPlayer

        lblDealerTotalVal.Text = cardValDealer.ToString()
        lblPlayerTotalVal.Text = cardValPlayer.ToString()

        If cardValPlayer < cardValDealer Then

            lblWinner.Text = "Dealer Wins!"
            totalDealerWins += 1
            lblDealerWinsVal.Text = totalDealerWins.ToString()

        ElseIf cardValPlayer > cardValDealer Then
            lblWinner.Text = "Player Wins!"
            totalPlayerWins += 1
            lblPlayerWinsVal.Text = totalPlayerWins.ToString()

        Else
            lblWinner.Text = "Tie!"

        End If
        btnDeal.Enabled = False
        btnEvaluate.Enabled = False
        btnClear.Focus()
        btnDeal.Enabled = False

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstDealer.Items.Clear()
        lstPlayer.Items.Clear()
        lblPlayerTotalVal.Text = String.Empty
        lblDealerTotalVal.Text = String.Empty
        lblWinner.Text = String.Empty
        btnDeal.Enabled = True

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

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nameString As String = InputBox("Enter Your Name: ", "New Player")
        lblPlayerName.Text = nameString.ToString()
        btnDeal.Enabled = True
        btnEvaluate.Enabled = True
    End Sub
End Class
