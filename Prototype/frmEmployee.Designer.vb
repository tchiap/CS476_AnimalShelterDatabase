<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.grpBasic = New System.Windows.Forms.GroupBox
        Me.txtBirthday = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtAlias = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtZip = New System.Windows.Forms.TextBox
        Me.txtState = New System.Windows.Forms.TextBox
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.txtMidInit = New System.Windows.Forms.TextBox
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.grpContact = New System.Windows.Forms.GroupBox
        Me.txtAltPhone = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtPriPhone = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPosition = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtEmpID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.grpBasic.SuspendLayout()
        Me.grpContact.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(618, 496)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(103, 27)
        Me.btnClose.TabIndex = 50
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(618, 438)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(103, 27)
        Me.btnModify.TabIndex = 49
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(618, 378)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 27)
        Me.btnAdd.TabIndex = 48
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(14, 329)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(597, 268)
        Me.TabControl1.TabIndex = 47
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(589, 240)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Incidents"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(585, 234)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(589, 240)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Adoptions"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListView2
        '
        Me.ListView2.Location = New System.Drawing.Point(2, 2)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(585, 234)
        Me.ListView2.TabIndex = 1
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ListView3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(589, 240)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Returns"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ListView3
        '
        Me.ListView3.Location = New System.Drawing.Point(2, 2)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(585, 234)
        Me.ListView3.TabIndex = 1
        Me.ListView3.UseCompatibleStateImageBehavior = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.RichTextBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(589, 240)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Notes"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(2, 1)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(586, 236)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'grpBasic
        '
        Me.grpBasic.Controls.Add(Me.txtBirthday)
        Me.grpBasic.Controls.Add(Me.Label16)
        Me.grpBasic.Controls.Add(Me.txtAlias)
        Me.grpBasic.Controls.Add(Me.Label15)
        Me.grpBasic.Controls.Add(Me.Label14)
        Me.grpBasic.Controls.Add(Me.txtZip)
        Me.grpBasic.Controls.Add(Me.txtState)
        Me.grpBasic.Controls.Add(Me.txtAddress2)
        Me.grpBasic.Controls.Add(Me.txtMidInit)
        Me.grpBasic.Controls.Add(Me.txtLName)
        Me.grpBasic.Controls.Add(Me.txtAddress1)
        Me.grpBasic.Controls.Add(Me.txtCity)
        Me.grpBasic.Controls.Add(Me.txtFName)
        Me.grpBasic.Controls.Add(Me.Label13)
        Me.grpBasic.Controls.Add(Me.Label12)
        Me.grpBasic.Controls.Add(Me.Label11)
        Me.grpBasic.Controls.Add(Me.Label10)
        Me.grpBasic.Controls.Add(Me.Label9)
        Me.grpBasic.Controls.Add(Me.Label8)
        Me.grpBasic.Enabled = False
        Me.grpBasic.Location = New System.Drawing.Point(363, 22)
        Me.grpBasic.Name = "grpBasic"
        Me.grpBasic.Size = New System.Drawing.Size(404, 275)
        Me.grpBasic.TabIndex = 46
        Me.grpBasic.TabStop = False
        Me.grpBasic.Text = "Basic Information"
        '
        'txtBirthday
        '
        Me.txtBirthday.Location = New System.Drawing.Point(71, 204)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.Size = New System.Drawing.Size(107, 23)
        Me.txtBirthday.TabIndex = 30
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(25, 212)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 15)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "B-Day:"
        '
        'txtAlias
        '
        Me.txtAlias.Location = New System.Drawing.Point(71, 174)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(107, 23)
        Me.txtAlias.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(32, 182)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 15)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Alias:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(255, 147)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 15)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Zip Code:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(314, 138)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(81, 23)
        Me.txtZip.TabIndex = 25
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(219, 138)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(34, 23)
        Me.txtState.TabIndex = 24
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(71, 108)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(324, 23)
        Me.txtAddress2.TabIndex = 23
        '
        'txtMidInit
        '
        Me.txtMidInit.Location = New System.Drawing.Point(258, 20)
        Me.txtMidInit.Name = "txtMidInit"
        Me.txtMidInit.Size = New System.Drawing.Size(34, 23)
        Me.txtMidInit.TabIndex = 22
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(71, 48)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(100, 23)
        Me.txtLName.TabIndex = 21
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(71, 78)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(324, 23)
        Me.txtAddress1.TabIndex = 20
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(71, 138)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(107, 23)
        Me.txtCity.TabIndex = 19
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(71, 18)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(100, 23)
        Me.txtFName.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(182, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 15)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "State:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(37, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 15)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "City:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 15)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Address:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(189, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 15)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Middle Initi.:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Last Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "First Name:"
        '
        'grpContact
        '
        Me.grpContact.Controls.Add(Me.txtAltPhone)
        Me.grpContact.Controls.Add(Me.txtEmail)
        Me.grpContact.Controls.Add(Me.txtPriPhone)
        Me.grpContact.Controls.Add(Me.Label7)
        Me.grpContact.Controls.Add(Me.Label6)
        Me.grpContact.Controls.Add(Me.Label5)
        Me.grpContact.Enabled = False
        Me.grpContact.Location = New System.Drawing.Point(7, 175)
        Me.grpContact.Name = "grpContact"
        Me.grpContact.Size = New System.Drawing.Size(340, 121)
        Me.grpContact.TabIndex = 45
        Me.grpContact.TabStop = False
        Me.grpContact.Text = "Contact Information"
        '
        'txtAltPhone
        '
        Me.txtAltPhone.Location = New System.Drawing.Point(121, 54)
        Me.txtAltPhone.Name = "txtAltPhone"
        Me.txtAltPhone.Size = New System.Drawing.Size(100, 23)
        Me.txtAltPhone.TabIndex = 36
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(121, 84)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 23)
        Me.txtEmail.TabIndex = 35
        '
        'txtPriPhone
        '
        Me.txtPriPhone.Location = New System.Drawing.Point(121, 24)
        Me.txtPriPhone.Name = "txtPriPhone"
        Me.txtPriPhone.Size = New System.Drawing.Size(100, 23)
        Me.txtPriPhone.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Alt. Telephone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Pri. Telephone:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPosition)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtEmpID)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 150)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identification"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(121, 88)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 23)
        Me.txtUsername.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Employee Position:"
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(121, 53)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(100, 23)
        Me.txtPosition.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee ID:"
        '
        'txtEmpID
        '
        Me.txtEmpID.Location = New System.Drawing.Point(121, 18)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(100, 23)
        Me.txtEmpID.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "License/ID No.:"
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 615)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.grpBasic)
        Me.Controls.Add(Me.grpContact)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.grpBasic.ResumeLayout(False)
        Me.grpBasic.PerformLayout()
        Me.grpContact.ResumeLayout(False)
        Me.grpContact.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents grpBasic As System.Windows.Forms.GroupBox
    Friend WithEvents txtBirthday As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtAlias As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMidInit As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grpContact As System.Windows.Forms.GroupBox
    Friend WithEvents txtAltPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPriPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
End Class
