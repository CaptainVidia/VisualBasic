<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChange))
        Me.lblDollars = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblDollarsVal = New System.Windows.Forms.Label()
        Me.lblQuartersVal = New System.Windows.Forms.Label()
        Me.lblPenniesVal = New System.Windows.Forms.Label()
        Me.lblNickelsVal = New System.Windows.Forms.Label()
        Me.lblDimesVal = New System.Windows.Forms.Label()
        Me.lblChangeDueVal = New System.Windows.Forms.Label()
        Me.lblTenderedVal = New System.Windows.Forms.Label()
        Me.lblTotalVal = New System.Windows.Forms.Label()
        Me.lblTendered = New System.Windows.Forms.Label()
        Me.lblChangeDue = New System.Windows.Forms.Label()
        Me.lblTotalSale = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.picbxMoney = New System.Windows.Forms.PictureBox()
        CType(Me.picbxMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDollars
        '
        Me.lblDollars.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollars.Location = New System.Drawing.Point(443, 62)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(136, 37)
        Me.lblDollars.TabIndex = 0
        Me.lblDollars.Text = "Dollars:"
        '
        'lblQuarters
        '
        Me.lblQuarters.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarters.Location = New System.Drawing.Point(443, 112)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(136, 37)
        Me.lblQuarters.TabIndex = 1
        Me.lblQuarters.Text = "Quarters:"
        '
        'lblDimes
        '
        Me.lblDimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimes.Location = New System.Drawing.Point(443, 162)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(136, 37)
        Me.lblDimes.TabIndex = 2
        Me.lblDimes.Text = "Dimes:"
        '
        'lblPennies
        '
        Me.lblPennies.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPennies.Location = New System.Drawing.Point(443, 262)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(136, 37)
        Me.lblPennies.TabIndex = 3
        Me.lblPennies.Text = "Pennies:"
        '
        'lblNickels
        '
        Me.lblNickels.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNickels.Location = New System.Drawing.Point(443, 212)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(136, 37)
        Me.lblNickels.TabIndex = 4
        Me.lblNickels.Text = "Nickels:"
        '
        'lblDollarsVal
        '
        Me.lblDollarsVal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDollarsVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDollarsVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollarsVal.ForeColor = System.Drawing.Color.Lime
        Me.lblDollarsVal.Location = New System.Drawing.Point(585, 62)
        Me.lblDollarsVal.Name = "lblDollarsVal"
        Me.lblDollarsVal.Size = New System.Drawing.Size(206, 37)
        Me.lblDollarsVal.TabIndex = 5
        Me.lblDollarsVal.Text = "0.00"
        Me.lblDollarsVal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblQuartersVal
        '
        Me.lblQuartersVal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblQuartersVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuartersVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuartersVal.ForeColor = System.Drawing.Color.Lime
        Me.lblQuartersVal.Location = New System.Drawing.Point(585, 112)
        Me.lblQuartersVal.Name = "lblQuartersVal"
        Me.lblQuartersVal.Size = New System.Drawing.Size(206, 37)
        Me.lblQuartersVal.TabIndex = 6
        Me.lblQuartersVal.Text = "0.00"
        Me.lblQuartersVal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPenniesVal
        '
        Me.lblPenniesVal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPenniesVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPenniesVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenniesVal.ForeColor = System.Drawing.Color.Lime
        Me.lblPenniesVal.Location = New System.Drawing.Point(585, 262)
        Me.lblPenniesVal.Name = "lblPenniesVal"
        Me.lblPenniesVal.Size = New System.Drawing.Size(206, 37)
        Me.lblPenniesVal.TabIndex = 7
        Me.lblPenniesVal.Text = "0.00"
        Me.lblPenniesVal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNickelsVal
        '
        Me.lblNickelsVal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNickelsVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNickelsVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNickelsVal.ForeColor = System.Drawing.Color.Lime
        Me.lblNickelsVal.Location = New System.Drawing.Point(585, 212)
        Me.lblNickelsVal.Name = "lblNickelsVal"
        Me.lblNickelsVal.Size = New System.Drawing.Size(206, 37)
        Me.lblNickelsVal.TabIndex = 8
        Me.lblNickelsVal.Text = "0.00"
        Me.lblNickelsVal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDimesVal
        '
        Me.lblDimesVal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDimesVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDimesVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimesVal.ForeColor = System.Drawing.Color.Lime
        Me.lblDimesVal.Location = New System.Drawing.Point(585, 162)
        Me.lblDimesVal.Name = "lblDimesVal"
        Me.lblDimesVal.Size = New System.Drawing.Size(206, 37)
        Me.lblDimesVal.TabIndex = 9
        Me.lblDimesVal.Text = "0.00"
        Me.lblDimesVal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblChangeDueVal
        '
        Me.lblChangeDueVal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblChangeDueVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChangeDueVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeDueVal.ForeColor = System.Drawing.Color.Lime
        Me.lblChangeDueVal.Location = New System.Drawing.Point(196, 177)
        Me.lblChangeDueVal.Name = "lblChangeDueVal"
        Me.lblChangeDueVal.Size = New System.Drawing.Size(232, 37)
        Me.lblChangeDueVal.TabIndex = 10
        Me.lblChangeDueVal.Text = "0.00"
        Me.lblChangeDueVal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTenderedVal
        '
        Me.lblTenderedVal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTenderedVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTenderedVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenderedVal.ForeColor = System.Drawing.Color.Lime
        Me.lblTenderedVal.Location = New System.Drawing.Point(196, 62)
        Me.lblTenderedVal.Name = "lblTenderedVal"
        Me.lblTenderedVal.Size = New System.Drawing.Size(232, 37)
        Me.lblTenderedVal.TabIndex = 11
        Me.lblTenderedVal.Text = "0.00"
        Me.lblTenderedVal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalVal
        '
        Me.lblTotalVal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalVal.ForeColor = System.Drawing.Color.Lime
        Me.lblTotalVal.Location = New System.Drawing.Point(196, 121)
        Me.lblTotalVal.Name = "lblTotalVal"
        Me.lblTotalVal.Size = New System.Drawing.Size(232, 37)
        Me.lblTotalVal.TabIndex = 12
        Me.lblTotalVal.Text = "0.00"
        Me.lblTotalVal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTendered
        '
        Me.lblTendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTendered.Location = New System.Drawing.Point(26, 63)
        Me.lblTendered.Name = "lblTendered"
        Me.lblTendered.Size = New System.Drawing.Size(155, 37)
        Me.lblTendered.TabIndex = 13
        Me.lblTendered.Text = "Tendered:"
        '
        'lblChangeDue
        '
        Me.lblChangeDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeDue.Location = New System.Drawing.Point(4, 177)
        Me.lblChangeDue.Name = "lblChangeDue"
        Me.lblChangeDue.Size = New System.Drawing.Size(186, 37)
        Me.lblChangeDue.TabIndex = 14
        Me.lblChangeDue.Text = "Change Due: "
        '
        'lblTotalSale
        '
        Me.lblTotalSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSale.Location = New System.Drawing.Point(12, 121)
        Me.lblTotalSale.Name = "lblTotalSale"
        Me.lblTotalSale.Size = New System.Drawing.Size(169, 37)
        Me.lblTotalSale.TabIndex = 15
        Me.lblTotalSale.Text = "Total Sale:"
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(484, 366)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(95, 41)
        Me.btnNext.TabIndex = 16
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'picbxMoney
        '
        Me.picbxMoney.Image = CType(resources.GetObject("picbxMoney.Image"), System.Drawing.Image)
        Me.picbxMoney.Location = New System.Drawing.Point(196, 235)
        Me.picbxMoney.Margin = New System.Windows.Forms.Padding(6)
        Me.picbxMoney.Name = "picbxMoney"
        Me.picbxMoney.Size = New System.Drawing.Size(170, 210)
        Me.picbxMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbxMoney.TabIndex = 17
        Me.picbxMoney.TabStop = False
        '
        'frmChange
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.picbxMoney)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblTotalSale)
        Me.Controls.Add(Me.lblChangeDue)
        Me.Controls.Add(Me.lblTendered)
        Me.Controls.Add(Me.lblTotalVal)
        Me.Controls.Add(Me.lblTenderedVal)
        Me.Controls.Add(Me.lblChangeDueVal)
        Me.Controls.Add(Me.lblDimesVal)
        Me.Controls.Add(Me.lblNickelsVal)
        Me.Controls.Add(Me.lblPenniesVal)
        Me.Controls.Add(Me.lblQuartersVal)
        Me.Controls.Add(Me.lblDollarsVal)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblDollars)
        Me.Name = "frmChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AOT Jaeger Statue Change"
        CType(Me.picbxMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDollars As Label
    Friend WithEvents lblQuarters As Label
    Friend WithEvents lblDimes As Label
    Friend WithEvents lblPennies As Label
    Friend WithEvents lblNickels As Label
    Friend WithEvents lblDollarsVal As Label
    Friend WithEvents lblQuartersVal As Label
    Friend WithEvents lblPenniesVal As Label
    Friend WithEvents lblNickelsVal As Label
    Friend WithEvents lblDimesVal As Label
    Friend WithEvents lblChangeDueVal As Label
    Friend WithEvents lblTenderedVal As Label
    Friend WithEvents lblTotalVal As Label
    Friend WithEvents lblTendered As Label
    Friend WithEvents lblChangeDue As Label
    Friend WithEvents lblTotalSale As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents picbxMoney As PictureBox
End Class
