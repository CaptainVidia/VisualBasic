'Program: Retail Price Calculator
'Me: mainForm.vb
'Date: 4-Apr-2020
'Author: G.Tang
' Purpose: This program allows the user to enter the wholesale cost of item and markup. 
'          Then the program will run the function and display the retail price.
Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        wsCostItemValTextBox.Text = String.Empty
        markupValTextBox.Text = String.Empty
        retaiPriceValLabel.Text = String.Empty
        wsCostItemValTextBox.Focus()
    End Sub

    Private Sub getRetailButton_Click(sender As Object, e As EventArgs) Handles getRetailButton.Click

        Dim wholesalePrice As Double
        Dim retailPrice As Double
        Dim markup As Double

        If Double.TryParse(wsCostItemValTextBox.Text, wholesalePrice) And Double.TryParse(markupValTextBox.Text, markup) Then
            If wholesalePrice < 0 Or markup < 0 Then
                MessageBox.Show("Error!! Value cannot be negative")
            Else
                retailPrice = CalculateRetail(wholesalePrice, markup)

                retaiPriceValLabel.Text = "$" + FormatNumber(CDbl(retailPrice), 2)

            End If
        Else
            MessageBox.Show("Error!! Please enter only numeric values!")
        End If
    End Sub

    Function CalculateRetail(ByVal wholeSale As Double, ByVal markup As Double) As Double
        Dim retailPrice As Double
        retailPrice = wholeSale + (wholeSale * markup * 0.01)

        Return retailPrice
    End Function
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
