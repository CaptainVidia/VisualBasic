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
        Me.licensingOptionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.oneTimePurchaseRadioButton = New System.Windows.Forms.RadioButton()
        Me.yearlyLicenseRadioButton = New System.Windows.Forms.RadioButton()
        Me.optionalFeaturesGroupBox = New System.Windows.Forms.GroupBox()
        Me.cloudBackupCheckBox = New System.Windows.Forms.CheckBox()
        Me.onSiteTrainingCheckBox = New System.Windows.Forms.CheckBox()
        Me.technicalSupportCheckBox = New System.Windows.Forms.CheckBox()
        Me.bigLabel = New System.Windows.Forms.Label()
        Me.softwareLicensingCostLabel = New System.Windows.Forms.Label()
        Me.softwareLicensingResultLabel = New System.Windows.Forms.Label()
        Me.costOfOptionalFeaturesLabel = New System.Windows.Forms.Label()
        Me.optionalFeaturesResultLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.licensingOptionsGroupBox.SuspendLayout()
        Me.optionalFeaturesGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'licensingOptionsGroupBox
        '
        Me.licensingOptionsGroupBox.Controls.Add(Me.oneTimePurchaseRadioButton)
        Me.licensingOptionsGroupBox.Controls.Add(Me.yearlyLicenseRadioButton)
        Me.licensingOptionsGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.licensingOptionsGroupBox.Location = New System.Drawing.Point(73, 38)
        Me.licensingOptionsGroupBox.Name = "licensingOptionsGroupBox"
        Me.licensingOptionsGroupBox.Size = New System.Drawing.Size(323, 191)
        Me.licensingOptionsGroupBox.TabIndex = 2
        Me.licensingOptionsGroupBox.TabStop = False
        Me.licensingOptionsGroupBox.Text = "Licensing Options"
        '
        'oneTimePurchaseRadioButton
        '
        Me.oneTimePurchaseRadioButton.Location = New System.Drawing.Point(27, 81)
        Me.oneTimePurchaseRadioButton.Name = "oneTimePurchaseRadioButton"
        Me.oneTimePurchaseRadioButton.Size = New System.Drawing.Size(175, 24)
        Me.oneTimePurchaseRadioButton.TabIndex = 1
        Me.oneTimePurchaseRadioButton.TabStop = True
        Me.oneTimePurchaseRadioButton.Text = "One - Time Purchase"
        Me.oneTimePurchaseRadioButton.UseVisualStyleBackColor = True
        '
        'yearlyLicenseRadioButton
        '
        Me.yearlyLicenseRadioButton.Location = New System.Drawing.Point(27, 34)
        Me.yearlyLicenseRadioButton.Name = "yearlyLicenseRadioButton"
        Me.yearlyLicenseRadioButton.Size = New System.Drawing.Size(124, 24)
        Me.yearlyLicenseRadioButton.TabIndex = 0
        Me.yearlyLicenseRadioButton.TabStop = True
        Me.yearlyLicenseRadioButton.Text = "Yearly license"
        Me.yearlyLicenseRadioButton.UseVisualStyleBackColor = True
        '
        'optionalFeaturesGroupBox
        '
        Me.optionalFeaturesGroupBox.Controls.Add(Me.cloudBackupCheckBox)
        Me.optionalFeaturesGroupBox.Controls.Add(Me.onSiteTrainingCheckBox)
        Me.optionalFeaturesGroupBox.Controls.Add(Me.technicalSupportCheckBox)
        Me.optionalFeaturesGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionalFeaturesGroupBox.Location = New System.Drawing.Point(436, 38)
        Me.optionalFeaturesGroupBox.Name = "optionalFeaturesGroupBox"
        Me.optionalFeaturesGroupBox.Size = New System.Drawing.Size(323, 191)
        Me.optionalFeaturesGroupBox.TabIndex = 3
        Me.optionalFeaturesGroupBox.TabStop = False
        Me.optionalFeaturesGroupBox.Text = "Optional Features (yearly)"
        '
        'cloudBackupCheckBox
        '
        Me.cloudBackupCheckBox.Location = New System.Drawing.Point(29, 126)
        Me.cloudBackupCheckBox.Name = "cloudBackupCheckBox"
        Me.cloudBackupCheckBox.Size = New System.Drawing.Size(251, 23)
        Me.cloudBackupCheckBox.TabIndex = 2
        Me.cloudBackupCheckBox.Text = "Cloud Backup"
        Me.cloudBackupCheckBox.UseVisualStyleBackColor = True
        '
        'onSiteTrainingCheckBox
        '
        Me.onSiteTrainingCheckBox.Location = New System.Drawing.Point(29, 81)
        Me.onSiteTrainingCheckBox.Name = "onSiteTrainingCheckBox"
        Me.onSiteTrainingCheckBox.Size = New System.Drawing.Size(251, 24)
        Me.onSiteTrainingCheckBox.TabIndex = 1
        Me.onSiteTrainingCheckBox.Text = "On - site Training"
        Me.onSiteTrainingCheckBox.UseVisualStyleBackColor = True
        '
        'technicalSupportCheckBox
        '
        Me.technicalSupportCheckBox.Location = New System.Drawing.Point(29, 35)
        Me.technicalSupportCheckBox.Name = "technicalSupportCheckBox"
        Me.technicalSupportCheckBox.Size = New System.Drawing.Size(251, 23)
        Me.technicalSupportCheckBox.TabIndex = 0
        Me.technicalSupportCheckBox.Text = "Level - 3 Technical Support"
        Me.technicalSupportCheckBox.UseVisualStyleBackColor = True
        '
        'bigLabel
        '
        Me.bigLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bigLabel.Location = New System.Drawing.Point(105, 274)
        Me.bigLabel.Name = "bigLabel"
        Me.bigLabel.Size = New System.Drawing.Size(590, 122)
        Me.bigLabel.TabIndex = 2
        '
        'softwareLicensingCostLabel
        '
        Me.softwareLicensingCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.softwareLicensingCostLabel.Location = New System.Drawing.Point(121, 286)
        Me.softwareLicensingCostLabel.Name = "softwareLicensingCostLabel"
        Me.softwareLicensingCostLabel.Size = New System.Drawing.Size(304, 41)
        Me.softwareLicensingCostLabel.TabIndex = 3
        Me.softwareLicensingCostLabel.Text = "Cost of software licesening: "
        '
        'softwareLicensingResultLabel
        '
        Me.softwareLicensingResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.softwareLicensingResultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.softwareLicensingResultLabel.Location = New System.Drawing.Point(456, 286)
        Me.softwareLicensingResultLabel.Name = "softwareLicensingResultLabel"
        Me.softwareLicensingResultLabel.Size = New System.Drawing.Size(224, 29)
        Me.softwareLicensingResultLabel.TabIndex = 3
        '
        'costOfOptionalFeaturesLabel
        '
        Me.costOfOptionalFeaturesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costOfOptionalFeaturesLabel.Location = New System.Drawing.Point(121, 339)
        Me.costOfOptionalFeaturesLabel.Name = "costOfOptionalFeaturesLabel"
        Me.costOfOptionalFeaturesLabel.Size = New System.Drawing.Size(304, 41)
        Me.costOfOptionalFeaturesLabel.TabIndex = 5
        Me.costOfOptionalFeaturesLabel.Text = "Cost of optional features: "
        '
        'optionalFeaturesResultLabel
        '
        Me.optionalFeaturesResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.optionalFeaturesResultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionalFeaturesResultLabel.Location = New System.Drawing.Point(456, 339)
        Me.optionalFeaturesResultLabel.Name = "optionalFeaturesResultLabel"
        Me.optionalFeaturesResultLabel.Size = New System.Drawing.Size(224, 29)
        Me.optionalFeaturesResultLabel.TabIndex = 4
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(100, 479)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(121, 60)
        Me.calculateButton.TabIndex = 5
        Me.calculateButton.Text = "C&alculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(311, 479)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(121, 60)
        Me.clearButton.TabIndex = 6
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(540, 479)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(121, 60)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 579)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.optionalFeaturesResultLabel)
        Me.Controls.Add(Me.costOfOptionalFeaturesLabel)
        Me.Controls.Add(Me.softwareLicensingResultLabel)
        Me.Controls.Add(Me.licensingOptionsGroupBox)
        Me.Controls.Add(Me.softwareLicensingCostLabel)
        Me.Controls.Add(Me.bigLabel)
        Me.Controls.Add(Me.optionalFeaturesGroupBox)
        Me.Name = "mainForm"
        Me.Text = "Software Sales"
        Me.licensingOptionsGroupBox.ResumeLayout(False)
        Me.optionalFeaturesGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents licensingOptionsGroupBox As GroupBox
    Friend WithEvents oneTimePurchaseRadioButton As RadioButton
    Friend WithEvents yearlyLicenseRadioButton As RadioButton
    Friend WithEvents optionalFeaturesGroupBox As GroupBox
    Friend WithEvents bigLabel As Label
    Friend WithEvents softwareLicensingCostLabel As Label
    Friend WithEvents cloudBackupCheckBox As CheckBox
    Friend WithEvents onSiteTrainingCheckBox As CheckBox
    Friend WithEvents technicalSupportCheckBox As CheckBox
    Friend WithEvents softwareLicensingResultLabel As Label
    Friend WithEvents costOfOptionalFeaturesLabel As Label
    Friend WithEvents optionalFeaturesResultLabel As Label
    Friend WithEvents calculateButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
End Class
