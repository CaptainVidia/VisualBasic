<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceipt
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
        Me.btnNew = New System.Windows.Forms.Button()
        Me.pdoc = New System.Drawing.Printing.PrintDocument()
        Me.txtDocument = New System.Windows.Forms.TextBox()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnDialog = New System.Windows.Forms.Button()
        Me.btnPage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.LawnGreen
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(464, 383)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(113, 55)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&New Sale"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'pdoc
        '
        '
        'txtDocument
        '
        Me.txtDocument.Location = New System.Drawing.Point(12, 7)
        Me.txtDocument.Multiline = True
        Me.txtDocument.Name = "txtDocument"
        Me.txtDocument.Size = New System.Drawing.Size(288, 431)
        Me.txtDocument.TabIndex = 2
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.LawnGreen
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(345, 12)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(113, 55)
        Me.btnPreview.TabIndex = 3
        Me.btnPreview.Text = "&Print Preview"
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'btnDialog
        '
        Me.btnDialog.BackColor = System.Drawing.Color.LawnGreen
        Me.btnDialog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDialog.Location = New System.Drawing.Point(464, 12)
        Me.btnDialog.Name = "btnDialog"
        Me.btnDialog.Size = New System.Drawing.Size(113, 55)
        Me.btnDialog.TabIndex = 4
        Me.btnDialog.Text = "Print &Dialog"
        Me.btnDialog.UseVisualStyleBackColor = False
        '
        'btnPage
        '
        Me.btnPage.BackColor = System.Drawing.Color.LawnGreen
        Me.btnPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPage.Location = New System.Drawing.Point(583, 12)
        Me.btnPage.Name = "btnPage"
        Me.btnPage.Size = New System.Drawing.Size(113, 55)
        Me.btnPage.TabIndex = 5
        Me.btnPage.Text = "Page &Setup"
        Me.btnPage.UseVisualStyleBackColor = False
        '
        'frmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPage)
        Me.Controls.Add(Me.btnDialog)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.txtDocument)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "frmReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AOT Jaeger Statue Reciept"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNew As Button
    Friend WithEvents pdoc As Printing.PrintDocument
    Friend WithEvents txtDocument As TextBox
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnDialog As Button
    Friend WithEvents btnPage As Button
End Class
