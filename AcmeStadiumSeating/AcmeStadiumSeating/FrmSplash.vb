'Program: Acme Stadium Seating
'Me: frmSplash.vb
'Author: G.Tang
'Purpose: A simple splash screen for this program

Option Explicit On
Option Strict On

Public Class FrmSplash
    Private Sub timerData_Tick(sender As Object, e As EventArgs) Handles timerData.Tick
        Me.Close()
    End Sub
End Class