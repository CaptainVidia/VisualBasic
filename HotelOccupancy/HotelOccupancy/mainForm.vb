'Program: Hotel Occupancy
'Me: mainForm.vb
'Date: 16-Mar-2020
'Author: G.Tang
' Purpose: Allows the user to enter number of occupied rooms per floor. Then 
'            the program increments the floor by one and displays the information 
'            in the list box for the user to see easily. 
Public Class mainForm

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashForm.ShowDialog()
        floorLabel.Text = "1"
    End Sub
    Dim Floor As Integer = 1
    Dim occupancy As Integer
    Dim occupancySum As Integer = 0

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Const maximumFloors As Integer = 8
        Const maximumRooms As Integer = 30
        If Floor <= 8 Then
            If Not Integer.TryParse(numRoomsTextBox.Text, occupancy) Then
                MessageBox.Show("Enter Number of Rooms Integer only ")

            ElseIf occupancy > 30 Or occupancy < 0 Then
                MessageBox.Show("Enter Number of Rooms 1 to 30 only ")
            Else
                occupancySum += occupancy
                dataListBox.Items.Add("Floor: " & Floor & " Rooms Occupied: " & occupancy & " Occupancy Rate: " & Math.Round((occupancy / maximumRooms) * 100, 2) & "%") 'display the each room occupancy to the listbox

                If Floor <= 8 Then
                    floorLabel.Text = Floor + 1
                    Floor += 1
                End If
                If Floor = 9 Then
                    floorLabel.Text = 8
                End If
                totalRoomOccupiedValLabel.Text = occupancySum.ToString
                overallOccRateValLabel.Text = Math.Round((occupancySum / (maximumRooms * maximumFloors)) * 100, 2).ToString ''
                numRoomsTextBox.Text = ""
            End If
        End If
    End Sub

    Private Sub restartButton_Click(sender As Object, e As EventArgs) Handles restartButton.Click
        occupancySum = 0
        numRoomsTextBox.Text = ""
        overallOccRateValLabel.Text = ""
        totalRoomOccupiedValLabel.Text = ""
        numRoomsTextBox.Focus()
        Floor = 1
        floorLabel.Text = 1
        dataListBox.Items.Clear()
        dataListBox.Text = String.Empty
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
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
