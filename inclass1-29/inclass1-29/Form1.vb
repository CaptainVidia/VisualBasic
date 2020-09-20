Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowsSplash.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDate.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnBoolean_Click(sender As Object, e As EventArgs) Handles btnBoolean.Click
        lblHungValue.Text = "binSelected"
        lblHumpValue.Text = "isSelected"
        lblDefValue.Text = "True or False"

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

    Private Sub btnByte_Click(sender As Object, e As EventArgs) Handles btnByte.Click
        lblHungValue.Text = "dtmBirthday"
        lblHumpValue.Text = "birthdayDate"
        lblDefValue.Text = "January 1 .0001 - December 31, 9999"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub
End Class
