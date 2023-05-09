<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMember
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
        Me.components = New System.ComponentModel.Container
        Me.txtMembershipDate = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnModSave = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.rtxtNotes = New System.Windows.Forms.RichTextBox
        Me.grpMembership = New System.Windows.Forms.GroupBox
        Me.cboReferrer = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtRenewDate = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtMemberType = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.Label15 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.grpPersonal = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtMemberID = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtAltPhone = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPrimaryPhone = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtZip = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtState = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtMiddleInitial = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpMembership.SuspendLayout()
        Me.grpPersonal.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMembershipDate
        '
        Me.txtMembershipDate.Location = New System.Drawing.Point(118, 28)
        Me.txtMembershipDate.Name = "txtMembershipDate"
        Me.txtMembershipDate.Size = New System.Drawing.Size(96, 23)
        Me.txtMembershipDate.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 18)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Membership Date:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(245, 32)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(103, 27)
        Me.btnSearch.TabIndex = 30
        Me.btnSearch.Text = "Search"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(548, 559)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(103, 27)
        Me.btnClose.TabIndex = 59
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Close"
        '
        'btnModSave
        '
        Me.btnModSave.Location = New System.Drawing.Point(548, 502)
        Me.btnModSave.Name = "btnModSave"
        Me.btnModSave.Size = New System.Drawing.Size(103, 27)
        Me.btnModSave.TabIndex = 58
        Me.btnModSave.TabStop = False
        Me.btnModSave.Text = "Modify"
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(548, 444)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(103, 27)
        Me.btnAddNew.TabIndex = 57
        Me.btnAddNew.TabStop = False
        Me.btnAddNew.Text = "Add New"
        '
        'rtxtNotes
        '
        Me.rtxtNotes.Location = New System.Drawing.Point(52, 442)
        Me.rtxtNotes.Name = "rtxtNotes"
        Me.rtxtNotes.Size = New System.Drawing.Size(483, 151)
        Me.rtxtNotes.TabIndex = 56
        Me.rtxtNotes.Text = ""
        '
        'grpMembership
        '
        Me.grpMembership.Controls.Add(Me.cboReferrer)
        Me.grpMembership.Controls.Add(Me.Label16)
        Me.grpMembership.Controls.Add(Me.txtRenewDate)
        Me.grpMembership.Controls.Add(Me.Label14)
        Me.grpMembership.Controls.Add(Me.Label12)
        Me.grpMembership.Controls.Add(Me.txtMembershipDate)
        Me.grpMembership.Controls.Add(Me.txtMemberType)
        Me.grpMembership.Controls.Add(Me.Label18)
        Me.grpMembership.Controls.Add(Me.Label13)
        Me.grpMembership.Location = New System.Drawing.Point(413, 7)
        Me.grpMembership.Name = "grpMembership"
        Me.grpMembership.Size = New System.Drawing.Size(232, 305)
        Me.grpMembership.TabIndex = 55
        Me.grpMembership.TabStop = False
        Me.grpMembership.Text = "Membership Information"
        '
        'cboReferrer
        '
        Me.cboReferrer.FormattingEnabled = True
        Me.cboReferrer.Items.AddRange(New Object() {"Newspaper", "Friend", "Internet"})
        Me.cboReferrer.Location = New System.Drawing.Point(118, 123)
        Me.cboReferrer.Name = "cboReferrer"
        Me.cboReferrer.Size = New System.Drawing.Size(96, 23)
        Me.cboReferrer.TabIndex = 48
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 18)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Referred By:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRenewDate
        '
        Me.txtRenewDate.Location = New System.Drawing.Point(118, 88)
        Me.txtRenewDate.Name = "txtRenewDate"
        Me.txtRenewDate.Size = New System.Drawing.Size(96, 23)
        Me.txtRenewDate.TabIndex = 46
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 18)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Renewed Date:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 18)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Member Date:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMemberType
        '
        Me.txtMemberType.Location = New System.Drawing.Point(118, 58)
        Me.txtMemberType.Name = "txtMemberType"
        Me.txtMemberType.Size = New System.Drawing.Size(96, 23)
        Me.txtMemberType.TabIndex = 43
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 62)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 18)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Member Type:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 577)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(665, 25)
        Me.StatusBar1.TabIndex = 53
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label15.Location = New System.Drawing.Point(8, 442)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 18)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Notes:"
        '
        'grpPersonal
        '
        Me.grpPersonal.Controls.Add(Me.Label17)
        Me.grpPersonal.Controls.Add(Me.txtMemberID)
        Me.grpPersonal.Controls.Add(Me.btnSearch)
        Me.grpPersonal.Controls.Add(Me.Label11)
        Me.grpPersonal.Controls.Add(Me.txtEmail)
        Me.grpPersonal.Controls.Add(Me.Label10)
        Me.grpPersonal.Controls.Add(Me.txtAltPhone)
        Me.grpPersonal.Controls.Add(Me.Label9)
        Me.grpPersonal.Controls.Add(Me.txtPrimaryPhone)
        Me.grpPersonal.Controls.Add(Me.Label8)
        Me.grpPersonal.Controls.Add(Me.txtZip)
        Me.grpPersonal.Controls.Add(Me.Label7)
        Me.grpPersonal.Controls.Add(Me.txtState)
        Me.grpPersonal.Controls.Add(Me.Label6)
        Me.grpPersonal.Controls.Add(Me.Label5)
        Me.grpPersonal.Controls.Add(Me.Label4)
        Me.grpPersonal.Controls.Add(Me.txtAddress1)
        Me.grpPersonal.Controls.Add(Me.Label1)
        Me.grpPersonal.Controls.Add(Me.txtAddress2)
        Me.grpPersonal.Controls.Add(Me.txtCity)
        Me.grpPersonal.Controls.Add(Me.txtLastName)
        Me.grpPersonal.Controls.Add(Me.txtMiddleInitial)
        Me.grpPersonal.Controls.Add(Me.txtFirstName)
        Me.grpPersonal.Controls.Add(Me.Label3)
        Me.grpPersonal.Controls.Add(Me.Label2)
        Me.grpPersonal.Location = New System.Drawing.Point(8, 5)
        Me.grpPersonal.Name = "grpPersonal"
        Me.grpPersonal.Size = New System.Drawing.Size(359, 419)
        Me.grpPersonal.TabIndex = 54
        Me.grpPersonal.TabStop = False
        Me.grpPersonal.Text = "Personal Information"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(27, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 18)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Member ID:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMemberID
        '
        Me.txtMemberID.Location = New System.Drawing.Point(123, 32)
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.Size = New System.Drawing.Size(104, 23)
        Me.txtMemberID.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(26, 385)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 18)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Email:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(123, 385)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(104, 23)
        Me.txtEmail.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(26, 358)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 18)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Alt Telephone:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAltPhone
        '
        Me.txtAltPhone.Location = New System.Drawing.Point(123, 353)
        Me.txtAltPhone.Name = "txtAltPhone"
        Me.txtAltPhone.Size = New System.Drawing.Size(104, 23)
        Me.txtAltPhone.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(30, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Primary Telephone:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrimaryPhone
        '
        Me.txtPrimaryPhone.Location = New System.Drawing.Point(122, 320)
        Me.txtPrimaryPhone.Name = "txtPrimaryPhone"
        Me.txtPrimaryPhone.Size = New System.Drawing.Size(104, 23)
        Me.txtPrimaryPhone.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(26, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Zipcode:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(123, 288)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(45, 23)
        Me.txtZip.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(26, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "State:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(123, 256)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(24, 23)
        Me.txtState.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(26, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Address:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(26, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Address 2:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(26, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "City:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(123, 157)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(104, 23)
        Me.txtAddress1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(27, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(123, 193)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(104, 23)
        Me.txtAddress2.TabIndex = 10
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(123, 226)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(104, 23)
        Me.txtCity.TabIndex = 11
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(123, 123)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(104, 23)
        Me.txtLastName.TabIndex = 5
        '
        'txtMiddleInitial
        '
        Me.txtMiddleInitial.Location = New System.Drawing.Point(123, 94)
        Me.txtMiddleInitial.Name = "txtMiddleInitial"
        Me.txtMiddleInitial.Size = New System.Drawing.Size(24, 23)
        Me.txtMiddleInitial.TabIndex = 4
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(123, 64)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(104, 23)
        Me.txtFirstName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(26, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(26, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Middle Initial:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 602)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnModSave)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.rtxtNotes)
        Me.Controls.Add(Me.grpMembership)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.grpPersonal)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Members"
        Me.grpMembership.ResumeLayout(False)
        Me.grpMembership.PerformLayout()
        Me.grpPersonal.ResumeLayout(False)
        Me.grpPersonal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtMembershipDate As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnModSave As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents rtxtNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents grpMembership As System.Windows.Forms.GroupBox
    Friend WithEvents txtMemberType As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents grpPersonal As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAltPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPrimaryPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleInitial As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtRenewDate As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboReferrer As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMemberID As System.Windows.Forms.TextBox
End Class
