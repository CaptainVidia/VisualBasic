'Program: Payroll Processor
'Me: splashFormvb
'Date: 3/2/2020
'Author: G.Tang
'Purpose: A simple splash form for Payroll Processor
Public Class splashForm
    Private Sub timerData_Tick(sender As Object, e As EventArgs) Handles timerData.Tick
        Me.Close()
    End Sub
End Class