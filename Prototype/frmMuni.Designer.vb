<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMuni
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
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtLawEnforcementContact = New System.Windows.Forms.TextBox
        Me.txtHoldingFacility = New System.Windows.Forms.TextBox
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.txtNameOfMuni = New System.Windows.Forms.TextBox
        Me.txtMuniID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(324, 207)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(103, 27)
        Me.btnClose.TabIndex = 68
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(324, 163)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(103, 27)
        Me.btnDelete.TabIndex = 67
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(324, 41)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(103, 27)
        Me.btnSearch.TabIndex = 64
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(324, 121)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 27)
        Me.btnSave.TabIndex = 66
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(324, 82)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(103, 27)
        Me.btnModify.TabIndex = 65
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLawEnforcementContact)
        Me.GroupBox2.Controls.Add(Me.txtHoldingFacility)
        Me.GroupBox2.Controls.Add(Me.txtRate)
        Me.GroupBox2.Controls.Add(Me.txtNameOfMuni)
        Me.GroupBox2.Controls.Add(Me.txtMuniID)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 237)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Municipal Information"
        '
        'txtLawEnforcementContact
        '
        Me.txtLawEnforcementContact.Location = New System.Drawing.Point(155, 194)
        Me.txtLawEnforcementContact.Name = "txtLawEnforcementContact"
        Me.txtLawEnforcementContact.Size = New System.Drawing.Size(100, 23)
        Me.txtLawEnforcementContact.TabIndex = 79
        '
        'txtHoldingFacility
        '
        Me.txtHoldingFacility.Location = New System.Drawing.Point(155, 156)
        Me.txtHoldingFacility.Name = "txtHoldingFacility"
        Me.txtHoldingFacility.Size = New System.Drawing.Size(100, 23)
        Me.txtHoldingFacility.TabIndex = 78
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(155, 114)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 23)
        Me.txtRate.TabIndex = 77
        '
        'txtNameOfMuni
        '
        Me.txtNameOfMuni.Location = New System.Drawing.Point(155, 70)
        Me.txtNameOfMuni.Name = "txtNameOfMuni"
        Me.txtNameOfMuni.Size = New System.Drawing.Size(100, 23)
        Me.txtNameOfMuni.TabIndex = 76
        '
        'txtMuniID
        '
        Me.txtMuniID.Location = New System.Drawing.Point(155, 35)
        Me.txtMuniID.Name = "txtMuniID"
        Me.txtMuniID.Size = New System.Drawing.Size(100, 23)
        Me.txtMuniID.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Municipal ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Name Of Municipal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 15)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Holding Facility"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 15)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Law Enforcement Contact"
        '
        'frmMuni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 297)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnModify)
        Me.Name = "frmMuni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Municipal"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLawEnforcementContact As System.Windows.Forms.TextBox
    Friend WithEvents txtHoldingFacility As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtNameOfMuni As System.Windows.Forms.TextBox
    Friend WithEvents txtMuniID As System.Windows.Forms.TextBox
End Class
