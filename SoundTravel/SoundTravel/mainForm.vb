Public Class mainForm

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Const sng_AIR = 1100.0F
        Const sng_WATER = 4900.0F
        Const sng_STEEL = 16400.0F
        Const sng_DIAMOND = 39400.0F

        Try
            Dim sngDistance As Single
            sngDistance = CSng(distanceTextBox.Text)
            Dim sngMedium As Single
            If airRadioButton.Checked Then


                sngMedium = sng_AIR

            ElseIf waterRadioButton.Checked Then
                sngMedium = sng_WATER

            ElseIf steelRadioButton.Checked Then
                sngMedium = sng_STEEL

            ElseIf diamondRadioButton.Checked Then
                sngMedium = sng_DIAMOND
            Else
                MessageBox.Show("Please pick a medium", "medium?", MessageBoxButtons.OK, MessageBoxIcon.Error)
                timeValLabel.Text = String.Empty
                distanceTextBox.Clear()
                distanceTextBox.Focus()

            End If

            If sngMedium > 0 Then
                Dim sngTime As Single
                sngTime = sngDistance / sngMedium
                timeValLabel.Text = sngTime & " seconds"
            End If



        Catch ex As Exception
            MessageBox.Show("Invlaid Entry", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
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

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        distanceTextBox.Clear()
        timeValLabel.Text = " "
        If airRadioButton.Checked Then
            airRadioButton.Checked = False
        End If
        If waterRadioButton.Checked Then
            waterRadioButton.Checked = False
        End If
        If steelRadioButton.Checked Then
            steelRadioButton.Checked = False
        End If
        If diamondRadioButton.Checked Then
            diamondRadioButton.Checked = False
        End If
    End Sub
End Class
