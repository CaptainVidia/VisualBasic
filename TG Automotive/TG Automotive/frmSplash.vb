'Program: TG Automotive
'Me: splashForm.vb
'Date: 4-Apr-2020
'Author: G.Tang
' Purpose: simple splash form for TG Automotive
Public Class frmSplash
    Private Sub timerData_Tick(sender As Object, e As EventArgs) Handles timerData.Tick
        Me.Close()
    End Sub
End Class