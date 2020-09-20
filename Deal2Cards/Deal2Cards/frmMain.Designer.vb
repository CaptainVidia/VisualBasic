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
        Me.lblPlayerTotal = New System.Windows.Forms.Label()
        Me.lblPlayerTotalVal = New System.Windows.Forms.Label()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lstPlayer = New System.Windows.Forms.ListBox()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.lblDealerTotal = New System.Windows.Forms.Label()
        Me.lblDealer = New System.Windows.Forms.Label()
        Me.lblDealerName = New System.Windows.Forms.Label()
        Me.lblDealerTotalVal = New System.Windows.Forms.Label()
        Me.lstDealer = New System.Windows.Forms.ListBox()
        Me.btnDeal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEvaluate = New System.Windows.Forms.Button()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.lblPlayerWins = New System.Windows.Forms.Label()
        Me.lblPlayerWinsVal = New System.Windows.Forms.Label()
        Me.lblDealerWins = New System.Windows.Forms.Label()
        Me.lblDealerWinsVal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPlayerTotal
        '
        Me.lblPlayerTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerTotal.Location = New System.Drawing.Point(36, 303)
        Me.lblPlayerTotal.Name = "lblPlayerTotal"
        Me.lblPlayerTotal.Size = New System.Drawing.Size(114, 44)
        Me.lblPlayerTotal.TabIndex = 2
        Me.lblPlayerTotal.Text = "Player Total: "
        '
        'lblPlayerTotalVal
        '
        Me.lblPlayerTotalVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayerTotalVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerTotalVal.Location = New System.Drawing.Point(156, 303)
        Me.lblPlayerTotalVal.Name = "lblPlayerTotalVal"
        Me.lblPlayerTotalVal.Size = New System.Drawing.Size(114, 44)
        Me.lblPlayerTotalVal.TabIndex = 3
        '
        'lblPlayerName
        '
        Me.lblPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.Location = New System.Drawing.Point(40, 64)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(110, 30)
        Me.lblPlayerName.TabIndex = 2
        Me.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstPlayer
        '
        Me.lstPlayer.FormattingEnabled = True
        Me.lstPlayer.Location = New System.Drawing.Point(40, 127)
        Me.lstPlayer.Name = "lstPlayer"
        Me.lstPlayer.Size = New System.Drawing.Size(230, 173)
        Me.lstPlayer.TabIndex = 4
        '
        'lblPlayer
        '
        Me.lblPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.Location = New System.Drawing.Point(36, 27)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(114, 22)
        Me.lblPlayer.TabIndex = 2
        Me.lblPlayer.Text = "You: "
        '
        'lblDealerTotal
        '
        Me.lblDealerTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDealerTotal.Location = New System.Drawing.Point(519, 303)
        Me.lblDealerTotal.Name = "lblDealerTotal"
        Me.lblDealerTotal.Size = New System.Drawing.Size(114, 44)
        Me.lblDealerTotal.TabIndex = 2
        Me.lblDealerTotal.Text = "Dealer Total: "
        '
        'lblDealer
        '
        Me.lblDealer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDealer.Location = New System.Drawing.Point(519, 27)
        Me.lblDealer.Name = "lblDealer"
        Me.lblDealer.Size = New System.Drawing.Size(169, 22)
        Me.lblDealer.TabIndex = 2
        Me.lblDealer.Text = "Dealer: "
        '
        'lblDealerName
        '
        Me.lblDealerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDealerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDealerName.Location = New System.Drawing.Point(523, 64)
        Me.lblDealerName.Name = "lblDealerName"
        Me.lblDealerName.Size = New System.Drawing.Size(124, 30)
        Me.lblDealerName.TabIndex = 2
        Me.lblDealerName.Text = "Sonya Blade"
        Me.lblDealerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDealerTotalVal
        '
        Me.lblDealerTotalVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDealerTotalVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDealerTotalVal.Location = New System.Drawing.Point(639, 303)
        Me.lblDealerTotalVal.Name = "lblDealerTotalVal"
        Me.lblDealerTotalVal.Size = New System.Drawing.Size(114, 44)
        Me.lblDealerTotalVal.TabIndex = 3
        '
        'lstDealer
        '
        Me.lstDealer.FormattingEnabled = True
        Me.lstDealer.Location = New System.Drawing.Point(523, 127)
        Me.lstDealer.Name = "lstDealer"
        Me.lstDealer.Size = New System.Drawing.Size(230, 173)
        Me.lstDealer.TabIndex = 4
        '
        'btnDeal
        '
        Me.btnDeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeal.Location = New System.Drawing.Point(201, 539)
        Me.btnDeal.Name = "btnDeal"
        Me.btnDeal.Size = New System.Drawing.Size(138, 89)
        Me.btnDeal.TabIndex = 5
        Me.btnDeal.Text = "&Deal"
        Me.btnDeal.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(489, 539)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(138, 89)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(636, 539)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(138, 89)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnEvaluate
        '
        Me.btnEvaluate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvaluate.Location = New System.Drawing.Point(345, 539)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(138, 89)
        Me.btnEvaluate.TabIndex = 5
        Me.btnEvaluate.Text = "&Evaluate"
        Me.btnEvaluate.UseVisualStyleBackColor = True
        '
        'lblWinner
        '
        Me.lblWinner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.Location = New System.Drawing.Point(331, 193)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(138, 71)
        Me.lblWinner.TabIndex = 3
        '
        'lblPlayerWins
        '
        Me.lblPlayerWins.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerWins.Location = New System.Drawing.Point(36, 369)
        Me.lblPlayerWins.Name = "lblPlayerWins"
        Me.lblPlayerWins.Size = New System.Drawing.Size(114, 44)
        Me.lblPlayerWins.TabIndex = 2
        Me.lblPlayerWins.Text = "Wins: "
        '
        'lblPlayerWinsVal
        '
        Me.lblPlayerWinsVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayerWinsVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerWinsVal.Location = New System.Drawing.Point(156, 369)
        Me.lblPlayerWinsVal.Name = "lblPlayerWinsVal"
        Me.lblPlayerWinsVal.Size = New System.Drawing.Size(114, 44)
        Me.lblPlayerWinsVal.TabIndex = 3
        '
        'lblDealerWins
        '
        Me.lblDealerWins.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDealerWins.Location = New System.Drawing.Point(519, 359)
        Me.lblDealerWins.Name = "lblDealerWins"
        Me.lblDealerWins.Size = New System.Drawing.Size(114, 44)
        Me.lblDealerWins.TabIndex = 2
        Me.lblDealerWins.Text = "Wins:"
        '
        'lblDealerWinsVal
        '
        Me.lblDealerWinsVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDealerWinsVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDealerWinsVal.Location = New System.Drawing.Point(639, 359)
        Me.lblDealerWinsVal.Name = "lblDealerWinsVal"
        Me.lblDealerWinsVal.Size = New System.Drawing.Size(114, 44)
        Me.lblDealerWinsVal.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 711)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEvaluate)
        Me.Controls.Add(Me.btnDeal)
        Me.Controls.Add(Me.lstDealer)
        Me.Controls.Add(Me.lstPlayer)
        Me.Controls.Add(Me.lblDealerWinsVal)
        Me.Controls.Add(Me.lblDealerTotalVal)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.lblPlayerWinsVal)
        Me.Controls.Add(Me.lblPlayerTotalVal)
        Me.Controls.Add(Me.lblDealerName)
        Me.Controls.Add(Me.lblDealer)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.lblDealerWins)
        Me.Controls.Add(Me.lblDealerTotal)
        Me.Controls.Add(Me.lblPlayerWins)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.lblPlayerTotal)
        Me.Name = "frmMain"
        Me.Text = "Deal Two Cards"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPlayerTotal As Label
    Friend WithEvents lblPlayerTotalVal As Label
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents lstPlayer As ListBox
    Friend WithEvents lblPlayer As Label
    Friend WithEvents lblDealerTotal As Label
    Friend WithEvents lblDealer As Label
    Friend WithEvents lblDealerName As Label
    Friend WithEvents lblDealerTotalVal As Label
    Friend WithEvents lstDealer As ListBox
    Friend WithEvents btnDeal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnEvaluate As Button
    Friend WithEvents lblWinner As Label
    Friend WithEvents lblPlayerWins As Label
    Friend WithEvents lblPlayerWinsVal As Label
    Friend WithEvents lblDealerWins As Label
    Friend WithEvents lblDealerWinsVal As Label
End Class
