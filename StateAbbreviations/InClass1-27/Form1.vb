'Program: State Abbreviation
'Date: 1/27/2021
'Author: G.Tang
'Purpose: A program to allow a user to click a 
'           button of a state, and show its abbrevaition

Option Strict On
Option Explicit On

Public Class Form1
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnFlorida.Click
        txtboxStateAbbreviation.Text = "FL"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSouthCarolina.Click
        txtboxStateAbbreviation.Text = "SC"
    End Sub

    Private Sub btnillinois_Click(sender As Object, e As EventArgs) Handles btnVirginia.Click
        txtboxStateAbbreviation.Text = "VA"

    End Sub

    Private Sub btnIndiana_Click(sender As Object, e As EventArgs) Handles btnNorthCarolina.Click
        txtboxStateAbbreviation.Text = "NC"
    End Sub

    Private Sub btnWisconsin_Click(sender As Object, e As EventArgs) Handles btnGeorgia.Click
        txtboxStateAbbreviation.Text = "GA"
    End Sub

    Private Sub btnMissouri_Click(sender As Object, e As EventArgs) Handles btnAlabama.Click
        txtboxStateAbbreviation.Text = "AL"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtboxStateAbbreviation.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashScreen.ShowDialog()
    End Sub
    Private Sub Form1_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Do you wish to quit?",
                           "Quit?", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) =
                           Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
