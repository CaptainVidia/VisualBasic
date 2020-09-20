'Program: Account Balance
'Date: 1/27/2021
'Author: G.Tang
'Purpose: A program to allow a user to click a 
'           button of a state, and show its abbrevaition
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCurrentBalance.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBoxCurrentBalance.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim i As Double = txtBoxCurrentBalance.Text
        i -= txtBoxWithdraw.Text
        i += txtBoxDeposit.Text
        txtBoxNewBalance.Text = i.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBoxCurrentBalance.Clear()
        txtBoxDeposit.Clear()
        txtBoxWithdraw.Clear()
        txtBoxNewBalance.Clear()



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub Form1_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Do you wish to quit?",
                           "Quit?", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) =
                           Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
