Public Class mainForm
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

        If yearlyLicenseRadioButton.Checked Then
            yearlyLicenseRadioButton.Checked = False
        End If
        If oneTimePurchaseRadioButton.Checked Then
            oneTimePurchaseRadioButton.Checked = False
        End If
        If technicalSupportCheckBox.Checked Then
            technicalSupportCheckBox.Checked = False
        End If
        If onSiteTrainingCheckBox.Checked Then
            onSiteTrainingCheckBox.Checked = False
        End If
        If cloudBackupCheckBox.Checked Then
            cloudBackupCheckBox.Checked = False
        End If
        softwareLicensingResultLabel.Text = " "
        optionalFeaturesResultLabel.Text = " "
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Const yearlyLicense = 5000.0F
        Const oneTimePurchase = 20000.0F
        Const level3TechnicalSupport = 3500.0F
        Const onSiteTraining = 2000.0F
        Const cloudBackup = 300.0F
        Dim total As Single




        Try
            If yearlyLicenseRadioButton.Checked Then
                softwareLicensingResultLabel.Text = yearlyLicense.ToString("C")


            ElseIf oneTimePurchaseRadioButton.Checked Then
                softwareLicensingResultLabel.Text = oneTimePurchase.ToString("C")
            End If

            If technicalSupportCheckBox.Checked And onSiteTrainingCheckBox.Checked And cloudBackupCheckBox.Checked Then
                total = level3TechnicalSupport + onSiteTraining + cloudBackup
                optionalFeaturesResultLabel.Text = total.ToString("C")


            ElseIf technicalSupportCheckBox.Checked And onSiteTrainingCheckBox.Checked Then
                total = level3TechnicalSupport + onSiteTraining
                optionalFeaturesResultLabel.Text = total.ToString("C")

            ElseIf technicalSupportCheckBox.Checked And cloudBackupCheckBox.Checked Then
                total = level3TechnicalSupport + cloudBackup
                optionalFeaturesResultLabel.Text = total.ToString("C")

            ElseIf onSiteTrainingCheckBox.Checked And cloudBackupCheckBox.Checked Then
                total = onSiteTraining + cloudBackup
                optionalFeaturesResultLabel.Text = total.ToString("C")

            ElseIf technicalSupportCheckBox.Checked Then

                optionalFeaturesResultLabel.Text = level3TechnicalSupport.ToString("C")


            ElseIf onSiteTrainingCheckBox.Checked Then

                optionalFeaturesResultLabel.Text = onSiteTraining.ToString("C")


            ElseIf cloudBackupCheckBox.Checked Then

                optionalFeaturesResultLabel.Text = cloudBackup.ToString("C")
            End If

        Catch


        End Try
    End Sub

End Class
