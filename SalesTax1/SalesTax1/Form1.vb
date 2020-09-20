Public Class Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim i As Double = txtBoxPrice.Text
        i *= txtBoxSalesTax.Text
        txtBoxTotal.Text = i.ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAddToPrice.Click
        Dim i As Double = txtBoxTotal.Text
        i += txtBoxPrice.Text
        txtBoxGrandTotal.Text = i.ToString

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBoxPrice.Clear()
        txtBoxSalesTax.Clear()
        txtBoxTotal.Clear()
        txtBoxGrandTotal.Clear()
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

    Private Sub txtBoxPrice_TextChanged(sender As Object, e As EventArgs) Handles txtBoxPrice.TextChanged

    End Sub
End Class
