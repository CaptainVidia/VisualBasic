'Program: Vaction Rental
'Me: mainForm.vb
'Date: 2-Mar-2020
'Author: G.Tang
' Purpose: Allows the user to pick various options for Neighborhood Names and residency.
'           Then the program checks for each checked option then displays the chosen
'           information to the user.
Public Class mainForm
    Private Sub continueButton_Click(sender As Object, e As EventArgs) Handles continueButton.Click
        If wallMariaCheckBox.Checked = True Then
            neighResultLabel.Text &= "Wall Maria "
        End If
        If wallRoseCheckBox.Checked = True Then
            neighResultLabel.Text &= ", Wall Rose "
        End If
        If wallSinaCheckBox.Checked = True Then
            neighResultLabel.Text &= ", Wall Sina "
        End If
        If marleyCheckBox.Checked = True Then
            neighResultLabel.Text &= ", Marley "
        End If
        If alliedForcesCheckBox.Checked = True Then
            neighResultLabel.Text &= ", Mid-East Allied Forces "
        End If
        If smallCheckBox.Checked = True Then
            residencyResultLabel.Text &= " Small Hotel "
        End If
        If largeCheckBox.Checked = True Then
            residencyResultLabel.Text &= ", Large Hotel "
        End If
        If studioCheckBox.Checked = True Then
            residencyResultLabel.Text &= ", Studio "
        End If
        If twoBedCheckBox.Checked = True Then
            residencyResultLabel.Text &= ", 2-Bed Apartment "
        End If
        If oneBedCheckBox.Checked = True Then
            residencyResultLabel.Text &= ", 1-Bed Apartment "
        End If
    End Sub


    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        residencyResultLabel.Text = String.Empty
        neighResultLabel.Text = String.Empty
        wallMariaCheckBox.Checked = False
        wallRoseCheckBox.Checked = False
        wallSinaCheckBox.Checked = False
        marleyCheckBox.Checked = False
        alliedForcesCheckBox.Checked = False
        smallCheckBox.Checked = False
        largeCheckBox.Checked = False
        studioCheckBox.Checked = False
        twoBedCheckBox.Checked = False
        oneBedCheckBox.Checked = False
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
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

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
    End Sub
End Class
