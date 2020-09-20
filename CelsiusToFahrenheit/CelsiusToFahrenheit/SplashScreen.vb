'Program: Acme Stadium Seating
'Me: SplashScreen.vb
'Author: G.Tang
'Date: 2/10/2020
'Purpose: A simple splash screen for this program

Public Class SplashScreen
    Private Sub timerData_Tick(sender As Object, e As EventArgs) Handles timerData.Tick
        Me.Close()
    End Sub
End Class