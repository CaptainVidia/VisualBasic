<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splashScreen))
        Me.weeklyTemperatureAverageLabel = New System.Windows.Forms.Label()
        Me.myNameLabel = New System.Windows.Forms.Label()
        Me.timerData = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'weeklyTemperatureAverageLabel
        '
        Me.weeklyTemperatureAverageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weeklyTemperatureAverageLabel.Location = New System.Drawing.Point(12, 67)
        Me.weeklyTemperatureAverageLabel.Name = "weeklyTemperatureAverageLabel"
        Me.weeklyTemperatureAverageLabel.Size = New System.Drawing.Size(297, 43)
        Me.weeklyTemperatureAverageLabel.TabIndex = 0
        Me.weeklyTemperatureAverageLabel.Text = "Weekly Temperature Average"
        '
        'myNameLabel
        '
        Me.myNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myNameLabel.Location = New System.Drawing.Point(556, 67)
        Me.myNameLabel.Name = "myNameLabel"
        Me.myNameLabel.Size = New System.Drawing.Size(147, 43)
        Me.myNameLabel.TabIndex = 1
        Me.myNameLabel.Text = "G.Tang"
        '
        'timerData
        '
        Me.timerData.Enabled = True
        Me.timerData.Interval = 3000
        '
        'splashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.myNameLabel)
        Me.Controls.Add(Me.weeklyTemperatureAverageLabel)
        Me.Name = "splashScreen"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents weeklyTemperatureAverageLabel As Label
    Friend WithEvents myNameLabel As Label
    Friend WithEvents timerData As Timer
End Class
