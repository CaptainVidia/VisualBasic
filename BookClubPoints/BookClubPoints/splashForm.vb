﻿'Program: Book Club Points
'Me: splashForm.vb
'Date: 2-Mar-2020
'Author: G.Tang
' Purpose: a simple splash form for Book Club Points Program
Public Class splashForm
    Private Sub timerData_Tick(sender As Object, e As EventArgs) Handles timerData.Tick
        Me.Close()
    End Sub
End Class