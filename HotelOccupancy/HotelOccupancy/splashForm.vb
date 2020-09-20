'Program: Hotel Occupancy
'Me: mainForm.vb
'Date: 16-Mar-2020
'Author: G.Tang
' Purpose: a simple splash form for Hotel Occupancy program
Public Class splashForm
    Private Sub timerData_Tick(sender As Object, e As EventArgs) Handles timerData.Tick
        Me.Close()
    End Sub
End Class