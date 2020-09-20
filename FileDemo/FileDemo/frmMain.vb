'Program: File Demo
'me. frmMain.vb
'Date: 15-May-2020
'Purpose: allows user to enter a specified amount of integers and then enter the integers when
'         create button is clicked and then click read button to read the last input of integers.
Imports System.IO
Public Class frmMain
    Private Const strFileName As String = "Numbers.txt"
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim outputFile As StreamWriter
        Dim intMaxNumbers As Integer
        Dim intCount As Integer = 0
        Dim intNumber As Integer

        Try
            intMaxNumbers = CInt(InputBox("How many integers do " & "you want to enter?"))
            Try
                outputFile = File.CreateText(strFileName)
                Do While intCount < intMaxNumbers
                    Try
                        intNumber = CInt(InputBox("Enter a integer!"))
                        outputFile.WriteLine(intNumber)
                        intCount += 1
                    Catch ex As Exception
                        MessageBox.Show("The last value you entered was not " & "a valid integer. Try Again!")
                    End Try
                Loop
                outputFile.Close()
            Catch ex As Exception
                MessageBox.Show("Error creating the file" & strFileName)
            End Try
        Catch ex As Exception
            MessageBox.Show("Enter a valid integer please")
        End Try
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim inputFile As StreamReader
        Dim strInput As String

        Try
            inputFile = File.OpenText(strFileName)
            lstOutput.Items.Clear()
            Do Until inputFile.EndOfStream
                strInput = inputFile.ReadLine()
                lstOutput.Items.Add(strInput)

            Loop
            inputFile.Close()
        Catch ex As Exception
            MessageBox.Show(strFileName & "cannot be opened")
        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSplash.ShowDialog()
    End Sub
End Class
