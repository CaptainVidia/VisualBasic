'Program: Integer Math Tutor
'Me: splashForm.vb
'Date: 16-Mar-2020
'Author: G.Tang
' Purpose: A simple splash form for Integer Math Tutor program
Public Class splashForm
    Private Sub timerData_Tick(sender As Object, e As EventArgs) Handles timerData.Tick
        Me.Close()
    End Sub
End Class