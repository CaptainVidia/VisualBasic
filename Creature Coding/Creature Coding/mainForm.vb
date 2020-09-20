'Program: Creature Coding
'Me: mainForm.vb
'Date: 13-Apr-2020
'Author: G.Tang
'Purpose: The local Creature shelter has a coding system For creatures. Mr. Shepherd the office manager 
'    has some people that never can remember what creatures the codes represent. You fix this problem 
'    by advising Mr. Shepherd that by Using parallel Single-dimension arrays you will create a listbox 
'that When the employee clicks On an animal type, the coding number will appear In a label. 
'    (NOTE: YOU MUST USE PARALLEL Single DIMENSION ARRAYS 
'For this exercise - yes I know you could use a two-dimensional array, but Not this week). 
'    Hint: Listboxes have an Event called .SelectedIndex

'Creature = Codes

'Blood Donors = 100
'Shape Shifter = 200
'Ghost = 300
'Witch = 400
'Warlock = 500
'Chimaera = 600
'Zombie = 700
'Japanese(Godzilla, Mothra, Gamera) = 800
'Vampires = 900
'
Public Class mainForm
    Private m_BloodDonors As Integer = 100
    Private m_ShapeShifter As Integer = 200
    Private m_Ghost As Integer = 300
    Private m_Witch As Integer = 400
    Private m_Warlock As Integer = 500
    Private m_Chimaera As Integer = 600
    Private m_Zombie As Integer = 700
    Private m_Japanese As Integer = 800
    Private m_Vampires As Integer = 900
    Dim code As Integer
    Dim creatures() As String = {"Blood Donors", "Shape Shifter", "Ghost", "Witch", "Warlock", "Chimaera", "Zombie",
        "Japanese (Godzilla, Mothra, Gamera)", "Vampires"}

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
        For Each obj As Object In creatures
            creaturesCheckedListBox.Items.Add(obj)
        Next



    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub



    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        codeNumValLabel.Text = String.Empty



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

    Private Sub choiceClick(sender As Object, e As EventArgs) Handles creaturesCheckedListBox.SelectedIndexChanged

        Try
            Dim creature As String = creaturesCheckedListBox.SelectedItem.ToString()
            If creature = "Blood Donors" Then
                code = m_BloodDonors
            ElseIf creature = "Shape Shifter" Then
                code = m_ShapeShifter
            ElseIf creature = "Ghost" Then
                code = m_Ghost
            ElseIf creature = "Witch" Then
                code = m_Witch
            ElseIf creature = "Warlock" Then
                code = m_Warlock
            ElseIf creature = "Chimaera" Then
                code = m_Chimaera
            ElseIf creature = "Zombie" Then
                code = m_Zombie
            ElseIf creature = "Japanese (Godzilla, Mothra, Gamera)" Then
                code = m_Japanese
            ElseIf creature = "Vampires" Then
                code = m_Vampires


            End If
            codeNumValLabel.Text = code.ToString
            clearButton.Focus()
        Catch ex As Exception
            MessageBox.Show("Select a Creature!", "User input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
    End Sub


End Class
