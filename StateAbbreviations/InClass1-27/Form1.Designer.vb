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
        Me.btnVirginia = New System.Windows.Forms.Button()
        Me.btnNorthCarolina = New System.Windows.Forms.Button()
        Me.btnSouthCarolina = New System.Windows.Forms.Button()
        Me.btnGeorgia = New System.Windows.Forms.Button()
        Me.btnAlabama = New System.Windows.Forms.Button()
        Me.btnFlorida = New System.Windows.Forms.Button()
        Me.lblStateAbbreviation = New System.Windows.Forms.Label()
        Me.txtboxStateAbbreviation = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVirginia
        '
        Me.btnVirginia.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnVirginia.Location = New System.Drawing.Point(27, 12)
        Me.btnVirginia.Name = "btnVirginia"
        Me.btnVirginia.Size = New System.Drawing.Size(181, 53)
        Me.btnVirginia.TabIndex = 0
        Me.btnVirginia.Text = "Virginia"
        Me.btnVirginia.UseVisualStyleBackColor = True
        '
        'btnNorthCarolina
        '
        Me.btnNorthCarolina.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnNorthCarolina.Location = New System.Drawing.Point(27, 71)
        Me.btnNorthCarolina.Name = "btnNorthCarolina"
        Me.btnNorthCarolina.Size = New System.Drawing.Size(181, 52)
        Me.btnNorthCarolina.TabIndex = 1
        Me.btnNorthCarolina.Text = "North Carolina"
        Me.btnNorthCarolina.UseVisualStyleBackColor = True
        '
        'btnSouthCarolina
        '
        Me.btnSouthCarolina.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnSouthCarolina.Location = New System.Drawing.Point(27, 129)
        Me.btnSouthCarolina.Name = "btnSouthCarolina"
        Me.btnSouthCarolina.Size = New System.Drawing.Size(181, 63)
        Me.btnSouthCarolina.TabIndex = 2
        Me.btnSouthCarolina.Text = "South Carolina"
        Me.btnSouthCarolina.UseVisualStyleBackColor = True
        '
        'btnGeorgia
        '
        Me.btnGeorgia.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnGeorgia.Location = New System.Drawing.Point(27, 198)
        Me.btnGeorgia.Name = "btnGeorgia"
        Me.btnGeorgia.Size = New System.Drawing.Size(181, 66)
        Me.btnGeorgia.TabIndex = 3
        Me.btnGeorgia.Text = "Georgia"
        Me.btnGeorgia.UseVisualStyleBackColor = True
        '
        'btnAlabama
        '
        Me.btnAlabama.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnAlabama.Location = New System.Drawing.Point(27, 270)
        Me.btnAlabama.Name = "btnAlabama"
        Me.btnAlabama.Size = New System.Drawing.Size(181, 68)
        Me.btnAlabama.TabIndex = 4
        Me.btnAlabama.Text = "Alabama"
        Me.btnAlabama.UseVisualStyleBackColor = True
        '
        'btnFlorida
        '
        Me.btnFlorida.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnFlorida.Location = New System.Drawing.Point(27, 344)
        Me.btnFlorida.Name = "btnFlorida"
        Me.btnFlorida.Size = New System.Drawing.Size(181, 75)
        Me.btnFlorida.TabIndex = 5
        Me.btnFlorida.Text = "Florida"
        Me.btnFlorida.UseVisualStyleBackColor = True
        '
        'lblStateAbbreviation
        '
        Me.lblStateAbbreviation.AutoSize = True
        Me.lblStateAbbreviation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblStateAbbreviation.Location = New System.Drawing.Point(440, 141)
        Me.lblStateAbbreviation.Name = "lblStateAbbreviation"
        Me.lblStateAbbreviation.Size = New System.Drawing.Size(202, 26)
        Me.lblStateAbbreviation.TabIndex = 6
        Me.lblStateAbbreviation.Text = "State Abbreviation: "
        '
        'txtboxStateAbbreviation
        '
        Me.txtboxStateAbbreviation.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.txtboxStateAbbreviation.Location = New System.Drawing.Point(445, 187)
        Me.txtboxStateAbbreviation.Name = "txtboxStateAbbreviation"
        Me.txtboxStateAbbreviation.Size = New System.Drawing.Size(185, 44)
        Me.txtboxStateAbbreviation.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Button1.Location = New System.Drawing.Point(409, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 68)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Button2.Location = New System.Drawing.Point(567, 351)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 68)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtboxStateAbbreviation)
        Me.Controls.Add(Me.lblStateAbbreviation)
        Me.Controls.Add(Me.btnFlorida)
        Me.Controls.Add(Me.btnAlabama)
        Me.Controls.Add(Me.btnGeorgia)
        Me.Controls.Add(Me.btnSouthCarolina)
        Me.Controls.Add(Me.btnNorthCarolina)
        Me.Controls.Add(Me.btnVirginia)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVirginia As Button
    Friend WithEvents btnNorthCarolina As Button
    Friend WithEvents btnSouthCarolina As Button
    Friend WithEvents btnGeorgia As Button
    Friend WithEvents btnAlabama As Button
    Friend WithEvents btnFlorida As Button
    Friend WithEvents lblStateAbbreviation As Label
    Friend WithEvents txtboxStateAbbreviation As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
