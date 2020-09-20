<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSinster = New System.Windows.Forms.Button()
        Me.btnDexter = New System.Windows.Forms.Button()
        Me.btnMedium = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTranslate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSinster
        '
        Me.btnSinster.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.btnSinster.Location = New System.Drawing.Point(126, 378)
        Me.btnSinster.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSinster.Name = "btnSinster"
        Me.btnSinster.Size = New System.Drawing.Size(147, 71)
        Me.btnSinster.TabIndex = 0
        Me.btnSinster.Text = "Sinster"
        Me.btnSinster.UseVisualStyleBackColor = True
        '
        'btnDexter
        '
        Me.btnDexter.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.btnDexter.Location = New System.Drawing.Point(314, 378)
        Me.btnDexter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDexter.Name = "btnDexter"
        Me.btnDexter.Size = New System.Drawing.Size(147, 71)
        Me.btnDexter.TabIndex = 1
        Me.btnDexter.Text = "Dexter"
        Me.btnDexter.UseVisualStyleBackColor = True
        '
        'btnMedium
        '
        Me.btnMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.btnMedium.Location = New System.Drawing.Point(492, 378)
        Me.btnMedium.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(147, 71)
        Me.btnMedium.TabIndex = 2
        Me.btnMedium.Text = "Medium"
        Me.btnMedium.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(226, 479)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(147, 71)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(411, 479)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(147, 71)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTranslate
        '
        Me.lblTranslate.BackColor = System.Drawing.SystemColors.Control
        Me.lblTranslate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTranslate.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.lblTranslate.Location = New System.Drawing.Point(301, 216)
        Me.lblTranslate.Name = "lblTranslate"
        Me.lblTranslate.Size = New System.Drawing.Size(171, 44)
        Me.lblTranslate.TabIndex = 11
        Me.lblTranslate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 590)
        Me.Controls.Add(Me.lblTranslate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMedium)
        Me.Controls.Add(Me.btnDexter)
        Me.Controls.Add(Me.btnSinster)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "LatinTranslate"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSinster As Button
    Friend WithEvents btnDexter As Button
    Friend WithEvents btnMedium As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTranslate As Label
End Class
