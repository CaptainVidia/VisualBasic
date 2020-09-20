'Program: StreamReadAndWrite
'me. frmMain.vb
'Date: 4-May-2020
'Purpose: Allows the user to load and save files into the program

Option Strict On
Option Explicit On
Imports System.IO

Public Class frmMain

    '========================= btnSave_Click() =====================================
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Wrting Files
        sfdSave.InitialDirectory = "C:\"
        sfdSave.FileName = "Save As..."
        sfdSave.Filter = "Text Files only (*.txt) | *.txt"
        sfdSave.ShowDialog()

        'Intialize try in case user exit the folder tab
        Try
            Dim w As New IO.StreamWriter(sfdSave.FileName)
            w.Write(txtbxText.Text)
            w.Close()

        Catch ex As Exception

            MessageBox.Show("Error in saving file", "Error")

        End Try
        'Disable button nothing to clear
        btnClear.Enabled = True
    End Sub

    '====================================== btnRead_Click ===========================
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ofdLoad.InitialDirectory = "C:\"
        ofdLoad.FileName = "Open a File "
        ofdLoad.Filter = "ONLY Text File (*.txt) | *.txt "
        ofdLoad.ShowDialog()

        'Intialize try in case user exit the folder tab
        Try
            Dim r As New IO.StreamReader(ofdLoad.FileName)

            txtbxRead.Text = r.ReadToEnd
            r.Close()

        Catch ex As Exception

            MessageBox.Show("Error in opening file", "Error!")

        End Try
        btnClear.Enabled = True
        txtbxRead.Enabled = True
    End Sub

    '============================== btnClear_Click() =================================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtbxText.Text = String.Empty
        txtbxRead.Text = String.Empty
        btnClear.Enabled = False


    End Sub

    '====================== btnExit_Click() ===========================================
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    '======================= mainForm_Closing() =======================================
    Private Sub mainForm_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Do you wish to quit?",
                           "Quit?", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) =
                           Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    '================================ frmMain_Load() ===============================
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSplash.ShowDialog()
        btnClear.Enabled = False
        txtbxRead.Enabled = False
    End Sub
End Class
