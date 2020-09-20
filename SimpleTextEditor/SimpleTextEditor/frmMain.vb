'Program: Simple Text Editor
'me. frmMain.vb
'Date: 15-May-2020
'Purpose: allows the user to create a new, open, and save files as text files
Imports System.IO
Public Class frmMain
    Private strFileName As String = String.Empty
    Dim blnIsChanged As Boolean = False

    Sub ClearDocument()
        txtDocument.Clear()
        strFileName = String.Empty
        blnIsChanged = False
    End Sub

    Sub OpenDocument()
        Dim inputFile As StreamReader

        If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFileName = ofdOpenFile.FileName
            Try
                inputFile = File.OpenText(strFileName)
                txtDocument.Text = inputFile.ReadToEnd
                inputFile.Close()
                blnIsChanged = False
            Catch ex As Exception
                MessageBox.Show("Error opening the file!")
            End Try
        End If
    End Sub

    Sub SaveDocument()
        Dim outputFile As StreamWriter
        Try
            sfdSaveFile.InitialDirectory = "C:\"
            sfdSaveFile.FileName = ""
            outputFile = File.CreateText(strFileName)
            outputFile.Write(txtDocument.Text)
            outputFile.Close()
            blnIsChanged = False
        Catch ex As Exception
            MessageBox.Show("Error creating the file!")
        End Try
    End Sub

    Private Sub txtDocument_TextChanged(sender As Object, e As EventArgs) Handles txtDocument.TextChanged
        blnIsChanged = True

    End Sub

    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        If blnIsChanged = True Then
            If MessageBox.Show("The current document is not saved. " & "Are you sure? ", "Confirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                ClearDocument()
            End If
        Else
            ClearDocument()
        End If
    End Sub

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        If blnIsChanged = True Then
            If MessageBox.Show("The current document is not saved. " & "Are you sure? ", "Confirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                ClearDocument()
                OpenDocument()
            End If
        Else
            ClearDocument()
            OpenDocument()
        End If
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        If strFileName = String.Empty Then
            If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                strFileName = sfdSaveFile.FileName
                SaveDocument()
            End If
        Else
            SaveDocument()
        End If

    End Sub

    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFileName = sfdSaveFile.FileName
            SaveDocument()
        End If
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("Simple Text Editor")
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If blnIsChanged = True Then
            If MessageBox.Show("The current document is not saved. " & "Do you wish to continue?", "Confirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSplash.ShowDialog()
    End Sub
End Class
