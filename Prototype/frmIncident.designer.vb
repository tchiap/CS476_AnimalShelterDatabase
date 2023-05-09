<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncident
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rtbNote = New System.Windows.Forms.RichTextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnInsert = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.grpMembership = New System.Windows.Forms.GroupBox
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtFee = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtIncidentID = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAnimalID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtEmployeeID = New System.Windows.Forms.TextBox
        Me.txtIncidentType = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMuniID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtClientID = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpMembership.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtbNote
        '
        Me.rtbNote.Location = New System.Drawing.Point(78, 304)
        Me.rtbNote.Name = "rtbNote"
        Me.rtbNote.Size = New System.Drawing.Size(519, 168)
        Me.rtbNote.TabIndex = 91
        Me.rtbNote.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(39, 307)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 15)
        Me.Label23.TabIndex = 92
        Me.Label23.Text = "Notes:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(641, 428)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(103, 27)
        Me.btnClose.TabIndex = 95
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(641, 324)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(103, 27)
        Me.btnInsert.TabIndex = 93
        Me.btnInsert.Text = "Add New"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(641, 377)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(103, 27)
        Me.btnModify.TabIndex = 94
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'grpMembership
        '
        Me.grpMembership.Controls.Add(Me.txtDate)
        Me.grpMembership.Controls.Add(Me.Label1)
        Me.grpMembership.Controls.Add(Me.btnSearch)
        Me.grpMembership.Controls.Add(Me.txtFee)
        Me.grpMembership.Controls.Add(Me.Label3)
        Me.grpMembership.Controls.Add(Me.txtIncidentID)
        Me.grpMembership.Controls.Add(Me.Label4)
        Me.grpMembership.Controls.Add(Me.txtAnimalID)
        Me.grpMembership.Controls.Add(Me.Label5)
        Me.grpMembership.Controls.Add(Me.txtEmployeeID)
        Me.grpMembership.Controls.Add(Me.txtIncidentType)
        Me.grpMembership.Controls.Add(Me.Label6)
        Me.grpMembership.Controls.Add(Me.txtMuniID)
        Me.grpMembership.Controls.Add(Me.Label7)
        Me.grpMembership.Controls.Add(Me.Label8)
        Me.grpMembership.Controls.Add(Me.txtClientID)
        Me.grpMembership.Controls.Add(Me.Label9)
        Me.grpMembership.Location = New System.Drawing.Point(22, 12)
        Me.grpMembership.Name = "grpMembership"
        Me.grpMembership.Size = New System.Drawing.Size(600, 229)
        Me.grpMembership.TabIndex = 96
        Me.grpMembership.TabStop = False
        Me.grpMembership.Text = "Incident Information"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(427, 70)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(96, 23)
        Me.txtDate.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Employee ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(221, 27)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(103, 27)
        Me.btnSearch.TabIndex = 30
        Me.btnSearch.Text = "Search"
        '
        'txtFee
        '
        Me.txtFee.Location = New System.Drawing.Point(427, 110)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(96, 23)
        Me.txtFee.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(325, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Fee:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIncidentID
        '
        Me.txtIncidentID.Location = New System.Drawing.Point(119, 31)
        Me.txtIncidentID.Name = "txtIncidentID"
        Me.txtIncidentID.Size = New System.Drawing.Size(96, 23)
        Me.txtIncidentID.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Animal ID:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAnimalID
        '
        Me.txtAnimalID.Location = New System.Drawing.Point(119, 70)
        Me.txtAnimalID.Name = "txtAnimalID"
        Me.txtAnimalID.Size = New System.Drawing.Size(96, 23)
        Me.txtAnimalID.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 18)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Client ID:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(119, 142)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(96, 23)
        Me.txtEmployeeID.TabIndex = 39
        '
        'txtIncidentType
        '
        Me.txtIncidentType.Location = New System.Drawing.Point(427, 27)
        Me.txtIncidentType.Name = "txtIncidentType"
        Me.txtIncidentType.Size = New System.Drawing.Size(96, 23)
        Me.txtIncidentType.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(311, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 18)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Incident Type:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMuniID
        '
        Me.txtMuniID.Location = New System.Drawing.Point(119, 182)
        Me.txtMuniID.Name = "txtMuniID"
        Me.txtMuniID.Size = New System.Drawing.Size(96, 23)
        Me.txtMuniID.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(325, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 18)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Incident Date:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 18)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Municipal ID:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtClientID
        '
        Me.txtClientID.Location = New System.Drawing.Point(119, 105)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.Size = New System.Drawing.Size(96, 23)
        Me.txtClientID.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Incident Number:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(78, 266)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(519, 23)
        Me.txtDescription.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Description:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmIncident
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 505)
        Me.Controls.Add(Me.grpMembership)
        Me.Controls.Add(Me.rtbNote)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnModify)
        Me.Name = "frmIncident"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIncident"
        Me.grpMembership.ResumeLayout(False)
        Me.grpMembership.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbNote As System.Windows.Forms.RichTextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents grpMembership As System.Windows.Forms.GroupBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFee As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIncidentID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAnimalID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents txtIncidentType As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMuniID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtClientID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
