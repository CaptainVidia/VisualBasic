<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOS))
        Me.lblNetVal = New System.Windows.Forms.Label()
        Me.lblItemVal = New System.Windows.Forms.Label()
        Me.btnItem1 = New System.Windows.Forms.Button()
        Me.btnItem2 = New System.Windows.Forms.Button()
        Me.btnItem3 = New System.Windows.Forms.Button()
        Me.btnItem6 = New System.Windows.Forms.Button()
        Me.btnItem5 = New System.Windows.Forms.Button()
        Me.btnItem4 = New System.Windows.Forms.Button()
        Me.btnItem9 = New System.Windows.Forms.Button()
        Me.btnItem8 = New System.Windows.Forms.Button()
        Me.btnItem7 = New System.Windows.Forms.Button()
        Me.btnItem10 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.chkSubtract = New System.Windows.Forms.CheckBox()
        Me.lstItemsSold = New System.Windows.Forms.ListBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.ttpItem = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblAvaChar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNetVal
        '
        Me.lblNetVal.BackColor = System.Drawing.Color.Black
        Me.lblNetVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNetVal.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNetVal.Location = New System.Drawing.Point(732, 60)
        Me.lblNetVal.Name = "lblNetVal"
        Me.lblNetVal.Size = New System.Drawing.Size(191, 54)
        Me.lblNetVal.TabIndex = 0
        Me.lblNetVal.Text = "0.00"
        Me.lblNetVal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblItemVal
        '
        Me.lblItemVal.BackColor = System.Drawing.Color.Black
        Me.lblItemVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemVal.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblItemVal.Location = New System.Drawing.Point(732, 190)
        Me.lblItemVal.Name = "lblItemVal"
        Me.lblItemVal.Size = New System.Drawing.Size(191, 59)
        Me.lblItemVal.TabIndex = 1
        Me.lblItemVal.Text = "0.00"
        Me.lblItemVal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnItem1
        '
        Me.btnItem1.BackColor = System.Drawing.Color.White
        Me.btnItem1.BackgroundImage = CType(resources.GetObject("btnItem1.BackgroundImage"), System.Drawing.Image)
        Me.btnItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItem1.ForeColor = System.Drawing.Color.White
        Me.btnItem1.Location = New System.Drawing.Point(54, 88)
        Me.btnItem1.Name = "btnItem1"
        Me.btnItem1.Size = New System.Drawing.Size(128, 164)
        Me.btnItem1.TabIndex = 1
        Me.btnItem1.Tag = "1"
        Me.btnItem1.Text = "Mikasa Ackerman"
        Me.btnItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnItem1.UseVisualStyleBackColor = False
        '
        'btnItem2
        '
        Me.btnItem2.BackColor = System.Drawing.Color.White
        Me.btnItem2.BackgroundImage = CType(resources.GetObject("btnItem2.BackgroundImage"), System.Drawing.Image)
        Me.btnItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnItem2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItem2.ForeColor = System.Drawing.Color.White
        Me.btnItem2.Location = New System.Drawing.Point(111, 276)
        Me.btnItem2.Name = "btnItem2"
        Me.btnItem2.Size = New System.Drawing.Size(119, 169)
        Me.btnItem2.TabIndex = 2
        Me.btnItem2.Tag = "2"
        Me.btnItem2.Text = "Eren Yaeger"
        Me.btnItem2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnItem2.UseVisualStyleBackColor = False
        '
        'btnItem3
        '
        Me.btnItem3.BackColor = System.Drawing.Color.White
        Me.btnItem3.BackgroundImage = CType(resources.GetObject("btnItem3.BackgroundImage"), System.Drawing.Image)
        Me.btnItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnItem3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItem3.ForeColor = System.Drawing.Color.White
        Me.btnItem3.Location = New System.Drawing.Point(322, 88)
        Me.btnItem3.Name = "btnItem3"
        Me.btnItem3.Size = New System.Drawing.Size(122, 172)
        Me.btnItem3.TabIndex = 3
        Me.btnItem3.Tag = "3"
        Me.btnItem3.Text = "Levi Ackerman"
        Me.btnItem3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnItem3.UseVisualStyleBackColor = False
        '
        'btnItem6
        '
        Me.btnItem6.BackColor = System.Drawing.Color.Black
        Me.btnItem6.BackgroundImage = CType(resources.GetObject("btnItem6.BackgroundImage"), System.Drawing.Image)
        Me.btnItem6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnItem6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItem6.ForeColor = System.Drawing.Color.White
        Me.btnItem6.Location = New System.Drawing.Point(111, 451)
        Me.btnItem6.Name = "btnItem6"
        Me.btnItem6.Size = New System.Drawing.Size(119, 172)
        Me.btnItem6.TabIndex = 6
        Me.btnItem6.Tag = "6"
        Me.btnItem6.Text = "Annie Leonhardt"
        Me.btnItem6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnItem6.UseVisualStyleBackColor = False
        '
        'btnItem5
        '
        Me.btnItem5.BackColor = System.Drawing.Color.White
        Me.btnItem5.BackgroundImage = CType(resources.GetObject("btnItem5.BackgroundImage"), System.Drawing.Image)
        Me.btnItem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnItem5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItem5.ForeColor = System.Drawing.Color.White
        Me.btnItem5.Location = New System.Drawing.Point(239, 276)
        Me.btnItem5.Name = "btnItem5"
        Me.btnItem5.Size = New System.Drawing.Size(119, 169)
        Me.btnItem5.TabIndex = 5
        Me.btnItem5.Tag = "5"
        Me.btnItem5.Text = "Armin Arlert"
        Me.btnItem5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnItem5.UseVisualStyleBackColor = False
        '
        'btnItem4
        '
        Me.btnItem4.BackColor = System.Drawing.Color.Black
        Me.btnItem4.BackgroundImage = CType(resources.GetObject("btnItem4.BackgroundImage"), System.Drawing.Image)
        Me.btnItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnItem4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItem4.ForeColor = System.Drawing.Color.White
        Me.btnItem4.Location = New System.Drawing.Point(188, 88)
        Me.btnItem4.Name = "btnItem4"
        Me.btnItem4.Size = New System.Drawing.Size(128, 172)
        Me.btnItem4.TabIndex = 4
        Me.btnItem4.Tag = "4"
        Me.btnItem4.Text = "Hange Zoe"
        Me.btnItem4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnItem4.UseVisualStyleBackColor = False
        '
        'btnItem9
        '
        Me.btnItem9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnItem9.BackColor = System.Drawing.Color.Black
        Me.btnItem9.BackgroundImage = CType(resources.GetObject("btnItem9.BackgroundImage"), System.Drawing.Image)
        Me.btnItem9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnItem9.CausesValidation = False
        Me.btnItem9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItem9.ForeColor = System.Drawing.Color.White
        Me.btnItem9.Location = New System.Drawing.Point(188, 639)
        Me.btnItem9.Name = "btnItem9"
        Me.btnItem9.Size = New System.Drawing.Size(119, 172)
        Me.btnItem9.TabIndex = 9
        Me.btnItem9.Tag = "9"
        Me.btnItem9.Text = "Connie Springer"
        Me.btnItem9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnItem9.UseVisualStyleBackColor = False
        '
        'btnItem8
        '
        Me.btnItem8.BackColor = System.Drawing.Color.Black
        Me.btnItem8.BackgroundImage = CType(resources.GetObject("btnItem8.BackgroundImage"), System.Drawing.Image)
        Me.btnItem8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnItem8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItem8.ForeColor = System.Drawing.Color.White
        Me.btnItem8.Location = New System.Drawing.Point(60, 639)
        Me.btnItem8.Name = "btnItem8"
        Me.btnItem8.Size = New System.Drawing.Size(122, 177)
        Me.btnItem8.TabIndex = 8
        Me.btnItem8.Tag = "8"
        Me.btnItem8.Text = "Reiner Braun"
        Me.btnItem8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnItem8.UseVisualStyleBackColor = False
        '
        'btnItem7
        '
        Me.btnItem7.BackColor = System.Drawing.Color.White
        Me.btnItem7.BackgroundImage = CType(resources.GetObject("btnItem7.BackgroundImage"), System.Drawing.Image)
        Me.btnItem7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnItem7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItem7.ForeColor = System.Drawing.Color.White
        Me.btnItem7.Location = New System.Drawing.Point(239, 451)
        Me.btnItem7.Name = "btnItem7"
        Me.btnItem7.Size = New System.Drawing.Size(119, 172)
        Me.btnItem7.TabIndex = 7
        Me.btnItem7.Tag = "7"
        Me.btnItem7.Text = "Sasha Braus"
        Me.btnItem7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnItem7.UseVisualStyleBackColor = False
        '
        'btnItem10
        '
        Me.btnItem10.BackColor = System.Drawing.Color.Black
        Me.btnItem10.BackgroundImage = CType(resources.GetObject("btnItem10.BackgroundImage"), System.Drawing.Image)
        Me.btnItem10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnItem10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItem10.ForeColor = System.Drawing.Color.White
        Me.btnItem10.Location = New System.Drawing.Point(316, 639)
        Me.btnItem10.Name = "btnItem10"
        Me.btnItem10.Size = New System.Drawing.Size(119, 172)
        Me.btnItem10.TabIndex = 10
        Me.btnItem10.Tag = "10"
        Me.btnItem10.Text = "Petra Hall"
        Me.btnItem10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnItem10.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LawnGreen
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(799, 874)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(179, 95)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Tag = "12"
        Me.btnClear.Text = "&Clear" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'chkSubtract
        '
        Me.chkSubtract.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkSubtract.BackColor = System.Drawing.Color.LawnGreen
        Me.chkSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSubtract.Location = New System.Drawing.Point(605, 874)
        Me.chkSubtract.Name = "chkSubtract"
        Me.chkSubtract.Size = New System.Drawing.Size(179, 95)
        Me.chkSubtract.TabIndex = 11
        Me.chkSubtract.Tag = "11"
        Me.chkSubtract.Text = "&Subtract" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkSubtract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkSubtract.UseVisualStyleBackColor = False
        '
        'lstItemsSold
        '
        Me.lstItemsSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItemsSold.FormattingEnabled = True
        Me.lstItemsSold.ItemHeight = 20
        Me.lstItemsSold.Location = New System.Drawing.Point(732, 311)
        Me.lstItemsSold.Name = "lstItemsSold"
        Me.lstItemsSold.Size = New System.Drawing.Size(542, 484)
        Me.lstItemsSold.TabIndex = 15
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.LawnGreen
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(998, 874)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(179, 95)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Tag = "13"
        Me.btnNext.Text = "&Next" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblAvaChar
        '
        Me.lblAvaChar.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvaChar.Location = New System.Drawing.Point(53, 43)
        Me.lblAvaChar.Name = "lblAvaChar"
        Me.lblAvaChar.Size = New System.Drawing.Size(364, 42)
        Me.lblAvaChar.TabIndex = 16
        Me.lblAvaChar.Text = "Available Characters"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(725, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 42)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Item Price:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(734, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 42)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(725, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 42)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Shopping Cart:"
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1286, 1061)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAvaChar)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lstItemsSold)
        Me.Controls.Add(Me.chkSubtract)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnItem10)
        Me.Controls.Add(Me.btnItem9)
        Me.Controls.Add(Me.btnItem8)
        Me.Controls.Add(Me.btnItem7)
        Me.Controls.Add(Me.btnItem6)
        Me.Controls.Add(Me.btnItem5)
        Me.Controls.Add(Me.btnItem4)
        Me.Controls.Add(Me.btnItem3)
        Me.Controls.Add(Me.btnItem2)
        Me.Controls.Add(Me.btnItem1)
        Me.Controls.Add(Me.lblItemVal)
        Me.Controls.Add(Me.lblNetVal)
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "11"
        Me.Text = "AOT Jaeger Statue Sale"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNetVal As Label
    Friend WithEvents lblItemVal As Label
    Friend WithEvents btnItem1 As Button
    Friend WithEvents btnItem2 As Button
    Friend WithEvents btnItem3 As Button
    Friend WithEvents btnItem6 As Button
    Friend WithEvents btnItem5 As Button
    Friend WithEvents btnItem4 As Button
    Friend WithEvents btnItem9 As Button
    Friend WithEvents btnItem8 As Button
    Friend WithEvents btnItem7 As Button
    Friend WithEvents btnItem10 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents chkSubtract As CheckBox
    Friend WithEvents lstItemsSold As ListBox
    Friend WithEvents btnNext As Button
    Friend WithEvents ttpItem As ToolTip
    Friend WithEvents lblAvaChar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
