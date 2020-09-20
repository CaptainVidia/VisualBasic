'Program: Pennies For A Day
'Me: splashForm.vb
'Date: 9-Mar-2020
'Author: G.Tang
' Purpose: A simple splash form for Pennies For A Day program
Public Class frmSplash
    Private Sub timerData_Tick(sender As Object, e As EventArgs) Handles timerData.Tick
        Me.Close()
    End Sub

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class