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
        Me.groupBoxAdultTicketSales = New System.Windows.Forms.GroupBox()
        Me.txtBoxTicketsSoldAdult = New System.Windows.Forms.TextBox()
        Me.lblTicketsSold = New System.Windows.Forms.Label()
        Me.txtBoxPricePerTicketAdult = New System.Windows.Forms.TextBox()
        Me.lblPricePerTicket = New System.Windows.Forms.Label()
        Me.groupBoxChildTicketSales = New System.Windows.Forms.GroupBox()
        Me.txtBoxTicketsSoldChild = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxPricePerTicketChild = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.groupBoxGrossTicketRevenue = New System.Windows.Forms.GroupBox()
        Me.lblTotalGrossRevPrint = New System.Windows.Forms.Label()
        Me.lblChildTicketSalesPrint = New System.Windows.Forms.Label()
        Me.lblAdultTicketSalesPrint = New System.Windows.Forms.Label()
        Me.lblTotalGrossRev = New System.Windows.Forms.Label()
        Me.lblChildTicketSales = New System.Windows.Forms.Label()
        Me.lblAdultTicketSales = New System.Windows.Forms.Label()
        Me.groupBoxNetTicketRev = New System.Windows.Forms.GroupBox()
        Me.lblAdultTicketSalesNetPrint = New System.Windows.Forms.Label()
        Me.lblTotalNetRevPrint = New System.Windows.Forms.Label()
        Me.lblChildTicketSalesNetPrint = New System.Windows.Forms.Label()
        Me.lblTotalNetRev = New System.Windows.Forms.Label()
        Me.lblNetChildTicketSales = New System.Windows.Forms.Label()
        Me.lblNetAdultTicketSales = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.groupBoxAdultTicketSales.SuspendLayout()
        Me.groupBoxChildTicketSales.SuspendLayout()
        Me.groupBoxGrossTicketRevenue.SuspendLayout()
        Me.groupBoxNetTicketRev.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBoxAdultTicketSales
        '
        Me.groupBoxAdultTicketSales.Controls.Add(Me.txtBoxTicketsSoldAdult)
        Me.groupBoxAdultTicketSales.Controls.Add(Me.lblTicketsSold)
        Me.groupBoxAdultTicketSales.Controls.Add(Me.txtBoxPricePerTicketAdult)
        Me.groupBoxAdultTicketSales.Controls.Add(Me.lblPricePerTicket)
        Me.groupBoxAdultTicketSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxAdultTicketSales.Location = New System.Drawing.Point(36, 43)
        Me.groupBoxAdultTicketSales.Name = "groupBoxAdultTicketSales"
        Me.groupBoxAdultTicketSales.Size = New System.Drawing.Size(308, 143)
        Me.groupBoxAdultTicketSales.TabIndex = 1
        Me.groupBoxAdultTicketSales.TabStop = False
        Me.groupBoxAdultTicketSales.Text = "Adult Ticket Sales"
        '
        'txtBoxTicketsSoldAdult
        '
        Me.txtBoxTicketsSoldAdult.Location = New System.Drawing.Point(181, 87)
        Me.txtBoxTicketsSoldAdult.Name = "txtBoxTicketsSoldAdult"
        Me.txtBoxTicketsSoldAdult.Size = New System.Drawing.Size(100, 26)
        Me.txtBoxTicketsSoldAdult.TabIndex = 2
        '
        'lblTicketsSold
        '
        Me.lblTicketsSold.AutoSize = True
        Me.lblTicketsSold.Location = New System.Drawing.Point(6, 87)
        Me.lblTicketsSold.Name = "lblTicketsSold"
        Me.lblTicketsSold.Size = New System.Drawing.Size(103, 20)
        Me.lblTicketsSold.TabIndex = 0
        Me.lblTicketsSold.Text = "Tickets Sold: "
        '
        'txtBoxPricePerTicketAdult
        '
        Me.txtBoxPricePerTicketAdult.Location = New System.Drawing.Point(181, 38)
        Me.txtBoxPricePerTicketAdult.Name = "txtBoxPricePerTicketAdult"
        Me.txtBoxPricePerTicketAdult.Size = New System.Drawing.Size(100, 26)
        Me.txtBoxPricePerTicketAdult.TabIndex = 1
        '
        'lblPricePerTicket
        '
        Me.lblPricePerTicket.AutoSize = True
        Me.lblPricePerTicket.Location = New System.Drawing.Point(6, 38)
        Me.lblPricePerTicket.Name = "lblPricePerTicket"
        Me.lblPricePerTicket.Size = New System.Drawing.Size(126, 20)
        Me.lblPricePerTicket.TabIndex = 0
        Me.lblPricePerTicket.Text = "Price Per Ticket: "
        '
        'groupBoxChildTicketSales
        '
        Me.groupBoxChildTicketSales.Controls.Add(Me.txtBoxTicketsSoldChild)
        Me.groupBoxChildTicketSales.Controls.Add(Me.Label1)
        Me.groupBoxChildTicketSales.Controls.Add(Me.txtBoxPricePerTicketChild)
        Me.groupBoxChildTicketSales.Controls.Add(Me.Label2)
        Me.groupBoxChildTicketSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxChildTicketSales.Location = New System.Drawing.Point(421, 43)
        Me.groupBoxChildTicketSales.Name = "groupBoxChildTicketSales"
        Me.groupBoxChildTicketSales.Size = New System.Drawing.Size(308, 143)
        Me.groupBoxChildTicketSales.TabIndex = 2
        Me.groupBoxChildTicketSales.TabStop = False
        Me.groupBoxChildTicketSales.Text = "Child Ticket Sales"
        '
        'txtBoxTicketsSoldChild
        '
        Me.txtBoxTicketsSoldChild.Location = New System.Drawing.Point(181, 87)
        Me.txtBoxTicketsSoldChild.Name = "txtBoxTicketsSoldChild"
        Me.txtBoxTicketsSoldChild.Size = New System.Drawing.Size(100, 26)
        Me.txtBoxTicketsSoldChild.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tickets Sold: "
        '
        'txtBoxPricePerTicketChild
        '
        Me.txtBoxPricePerTicketChild.Location = New System.Drawing.Point(181, 38)
        Me.txtBoxPricePerTicketChild.Name = "txtBoxPricePerTicketChild"
        Me.txtBoxPricePerTicketChild.Size = New System.Drawing.Size(100, 26)
        Me.txtBoxPricePerTicketChild.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Price Per Ticket: "
        '
        'groupBoxGrossTicketRevenue
        '
        Me.groupBoxGrossTicketRevenue.Controls.Add(Me.lblTotalGrossRevPrint)
        Me.groupBoxGrossTicketRevenue.Controls.Add(Me.lblChildTicketSalesPrint)
        Me.groupBoxGrossTicketRevenue.Controls.Add(Me.lblAdultTicketSalesPrint)
        Me.groupBoxGrossTicketRevenue.Controls.Add(Me.lblTotalGrossRev)
        Me.groupBoxGrossTicketRevenue.Controls.Add(Me.lblChildTicketSales)
        Me.groupBoxGrossTicketRevenue.Controls.Add(Me.lblAdultTicketSales)
        Me.groupBoxGrossTicketRevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxGrossTicketRevenue.Location = New System.Drawing.Point(36, 215)
        Me.groupBoxGrossTicketRevenue.Name = "groupBoxGrossTicketRevenue"
        Me.groupBoxGrossTicketRevenue.Size = New System.Drawing.Size(308, 185)
        Me.groupBoxGrossTicketRevenue.TabIndex = 4
        Me.groupBoxGrossTicketRevenue.TabStop = False
        Me.groupBoxGrossTicketRevenue.Text = "Gross Ticket Revenue"
        '
        'lblTotalGrossRevPrint
        '
        Me.lblTotalGrossRevPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalGrossRevPrint.Location = New System.Drawing.Point(169, 115)
        Me.lblTotalGrossRevPrint.Name = "lblTotalGrossRevPrint"
        Me.lblTotalGrossRevPrint.Size = New System.Drawing.Size(133, 26)
        Me.lblTotalGrossRevPrint.TabIndex = 7
        '
        'lblChildTicketSalesPrint
        '
        Me.lblChildTicketSalesPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChildTicketSalesPrint.Location = New System.Drawing.Point(169, 73)
        Me.lblChildTicketSalesPrint.Name = "lblChildTicketSalesPrint"
        Me.lblChildTicketSalesPrint.Size = New System.Drawing.Size(133, 26)
        Me.lblChildTicketSalesPrint.TabIndex = 6
        '
        'lblAdultTicketSalesPrint
        '
        Me.lblAdultTicketSalesPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdultTicketSalesPrint.Location = New System.Drawing.Point(169, 38)
        Me.lblAdultTicketSalesPrint.Name = "lblAdultTicketSalesPrint"
        Me.lblAdultTicketSalesPrint.Size = New System.Drawing.Size(133, 26)
        Me.lblAdultTicketSalesPrint.TabIndex = 5
        '
        'lblTotalGrossRev
        '
        Me.lblTotalGrossRev.Location = New System.Drawing.Point(6, 109)
        Me.lblTotalGrossRev.Name = "lblTotalGrossRev"
        Me.lblTotalGrossRev.Size = New System.Drawing.Size(164, 73)
        Me.lblTotalGrossRev.TabIndex = 4
        Me.lblTotalGrossRev.Text = "Total Gross Revenue for Ticker Sales: "
        '
        'lblChildTicketSales
        '
        Me.lblChildTicketSales.AutoSize = True
        Me.lblChildTicketSales.Location = New System.Drawing.Point(6, 79)
        Me.lblChildTicketSales.Name = "lblChildTicketSales"
        Me.lblChildTicketSales.Size = New System.Drawing.Size(142, 20)
        Me.lblChildTicketSales.TabIndex = 2
        Me.lblChildTicketSales.Text = "Child Ticket Sales: "
        '
        'lblAdultTicketSales
        '
        Me.lblAdultTicketSales.AutoSize = True
        Me.lblAdultTicketSales.Location = New System.Drawing.Point(6, 44)
        Me.lblAdultTicketSales.Name = "lblAdultTicketSales"
        Me.lblAdultTicketSales.Size = New System.Drawing.Size(140, 20)
        Me.lblAdultTicketSales.TabIndex = 0
        Me.lblAdultTicketSales.Text = "Adult Ticket Sales:"
        '
        'groupBoxNetTicketRev
        '
        Me.groupBoxNetTicketRev.Controls.Add(Me.lblAdultTicketSalesNetPrint)
        Me.groupBoxNetTicketRev.Controls.Add(Me.lblTotalNetRevPrint)
        Me.groupBoxNetTicketRev.Controls.Add(Me.lblChildTicketSalesNetPrint)
        Me.groupBoxNetTicketRev.Controls.Add(Me.lblTotalNetRev)
        Me.groupBoxNetTicketRev.Controls.Add(Me.lblNetChildTicketSales)
        Me.groupBoxNetTicketRev.Controls.Add(Me.lblNetAdultTicketSales)
        Me.groupBoxNetTicketRev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxNetTicketRev.Location = New System.Drawing.Point(421, 215)
        Me.groupBoxNetTicketRev.Name = "groupBoxNetTicketRev"
        Me.groupBoxNetTicketRev.Size = New System.Drawing.Size(308, 185)
        Me.groupBoxNetTicketRev.TabIndex = 4
        Me.groupBoxNetTicketRev.TabStop = False
        Me.groupBoxNetTicketRev.Text = "Net Ticket Revenue "
        '
        'lblAdultTicketSalesNetPrint
        '
        Me.lblAdultTicketSalesNetPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdultTicketSalesNetPrint.Location = New System.Drawing.Point(169, 38)
        Me.lblAdultTicketSalesNetPrint.Name = "lblAdultTicketSalesNetPrint"
        Me.lblAdultTicketSalesNetPrint.Size = New System.Drawing.Size(133, 26)
        Me.lblAdultTicketSalesNetPrint.TabIndex = 8
        '
        'lblTotalNetRevPrint
        '
        Me.lblTotalNetRevPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalNetRevPrint.Location = New System.Drawing.Point(169, 128)
        Me.lblTotalNetRevPrint.Name = "lblTotalNetRevPrint"
        Me.lblTotalNetRevPrint.Size = New System.Drawing.Size(133, 26)
        Me.lblTotalNetRevPrint.TabIndex = 7
        '
        'lblChildTicketSalesNetPrint
        '
        Me.lblChildTicketSalesNetPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChildTicketSalesNetPrint.Location = New System.Drawing.Point(169, 78)
        Me.lblChildTicketSalesNetPrint.Name = "lblChildTicketSalesNetPrint"
        Me.lblChildTicketSalesNetPrint.Size = New System.Drawing.Size(133, 26)
        Me.lblChildTicketSalesNetPrint.TabIndex = 6
        '
        'lblTotalNetRev
        '
        Me.lblTotalNetRev.Location = New System.Drawing.Point(6, 115)
        Me.lblTotalNetRev.Name = "lblTotalNetRev"
        Me.lblTotalNetRev.Size = New System.Drawing.Size(142, 67)
        Me.lblTotalNetRev.TabIndex = 4
        Me.lblTotalNetRev.Text = "Total Net Revenue for Ticket Sales: "
        '
        'lblNetChildTicketSales
        '
        Me.lblNetChildTicketSales.AutoSize = True
        Me.lblNetChildTicketSales.Location = New System.Drawing.Point(6, 79)
        Me.lblNetChildTicketSales.Name = "lblNetChildTicketSales"
        Me.lblNetChildTicketSales.Size = New System.Drawing.Size(142, 20)
        Me.lblNetChildTicketSales.TabIndex = 2
        Me.lblNetChildTicketSales.Text = "Child Ticket Sales: "
        '
        'lblNetAdultTicketSales
        '
        Me.lblNetAdultTicketSales.AutoSize = True
        Me.lblNetAdultTicketSales.Location = New System.Drawing.Point(6, 38)
        Me.lblNetAdultTicketSales.Name = "lblNetAdultTicketSales"
        Me.lblNetAdultTicketSales.Size = New System.Drawing.Size(144, 20)
        Me.lblNetAdultTicketSales.TabIndex = 0
        Me.lblNetAdultTicketSales.Text = "Adult Ticket Sales: "
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(36, 435)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(279, 69)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate Ticket Revenue"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(369, 435)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(139, 69)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(563, 435)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(139, 69)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 587)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.groupBoxNetTicketRev)
        Me.Controls.Add(Me.groupBoxGrossTicketRevenue)
        Me.Controls.Add(Me.groupBoxChildTicketSales)
        Me.Controls.Add(Me.groupBoxAdultTicketSales)
        Me.Name = "mainForm"
        Me.Text = "Theater Revenue"
        Me.groupBoxAdultTicketSales.ResumeLayout(False)
        Me.groupBoxAdultTicketSales.PerformLayout()
        Me.groupBoxChildTicketSales.ResumeLayout(False)
        Me.groupBoxChildTicketSales.PerformLayout()
        Me.groupBoxGrossTicketRevenue.ResumeLayout(False)
        Me.groupBoxGrossTicketRevenue.PerformLayout()
        Me.groupBoxNetTicketRev.ResumeLayout(False)
        Me.groupBoxNetTicketRev.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupBoxAdultTicketSales As GroupBox
    Friend WithEvents txtBoxTicketsSoldAdult As TextBox
    Friend WithEvents lblTicketsSold As Label
    Friend WithEvents txtBoxPricePerTicketAdult As TextBox
    Friend WithEvents lblPricePerTicket As Label
    Friend WithEvents groupBoxChildTicketSales As GroupBox
    Friend WithEvents txtBoxTicketsSoldChild As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxPricePerTicketChild As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents groupBoxGrossTicketRevenue As GroupBox
    Friend WithEvents lblTotalGrossRev As Label
    Friend WithEvents lblChildTicketSales As Label
    Friend WithEvents lblAdultTicketSales As Label
    Friend WithEvents groupBoxNetTicketRev As GroupBox
    Friend WithEvents lblTotalNetRev As Label
    Friend WithEvents lblNetChildTicketSales As Label
    Friend WithEvents lblNetAdultTicketSales As Label
    Friend WithEvents lblTotalGrossRevPrint As Label
    Friend WithEvents lblChildTicketSalesPrint As Label
    Friend WithEvents lblAdultTicketSalesPrint As Label
    Friend WithEvents lblAdultTicketSalesNetPrint As Label
    Friend WithEvents lblTotalNetRevPrint As Label
    Friend WithEvents lblChildTicketSalesNetPrint As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
