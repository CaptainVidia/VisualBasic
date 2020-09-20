'Program: Vaction Rental
'Me: splashForm.vb
'Date: 2-Mar-2020
'Author: G.Tang
' Purpose: A simple splash form for Vacation Rental program
Public Class splashForm
    Private Sub timerData_Tick(sender As Object, e As EventArgs) Handles timerData.Tick
        Me.Close()
    End Sub
End Class