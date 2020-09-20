'Program: Simple Text Editor
'me. frmSplash.vb
'Date: 15-May-2020
'Purpose: simple splash program
Public Class frmSplash
    Private Sub tmrData_Tick(sender As Object, e As EventArgs) Handles tmrData.Tick
        Me.Close()
    End Sub
End Class