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
        Me.components = New System.ComponentModel.Container()
        Me.seatCheckBox = New System.Windows.Forms.CheckBox()
        Me.seat2CheckBox = New System.Windows.Forms.CheckBox()
        Me.SeatboxCheckbox3 = New System.Windows.Forms.CheckBox()
        Me.seatToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'seatCheckBox
        '
        Me.seatCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.seatCheckBox.BackColor = System.Drawing.Color.Fuchsia
        Me.seatCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.seatCheckBox.Location = New System.Drawing.Point(46, 72)
        Me.seatCheckBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.seatCheckBox.Name = "seatCheckBox"
        Me.seatCheckBox.Size = New System.Drawing.Size(173, 99)
        Me.seatCheckBox.TabIndex = 1
        Me.seatCheckBox.Tag = "1"
        Me.seatCheckBox.Text = "Seat"
        Me.seatCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.seatCheckBox.UseVisualStyleBackColor = False
        '
        'seat2CheckBox
        '
        Me.seat2CheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.seat2CheckBox.BackColor = System.Drawing.Color.Fuchsia
        Me.seat2CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.seat2CheckBox.Location = New System.Drawing.Point(294, 72)
        Me.seat2CheckBox.Margin = New System.Windows.Forms.Padding(6)
        Me.seat2CheckBox.Name = "seat2CheckBox"
        Me.seat2CheckBox.Size = New System.Drawing.Size(173, 99)
        Me.seat2CheckBox.TabIndex = 2
        Me.seat2CheckBox.Tag = "2"
        Me.seat2CheckBox.Text = "Seat"
        Me.seat2CheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.seat2CheckBox.UseVisualStyleBackColor = False
        '
        'SeatboxCheckbox3
        '
        Me.SeatboxCheckbox3.Appearance = System.Windows.Forms.Appearance.Button
        Me.SeatboxCheckbox3.BackColor = System.Drawing.Color.Fuchsia
        Me.SeatboxCheckbox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SeatboxCheckbox3.Location = New System.Drawing.Point(560, 72)
        Me.SeatboxCheckbox3.Margin = New System.Windows.Forms.Padding(6)
        Me.SeatboxCheckbox3.Name = "SeatboxCheckbox3"
        Me.SeatboxCheckbox3.Size = New System.Drawing.Size(173, 99)
        Me.SeatboxCheckbox3.TabIndex = 3
        Me.SeatboxCheckbox3.Tag = "3"
        Me.SeatboxCheckbox3.Text = "Seat"
        Me.SeatboxCheckbox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SeatboxCheckbox3.UseVisualStyleBackColor = False
        '
        'seatToolTip
        '
        Me.seatToolTip.AutoPopDelay = 5000
        Me.seatToolTip.InitialDelay = 200
        Me.seatToolTip.ReshowDelay = 1000
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 831)
        Me.Controls.Add(Me.SeatboxCheckbox3)
        Me.Controls.Add(Me.seat2CheckBox)
        Me.Controls.Add(Me.seatCheckBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "mainForm"
        Me.Text = "SampleArray"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents seatCheckBox As CheckBox
    Friend WithEvents seat2CheckBox As CheckBox
    Friend WithEvents SeatboxCheckbox3 As CheckBox
    Friend WithEvents seatToolTip As ToolTip
End Class
