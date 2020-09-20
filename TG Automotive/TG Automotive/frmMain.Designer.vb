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
        Me.grpbxOilLub = New System.Windows.Forms.GroupBox()
        Me.lblLubeCost = New System.Windows.Forms.Label()
        Me.lblOilCost = New System.Windows.Forms.Label()
        Me.chkLube = New System.Windows.Forms.CheckBox()
        Me.chkOil = New System.Windows.Forms.CheckBox()
        Me.grpbxRadTrans = New System.Windows.Forms.GroupBox()
        Me.lblTransFlushCost = New System.Windows.Forms.Label()
        Me.lblRadFlushCost = New System.Windows.Forms.Label()
        Me.chkTransFlush = New System.Windows.Forms.CheckBox()
        Me.chkRadFlush = New System.Windows.Forms.CheckBox()
        Me.grpbxMisc = New System.Windows.Forms.GroupBox()
        Me.lblTireCost = New System.Windows.Forms.Label()
        Me.lblMufflerCost = New System.Windows.Forms.Label()
        Me.lblInspecCost = New System.Windows.Forms.Label()
        Me.chkTire = New System.Windows.Forms.CheckBox()
        Me.chkMuffler = New System.Windows.Forms.CheckBox()
        Me.chkInspection = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.grpbxPartsLabor = New System.Windows.Forms.GroupBox()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.lblLabor = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblParts = New System.Windows.Forms.Label()
        Me.lblDollar = New System.Windows.Forms.Label()
        Me.grpbxSumOfCharges = New System.Windows.Forms.GroupBox()
        Me.lblTotalFeesVal = New System.Windows.Forms.Label()
        Me.lblPartsSumVal = New System.Windows.Forms.Label()
        Me.lblTaxVal = New System.Windows.Forms.Label()
        Me.lblTotalFees = New System.Windows.Forms.Label()
        Me.lblSrvcLaborVal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblPartsSum = New System.Windows.Forms.Label()
        Me.lblSrcvLaborSum = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpbxOilLub.SuspendLayout()
        Me.grpbxRadTrans.SuspendLayout()
        Me.grpbxMisc.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpbxPartsLabor.SuspendLayout()
        Me.grpbxSumOfCharges.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbxOilLub
        '
        Me.grpbxOilLub.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpbxOilLub.Controls.Add(Me.lblLubeCost)
        Me.grpbxOilLub.Controls.Add(Me.lblOilCost)
        Me.grpbxOilLub.Controls.Add(Me.chkLube)
        Me.grpbxOilLub.Controls.Add(Me.chkOil)
        Me.grpbxOilLub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxOilLub.Location = New System.Drawing.Point(12, 12)
        Me.grpbxOilLub.Name = "grpbxOilLub"
        Me.grpbxOilLub.Size = New System.Drawing.Size(410, 171)
        Me.grpbxOilLub.TabIndex = 0
        Me.grpbxOilLub.TabStop = False
        Me.grpbxOilLub.Text = "&Oil and Lubrication"
        '
        'lblLubeCost
        '
        Me.lblLubeCost.Location = New System.Drawing.Point(221, 80)
        Me.lblLubeCost.Name = "lblLubeCost"
        Me.lblLubeCost.Size = New System.Drawing.Size(56, 30)
        Me.lblLubeCost.TabIndex = 3
        Me.lblLubeCost.Text = "$0.00"
        Me.lblLubeCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblOilCost
        '
        Me.lblOilCost.Location = New System.Drawing.Point(217, 44)
        Me.lblOilCost.Name = "lblOilCost"
        Me.lblOilCost.Size = New System.Drawing.Size(60, 30)
        Me.lblOilCost.TabIndex = 2
        Me.lblOilCost.Text = "$0.00"
        Me.lblOilCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkLube
        '
        Me.chkLube.Location = New System.Drawing.Point(6, 80)
        Me.chkLube.Name = "chkLube"
        Me.chkLube.Size = New System.Drawing.Size(150, 37)
        Me.chkLube.TabIndex = 1
        Me.chkLube.Text = "Lube Job"
        Me.chkLube.UseVisualStyleBackColor = True
        '
        'chkOil
        '
        Me.chkOil.Location = New System.Drawing.Point(6, 37)
        Me.chkOil.Name = "chkOil"
        Me.chkOil.Size = New System.Drawing.Size(150, 37)
        Me.chkOil.TabIndex = 0
        Me.chkOil.Text = "Oil Change"
        Me.chkOil.UseVisualStyleBackColor = True
        '
        'grpbxRadTrans
        '
        Me.grpbxRadTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpbxRadTrans.Controls.Add(Me.lblTransFlushCost)
        Me.grpbxRadTrans.Controls.Add(Me.lblRadFlushCost)
        Me.grpbxRadTrans.Controls.Add(Me.chkTransFlush)
        Me.grpbxRadTrans.Controls.Add(Me.chkRadFlush)
        Me.grpbxRadTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxRadTrans.Location = New System.Drawing.Point(508, 12)
        Me.grpbxRadTrans.Name = "grpbxRadTrans"
        Me.grpbxRadTrans.Size = New System.Drawing.Size(410, 171)
        Me.grpbxRadTrans.TabIndex = 1
        Me.grpbxRadTrans.TabStop = False
        Me.grpbxRadTrans.Text = "&Radiator and Transmission"
        '
        'lblTransFlushCost
        '
        Me.lblTransFlushCost.Location = New System.Drawing.Point(214, 80)
        Me.lblTransFlushCost.Name = "lblTransFlushCost"
        Me.lblTransFlushCost.Size = New System.Drawing.Size(63, 30)
        Me.lblTransFlushCost.TabIndex = 3
        Me.lblTransFlushCost.Text = "$0.00"
        Me.lblTransFlushCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRadFlushCost
        '
        Me.lblRadFlushCost.Location = New System.Drawing.Point(218, 44)
        Me.lblRadFlushCost.Name = "lblRadFlushCost"
        Me.lblRadFlushCost.Size = New System.Drawing.Size(59, 30)
        Me.lblRadFlushCost.TabIndex = 2
        Me.lblRadFlushCost.Text = "$0.00"
        Me.lblRadFlushCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkTransFlush
        '
        Me.chkTransFlush.Location = New System.Drawing.Point(6, 80)
        Me.chkTransFlush.Name = "chkTransFlush"
        Me.chkTransFlush.Size = New System.Drawing.Size(179, 37)
        Me.chkTransFlush.TabIndex = 1
        Me.chkTransFlush.Text = "Transmission Flush"
        Me.chkTransFlush.UseVisualStyleBackColor = True
        '
        'chkRadFlush
        '
        Me.chkRadFlush.Location = New System.Drawing.Point(6, 37)
        Me.chkRadFlush.Name = "chkRadFlush"
        Me.chkRadFlush.Size = New System.Drawing.Size(150, 37)
        Me.chkRadFlush.TabIndex = 0
        Me.chkRadFlush.Text = "Radiator Flush"
        Me.chkRadFlush.UseVisualStyleBackColor = True
        '
        'grpbxMisc
        '
        Me.grpbxMisc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpbxMisc.Controls.Add(Me.lblTireCost)
        Me.grpbxMisc.Controls.Add(Me.lblMufflerCost)
        Me.grpbxMisc.Controls.Add(Me.lblInspecCost)
        Me.grpbxMisc.Controls.Add(Me.chkTire)
        Me.grpbxMisc.Controls.Add(Me.chkMuffler)
        Me.grpbxMisc.Controls.Add(Me.chkInspection)
        Me.grpbxMisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxMisc.Location = New System.Drawing.Point(12, 225)
        Me.grpbxMisc.Name = "grpbxMisc"
        Me.grpbxMisc.Size = New System.Drawing.Size(410, 171)
        Me.grpbxMisc.TabIndex = 2
        Me.grpbxMisc.TabStop = False
        Me.grpbxMisc.Text = "&Miscellaneous"
        '
        'lblTireCost
        '
        Me.lblTireCost.Location = New System.Drawing.Point(214, 123)
        Me.lblTireCost.Name = "lblTireCost"
        Me.lblTireCost.Size = New System.Drawing.Size(63, 30)
        Me.lblTireCost.TabIndex = 5
        Me.lblTireCost.Text = "$0.00"
        Me.lblTireCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMufflerCost
        '
        Me.lblMufflerCost.Location = New System.Drawing.Point(214, 80)
        Me.lblMufflerCost.Name = "lblMufflerCost"
        Me.lblMufflerCost.Size = New System.Drawing.Size(63, 30)
        Me.lblMufflerCost.TabIndex = 4
        Me.lblMufflerCost.Text = "$0.00"
        Me.lblMufflerCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInspecCost
        '
        Me.lblInspecCost.Location = New System.Drawing.Point(218, 44)
        Me.lblInspecCost.Name = "lblInspecCost"
        Me.lblInspecCost.Size = New System.Drawing.Size(59, 30)
        Me.lblInspecCost.TabIndex = 3
        Me.lblInspecCost.Text = "$0.00"
        Me.lblInspecCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkTire
        '
        Me.chkTire.Location = New System.Drawing.Point(6, 116)
        Me.chkTire.Name = "chkTire"
        Me.chkTire.Size = New System.Drawing.Size(179, 37)
        Me.chkTire.TabIndex = 2
        Me.chkTire.Text = "Tire Roation"
        Me.chkTire.UseVisualStyleBackColor = True
        '
        'chkMuffler
        '
        Me.chkMuffler.Location = New System.Drawing.Point(6, 80)
        Me.chkMuffler.Name = "chkMuffler"
        Me.chkMuffler.Size = New System.Drawing.Size(179, 37)
        Me.chkMuffler.TabIndex = 1
        Me.chkMuffler.Text = "Replace Muffler"
        Me.chkMuffler.UseVisualStyleBackColor = True
        '
        'chkInspection
        '
        Me.chkInspection.Location = New System.Drawing.Point(6, 37)
        Me.chkInspection.Name = "chkInspection"
        Me.chkInspection.Size = New System.Drawing.Size(131, 37)
        Me.chkInspection.TabIndex = 0
        Me.chkInspection.Text = "Inspection"
        Me.chkInspection.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.CheckBox7)
        Me.GroupBox3.Controls.Add(Me.CheckBox8)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(508, 225)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(410, 171)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Radiator and Transmission"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(214, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 30)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "120.00"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(218, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 30)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "50.00"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CheckBox7
        '
        Me.CheckBox7.Location = New System.Drawing.Point(6, 80)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(179, 37)
        Me.CheckBox7.TabIndex = 0
        Me.CheckBox7.Text = "Transmission Flush"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.Location = New System.Drawing.Point(6, 37)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(150, 37)
        Me.CheckBox8.TabIndex = 0
        Me.CheckBox8.Text = "Radiator Flush"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'grpbxPartsLabor
        '
        Me.grpbxPartsLabor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpbxPartsLabor.Controls.Add(Me.txtLabor)
        Me.grpbxPartsLabor.Controls.Add(Me.txtParts)
        Me.grpbxPartsLabor.Controls.Add(Me.lblLabor)
        Me.grpbxPartsLabor.Controls.Add(Me.lblMinutes)
        Me.grpbxPartsLabor.Controls.Add(Me.lblParts)
        Me.grpbxPartsLabor.Controls.Add(Me.lblDollar)
        Me.grpbxPartsLabor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxPartsLabor.Location = New System.Drawing.Point(508, 225)
        Me.grpbxPartsLabor.Name = "grpbxPartsLabor"
        Me.grpbxPartsLabor.Size = New System.Drawing.Size(410, 171)
        Me.grpbxPartsLabor.TabIndex = 3
        Me.grpbxPartsLabor.TabStop = False
        Me.grpbxPartsLabor.Text = "&Parts and Labor"
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(156, 84)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(100, 26)
        Me.txtLabor.TabIndex = 3
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(156, 34)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(100, 26)
        Me.txtParts.TabIndex = 2
        '
        'lblLabor
        '
        Me.lblLabor.Location = New System.Drawing.Point(28, 87)
        Me.lblLabor.Name = "lblLabor"
        Me.lblLabor.Size = New System.Drawing.Size(63, 30)
        Me.lblLabor.TabIndex = 1
        Me.lblLabor.Text = "Labor"
        Me.lblLabor.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMinutes
        '
        Me.lblMinutes.Location = New System.Drawing.Point(283, 87)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(69, 30)
        Me.lblMinutes.TabIndex = 5
        Me.lblMinutes.Text = "minutes"
        Me.lblMinutes.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblParts
        '
        Me.lblParts.Location = New System.Drawing.Point(28, 37)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(59, 30)
        Me.lblParts.TabIndex = 0
        Me.lblParts.Text = "Parts"
        Me.lblParts.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDollar
        '
        Me.lblDollar.Location = New System.Drawing.Point(293, 37)
        Me.lblDollar.Name = "lblDollar"
        Me.lblDollar.Size = New System.Drawing.Size(59, 30)
        Me.lblDollar.TabIndex = 4
        Me.lblDollar.Text = "dollars"
        Me.lblDollar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grpbxSumOfCharges
        '
        Me.grpbxSumOfCharges.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpbxSumOfCharges.Controls.Add(Me.lblTotalFeesVal)
        Me.grpbxSumOfCharges.Controls.Add(Me.lblPartsSumVal)
        Me.grpbxSumOfCharges.Controls.Add(Me.lblTaxVal)
        Me.grpbxSumOfCharges.Controls.Add(Me.lblTotalFees)
        Me.grpbxSumOfCharges.Controls.Add(Me.lblSrvcLaborVal)
        Me.grpbxSumOfCharges.Controls.Add(Me.lblTax)
        Me.grpbxSumOfCharges.Controls.Add(Me.lblPartsSum)
        Me.grpbxSumOfCharges.Controls.Add(Me.lblSrcvLaborSum)
        Me.grpbxSumOfCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxSumOfCharges.Location = New System.Drawing.Point(12, 424)
        Me.grpbxSumOfCharges.Name = "grpbxSumOfCharges"
        Me.grpbxSumOfCharges.Size = New System.Drawing.Size(906, 171)
        Me.grpbxSumOfCharges.TabIndex = 7
        Me.grpbxSumOfCharges.TabStop = False
        Me.grpbxSumOfCharges.Text = "Summary of Charges"
        '
        'lblTotalFeesVal
        '
        Me.lblTotalFeesVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalFeesVal.Location = New System.Drawing.Point(671, 96)
        Me.lblTotalFeesVal.Name = "lblTotalFeesVal"
        Me.lblTotalFeesVal.Size = New System.Drawing.Size(177, 30)
        Me.lblTotalFeesVal.TabIndex = 7
        '
        'lblPartsSumVal
        '
        Me.lblPartsSumVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPartsSumVal.Location = New System.Drawing.Point(165, 96)
        Me.lblPartsSumVal.Name = "lblPartsSumVal"
        Me.lblPartsSumVal.Size = New System.Drawing.Size(177, 30)
        Me.lblPartsSumVal.TabIndex = 3
        '
        'lblTaxVal
        '
        Me.lblTaxVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTaxVal.Location = New System.Drawing.Point(671, 45)
        Me.lblTaxVal.Name = "lblTaxVal"
        Me.lblTaxVal.Size = New System.Drawing.Size(177, 30)
        Me.lblTaxVal.TabIndex = 6
        '
        'lblTotalFees
        '
        Me.lblTotalFees.Location = New System.Drawing.Point(514, 97)
        Me.lblTotalFees.Name = "lblTotalFees"
        Me.lblTotalFees.Size = New System.Drawing.Size(151, 30)
        Me.lblTotalFees.TabIndex = 5
        Me.lblTotalFees.Text = "Total Fees"
        Me.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSrvcLaborVal
        '
        Me.lblSrvcLaborVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSrvcLaborVal.Location = New System.Drawing.Point(165, 45)
        Me.lblSrvcLaborVal.Name = "lblSrvcLaborVal"
        Me.lblSrvcLaborVal.Size = New System.Drawing.Size(177, 30)
        Me.lblSrvcLaborVal.TabIndex = 2
        '
        'lblTax
        '
        Me.lblTax.Location = New System.Drawing.Point(514, 46)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(148, 30)
        Me.lblTax.TabIndex = 4
        Me.lblTax.Text = "Tax (on parts)"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPartsSum
        '
        Me.lblPartsSum.Location = New System.Drawing.Point(8, 97)
        Me.lblPartsSum.Name = "lblPartsSum"
        Me.lblPartsSum.Size = New System.Drawing.Size(151, 30)
        Me.lblPartsSum.TabIndex = 1
        Me.lblPartsSum.Text = "Parts"
        Me.lblPartsSum.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSrcvLaborSum
        '
        Me.lblSrcvLaborSum.Location = New System.Drawing.Point(8, 46)
        Me.lblSrcvLaborSum.Name = "lblSrcvLaborSum"
        Me.lblSrcvLaborSum.Size = New System.Drawing.Size(148, 30)
        Me.lblSrcvLaborSum.TabIndex = 0
        Me.lblSrcvLaborSum.Text = "Services and Labor"
        Me.lblSrcvLaborSum.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(154, 621)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(158, 65)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "C&alculate Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(374, 621)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(158, 65)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(606, 621)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(158, 65)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(991, 698)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpbxSumOfCharges)
        Me.Controls.Add(Me.grpbxPartsLabor)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpbxMisc)
        Me.Controls.Add(Me.grpbxRadTrans)
        Me.Controls.Add(Me.grpbxOilLub)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TG Automotive"
        Me.grpbxOilLub.ResumeLayout(False)
        Me.grpbxRadTrans.ResumeLayout(False)
        Me.grpbxMisc.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.grpbxPartsLabor.ResumeLayout(False)
        Me.grpbxPartsLabor.PerformLayout()
        Me.grpbxSumOfCharges.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpbxOilLub As GroupBox
    Friend WithEvents lblLubeCost As Label
    Friend WithEvents lblOilCost As Label
    Friend WithEvents chkLube As CheckBox
    Friend WithEvents chkOil As CheckBox
    Friend WithEvents grpbxRadTrans As GroupBox
    Friend WithEvents lblTransFlushCost As Label
    Friend WithEvents lblRadFlushCost As Label
    Friend WithEvents chkTransFlush As CheckBox
    Friend WithEvents chkRadFlush As CheckBox
    Friend WithEvents grpbxMisc As GroupBox
    Friend WithEvents lblTireCost As Label
    Friend WithEvents lblMufflerCost As Label
    Friend WithEvents lblInspecCost As Label
    Friend WithEvents chkTire As CheckBox
    Friend WithEvents chkMuffler As CheckBox
    Friend WithEvents chkInspection As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents grpbxPartsLabor As GroupBox
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblDollar As Label
    Friend WithEvents grpbxSumOfCharges As GroupBox
    Friend WithEvents lblSrcvLaborSum As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtLabor As TextBox
    Friend WithEvents txtParts As TextBox
    Friend WithEvents lblLabor As Label
    Friend WithEvents lblParts As Label
    Friend WithEvents lblTotalFeesVal As Label
    Friend WithEvents lblPartsSumVal As Label
    Friend WithEvents lblTaxVal As Label
    Friend WithEvents lblTotalFees As Label
    Friend WithEvents lblSrvcLaborVal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblPartsSum As Label
End Class
