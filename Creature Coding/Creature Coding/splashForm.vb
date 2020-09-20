'Program: Creature Coding
'Me: mainForm.vb
'Date: 13-Apr-2020
'Author: G.Tang
'Purpose: a simple splash form for Creature Coding

Public Class splashForm
    Private Sub timerData_Tick(sender As Object, e As EventArgs) Handles timerData.Tick
        Me.Close()
    End Sub
End Class