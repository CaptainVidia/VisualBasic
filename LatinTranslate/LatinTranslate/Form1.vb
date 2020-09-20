'Program: Data Type Study
'Date: 1/29/2021
'Author: G.Tang
'Purpose: a program to allow user to study Visual Basic data types
Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSinster_Click(sender As Object, e As EventArgs) Handles btnSinster.Click
        Dim i As String = lblTranslate.Text
        i = "left"
        lblTranslate.Text = i.ToString

    End Sub

    Private Sub btnDexter_Click(sender As Object, e As EventArgs) Handles btnDexter.Click
        Dim i As String = lblTranslate.Text
        i = "right"
        lblTranslate.Text = i.ToString
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        Dim i As String = lblTranslate.Text
        i = "center"
        lblTranslate.Text = i.ToString
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        lblTranslate.Text = " "

    End Sub

    Private Sub lblLeft_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblTranslate_Click(sender As Object, e As EventArgs) Handles lblTranslate.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashScreen.ShowDialog()


    End Sub
End Class
