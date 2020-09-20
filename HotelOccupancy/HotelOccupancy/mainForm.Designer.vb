<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.numRoomsTextBox = New System.Windows.Forms.TextBox()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.numRoomsLabel = New System.Windows.Forms.Label()
        Me.thirtyRoomsLabel = New System.Windows.Forms.Label()
        Me.floorTitleLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.overallOccRateValLabel = New System.Windows.Forms.Label()
        Me.overallOccRateLabel = New System.Windows.Forms.Label()
        Me.totalRoomOccupiedValLabel = New System.Windows.Forms.Label()
        Me.totalRoomsOccupiedLabel = New System.Windows.Forms.Label()
        Me.dataListBox = New System.Windows.Forms.ListBox()
        Me.restartButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.floorLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.floorLabel)
        Me.GroupBox1.Controls.Add(Me.numRoomsTextBox)
        Me.GroupBox1.Controls.Add(Me.saveButton)
        Me.GroupBox1.Controls.Add(Me.numRoomsLabel)
        Me.GroupBox1.Controls.Add(Me.thirtyRoomsLabel)
        Me.GroupBox1.Controls.Add(Me.floorTitleLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(771, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter the occupancy rate for each floor"
        '
        'numRoomsTextBox
        '
        Me.numRoomsTextBox.Location = New System.Drawing.Point(476, 64)
        Me.numRoomsTextBox.Name = "numRoomsTextBox"
        Me.numRoomsTextBox.Size = New System.Drawing.Size(100, 26)
        Me.numRoomsTextBox.TabIndex = 4
        '
        'saveButton
        '
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.Location = New System.Drawing.Point(421, 100)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(128, 33)
        Me.saveButton.TabIndex = 3
        Me.saveButton.Text = "&Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'numRoomsLabel
        '
        Me.numRoomsLabel.Location = New System.Drawing.Point(291, 64)
        Me.numRoomsLabel.Name = "numRoomsLabel"
        Me.numRoomsLabel.Size = New System.Drawing.Size(199, 23)
        Me.numRoomsLabel.TabIndex = 3
        Me.numRoomsLabel.Text = "Number of Rooms = 30"
        '
        'thirtyRoomsLabel
        '
        Me.thirtyRoomsLabel.Location = New System.Drawing.Point(25, 100)
        Me.thirtyRoomsLabel.Name = "thirtyRoomsLabel"
        Me.thirtyRoomsLabel.Size = New System.Drawing.Size(189, 23)
        Me.thirtyRoomsLabel.TabIndex = 2
        Me.thirtyRoomsLabel.Text = "Number of Rooms = 30"
        '
        'floorTitleLabel
        '
        Me.floorTitleLabel.Location = New System.Drawing.Point(25, 37)
        Me.floorTitleLabel.Name = "floorTitleLabel"
        Me.floorTitleLabel.Size = New System.Drawing.Size(133, 23)
        Me.floorTitleLabel.TabIndex = 0
        Me.floorTitleLabel.Text = "Select the Floor:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.overallOccRateValLabel)
        Me.GroupBox2.Controls.Add(Me.overallOccRateLabel)
        Me.GroupBox2.Controls.Add(Me.totalRoomOccupiedValLabel)
        Me.GroupBox2.Controls.Add(Me.totalRoomsOccupiedLabel)
        Me.GroupBox2.Controls.Add(Me.dataListBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(771, 312)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Floor Occupancy Data"
        '
        'overallOccRateValLabel
        '
        Me.overallOccRateValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.overallOccRateValLabel.Location = New System.Drawing.Point(576, 256)
        Me.overallOccRateValLabel.Name = "overallOccRateValLabel"
        Me.overallOccRateValLabel.Size = New System.Drawing.Size(102, 23)
        Me.overallOccRateValLabel.TabIndex = 6
        '
        'overallOccRateLabel
        '
        Me.overallOccRateLabel.Location = New System.Drawing.Point(383, 257)
        Me.overallOccRateLabel.Name = "overallOccRateLabel"
        Me.overallOccRateLabel.Size = New System.Drawing.Size(203, 23)
        Me.overallOccRateLabel.TabIndex = 7
        Me.overallOccRateLabel.Text = "Overall Occupancy Rate:"
        '
        'totalRoomOccupiedValLabel
        '
        Me.totalRoomOccupiedValLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalRoomOccupiedValLabel.Location = New System.Drawing.Point(210, 256)
        Me.totalRoomOccupiedValLabel.Name = "totalRoomOccupiedValLabel"
        Me.totalRoomOccupiedValLabel.Size = New System.Drawing.Size(102, 23)
        Me.totalRoomOccupiedValLabel.TabIndex = 4
        '
        'totalRoomsOccupiedLabel
        '
        Me.totalRoomsOccupiedLabel.Location = New System.Drawing.Point(11, 258)
        Me.totalRoomsOccupiedLabel.Name = "totalRoomsOccupiedLabel"
        Me.totalRoomsOccupiedLabel.Size = New System.Drawing.Size(182, 23)
        Me.totalRoomsOccupiedLabel.TabIndex = 5
        Me.totalRoomsOccupiedLabel.Text = "Total Rooms Occupied: "
        '
        'dataListBox
        '
        Me.dataListBox.FormattingEnabled = True
        Me.dataListBox.ItemHeight = 20
        Me.dataListBox.Location = New System.Drawing.Point(6, 29)
        Me.dataListBox.Name = "dataListBox"
        Me.dataListBox.Size = New System.Drawing.Size(745, 184)
        Me.dataListBox.TabIndex = 3
        '
        'restartButton
        '
        Me.restartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restartButton.Location = New System.Drawing.Point(100, 535)
        Me.restartButton.Name = "restartButton"
        Me.restartButton.Size = New System.Drawing.Size(128, 71)
        Me.restartButton.TabIndex = 1
        Me.restartButton.Text = "&Restart"
        Me.restartButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(449, 535)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(128, 71)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'floorLabel
        '
        Me.floorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.floorLabel.Location = New System.Drawing.Point(164, 37)
        Me.floorLabel.Name = "floorLabel"
        Me.floorLabel.Size = New System.Drawing.Size(133, 23)
        Me.floorLabel.TabIndex = 5
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 631)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.restartButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "mainForm"
        Me.Text = "HotelOccupancy"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents numRoomsLabel As Label
    Friend WithEvents thirtyRoomsLabel As Label
    Friend WithEvents floorTitleLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents totalRoomOccupiedValLabel As Label
    Friend WithEvents totalRoomsOccupiedLabel As Label
    Friend WithEvents dataListBox As ListBox
    Friend WithEvents numRoomsTextBox As TextBox
    Friend WithEvents saveButton As Button
    Friend WithEvents overallOccRateValLabel As Label
    Friend WithEvents overallOccRateLabel As Label
    Friend WithEvents restartButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents floorLabel As Label
End Class
