'Program: Insurance
'Me: splashScreen.vb
'Date: 17 Feb 2020
'Author: G.Tang
'Purpose: A simple splash screen for this program
Public Class splashScreen
    Private Sub timerData_Tick(sender As Object, e As EventArgs) Handles timerData.Tick
        Me.Close()
    End Sub
End Class