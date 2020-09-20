Option Explicit On
Option Strict On

Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each thisControl As System.Windows.Forms.Control In Me.Controls

            If CInt(thisControl.Tag) > 0 Then
                thisControl.BackColor = Color.Yellow
                thisControl.Text = "Seat" & thisControl.Tag.ToString()

                seatToolTip.SetToolTip(thisControl, thisControl.Text)
            End If

        Next thisControl

    End Sub
End Class
