'Program: Probability Test
'Me: splashForm.vb
'Date: 16-Mar-2020
'Author: G.Tang
' Purpose: a simple splash form for Probability Tester program.
Public Class splashForm
    Private Sub timerData_Tick(sender As Object, e As EventArgs) Handles timerData.Tick
        Me.Close()
    End Sub

    Private Sub splashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class