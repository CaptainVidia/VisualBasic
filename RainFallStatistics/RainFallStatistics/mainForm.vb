'Program: RainFall Statistics
'Me: mainForm.vb
'Date: 9-Mar-2020
'Author: G.Tang
' Purpose: A program that asks the user for the number of month. The results are displayed
'           in the month and statistics list boxes. Then the program calculates the average
'           of the current months that have been chosen and displays it.
Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles shoDataButton.Click
        Const rainJan As Decimal = 14.6
        Const rainFeb As Decimal = 10.4
        Const rainMar As Decimal = 10.8
        Const rainApr As Decimal = 7.9
        Const rainMay As Decimal = 5.1
        Const rainJun As Decimal = 3.5
        Const rainJul As Decimal = 2.0
        Const rainAug As Decimal = 2.5
        Const rainSep As Decimal = 3.8
        Const rainOct As Decimal = 10.5
        Const rainNov As Decimal = 10.5
        Const rainDec As Decimal = 13

        Dim decRain As Decimal
        Dim decAvg As Decimal
        Dim decTotal As Decimal
        Dim shoMonth As Decimal = 0S

        shoMonth = CShort(nupdMonth.Value)
        For shoCount = 1 To shoMonth
            If shoCount = 1 Then
                decRain = rainJan
                decTotal = rainJan

            ElseIf shoCount = 2 Then
                decRain = rainFeb
                decTotal = rainJan + rainFeb

            ElseIf shoCount = 3 Then
                decRain = rainMar
                decTotal = rainJan + rainFeb + rainMar

            ElseIf shoCount = 4 Then
                decRain = rainApr
                decTotal = rainJan + rainFeb + rainMar + rainApr

            ElseIf shoCount = 5 Then
                decRain = rainMay
                decTotal = rainJan + rainFeb + rainMar + rainApr + rainMay

            ElseIf shoCount = 6 Then
                decRain = rainJun
                decTotal = rainJan + rainFeb + rainMar + rainApr + rainMay + rainJun

            ElseIf shoCount = 7 Then
                decRain = rainJul
                decTotal = rainJan + rainFeb + rainMar + rainApr + rainMay + rainJun + rainJul

            ElseIf shoCount = 8 Then
                decRain = rainAug
                decTotal = rainJan + rainFeb + rainMar + rainApr + rainMay + rainJun + rainJul + rainAug


            ElseIf shoCount = 9 Then
                decRain = rainSep
                decTotal = rainJan + rainFeb + rainMar + rainApr + rainMay + rainJun + rainJul + rainAug + rainSep

            ElseIf shoCount = 10 Then
                decRain = rainOct
                decTotal = rainJan + rainFeb + rainMar + rainApr + rainMay + rainJun + rainJul + rainAug + rainSep + rainOct

            ElseIf shoCount = 11 Then
                decRain = rainNov
                decTotal = rainJan + rainFeb + rainMar + rainApr + rainMay + rainJun + rainJul + rainAug + rainSep + rainOct + rainNov

            ElseIf shoCount = 12 Then
                decRain = rainDec
                decTotal = rainJan + rainFeb + rainMar + rainApr + rainMay + rainJun + rainJul + rainAug + rainSep + rainOct + rainNov + rainDec

            End If


            monthListBox.Items.Add("Month: " & shoCount & vbNewLine)
            resultListBox.Items.Add("Rainfall: " & decRain.ToString())
        Next

        'decTotal = rainJan + rainFeb + rainMar + rainApr + rainMay + rainJun + rainJul + rainAug + rainSep + rainOct + rainNov + rainDec
        decAvg = decTotal / nupdMonth.Value
        avgListBox.Items.Add("Average: " & Format(decAvg, "0.0"))
        clearButton.Focus()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        nupdMonth.Focus()
        nupdMonth.Value = "1"
        resultListBox.Items.Clear()
        monthListBox.Items.Clear()
        avgListBox.Items.Clear()
    End Sub
    Private Sub mainForm_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Do you wish to quit?",
                           "Quit?", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) =
                           Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
