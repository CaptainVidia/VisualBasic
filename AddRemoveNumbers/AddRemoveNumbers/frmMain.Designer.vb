<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblGenNumList = New System.Windows.Forms.Label()
        Me.lstShownNumbers = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstSelectedNumbers = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblMemberTotalVal = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAddNumbers = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGenNumList
        '
        Me.lblGenNumList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenNumList.Location = New System.Drawing.Point(31, 79)
        Me.lblGenNumList.Name = "lblGenNumList"
        Me.lblGenNumList.Size = New System.Drawing.Size(191, 23)
        Me.lblGenNumList.TabIndex = 0
        Me.lblGenNumList.Text = "General Number List"
        '
        'lstShownNumbers
        '
        Me.lstShownNumbers.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lstShownNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstShownNumbers.FormattingEnabled = True
        Me.lstShownNumbers.ItemHeight = 20
        Me.lstShownNumbers.Location = New System.Drawing.Point(34, 105)
        Me.lstShownNumbers.Name = "lstShownNumbers"
        Me.lstShownNumbers.Size = New System.Drawing.Size(202, 304)
        Me.lstShownNumbers.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FloralWhite
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(270, 193)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(136, 101)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lstSelectedNumbers
        '
        Me.lstSelectedNumbers.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lstSelectedNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSelectedNumbers.FormattingEnabled = True
        Me.lstSelectedNumbers.ItemHeight = 20
        Me.lstSelectedNumbers.Location = New System.Drawing.Point(458, 105)
        Me.lstSelectedNumbers.Name = "lstSelectedNumbers"
        Me.lstSelectedNumbers.Size = New System.Drawing.Size(202, 304)
        Me.lstSelectedNumbers.TabIndex = 3
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FloralWhite
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(716, 193)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(136, 101)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'lblMemberTotalVal
        '
        Me.lblMemberTotalVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMemberTotalVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberTotalVal.Location = New System.Drawing.Point(690, 386)
        Me.lblMemberTotalVal.Name = "lblMemberTotalVal"
        Me.lblMemberTotalVal.Size = New System.Drawing.Size(135, 23)
        Me.lblMemberTotalVal.TabIndex = 5
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Cornsilk
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(261, 479)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(145, 100)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Cornsilk
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(458, 479)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(145, 100)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblAddNumbers
        '
        Me.lblAddNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddNumbers.Location = New System.Drawing.Point(454, 79)
        Me.lblAddNumbers.Name = "lblAddNumbers"
        Me.lblAddNumbers.Size = New System.Drawing.Size(191, 23)
        Me.lblAddNumbers.TabIndex = 8
        Me.lblAddNumbers.Text = "Added Numbers"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(925, 691)
        Me.Controls.Add(Me.lblAddNumbers)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblMemberTotalVal)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lstSelectedNumbers)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstShownNumbers)
        Me.Controls.Add(Me.lblGenNumList)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phone Numbers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblGenNumList As Label
    Friend WithEvents lstShownNumbers As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lstSelectedNumbers As ListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblMemberTotalVal As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAddNumbers As Label
End Class
