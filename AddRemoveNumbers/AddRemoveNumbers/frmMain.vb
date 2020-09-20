'Program: AddRemoveNumbers
'me. frmMain.vb
'Date: 27-Apr-2020
'Purpose: Allows the user to add and remove phone numbers from the lists
Public Class frmMain
    Private strPhone() As String = {"Levi (815)-555-1551", "Petra (815)-555-1552", "Connie (815)-555-1553",
    "Mikasa (815)-555-1554", "Eren (815)-555-1555", "Hange (815)-555-1556", "Reiner (815)-555-1557",
    "Grisha (815)-555-1558", "Sasha (815)-555-1559", "Rico (815)-555-1561"}
    Private strEnrollments(0, 0) As String

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSplash.ShowDialog()
        For Each phoneName In strPhone
            lstShownNumbers.Items.Add(phoneName)
        Next
        lblMemberTotalVal.Text = lstSelectedNumbers.Items.Count.ToString() & " members"
        btnClear.Enabled = False
    End Sub
    Function CheckForInsertErrors() As Boolean
        If lstShownNumbers.SelectedIndex = -1 Then
            MessageBox.Show("Select a person to add!")
            Return False
        End If
        Return True
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If Not CheckForInsertErrors() Then
            Return
        End If
        Dim name As String = lstShownNumbers.SelectedItem.ToString()
        If Not lstSelectedNumbers.Items.Contains(name) Then
            lstSelectedNumbers.Items.Add(lstShownNumbers.SelectedItem)
            lblMemberTotalVal.Text = lstSelectedNumbers.Items.Count.ToString & " members"
        End If
        btnClear.Enabled = True

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim index As Integer = lstSelectedNumbers.SelectedIndex
        If index <> -1 Then
            lstSelectedNumbers.Items.RemoveAt(index)

        End If
        lblMemberTotalVal.Text = lstSelectedNumbers.Items.Count.ToString() & " members"
        btnClear.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If MessageBox.Show("Do you wish to Clear Form?",
                           "Clear Form?", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) =
                           Windows.Forms.DialogResult.Yes Then
            lstSelectedNumbers.Items.Clear()
            lblMemberTotalVal.Text = lstSelectedNumbers.Items.Count.ToString() & " members"
        End If
        btnClear.Enabled = False
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
