'Program: Retail Price Calculator
'Me: splashForm.vb
'Date: 4-Apr-2020
'Author: G.Tang
' Purpose: a simple splash form for Retail Price Calculator program
Public Class splashForm
    Private Sub timerData_Tick(sender As Object, e As EventArgs) Handles timerData.Tick
        Me.Close()
    End Sub
End Class