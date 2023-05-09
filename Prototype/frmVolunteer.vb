Imports System.Data.OleDb
Public Class frmVolunteer
    Inherits System.Windows.Forms.Form
    Dim Connect As New OleDbConnection


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtMidInitial As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPhone1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPhone2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lboxVolunteerHist As System.Windows.Forms.ListBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEventName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtEventDate As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lboxEvents As System.Windows.Forms.ListBox
    Friend WithEvents btnCreateEvent As System.Windows.Forms.Button
    Friend WithEvents txtEndTime As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtStartTime As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnModifyEvent As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rtxtboxEventDesc As System.Windows.Forms.RichTextBox
    Friend WithEvents btnDeleteEvent As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtEnterID As System.Windows.Forms.TextBox
    Friend WithEvents txtEventID As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnSearchEvent As System.Windows.Forms.Button
    Friend WithEvents txtVolID As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents txtDuty As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LstEvent As System.Windows.Forms.ListBox
    Friend WithEvents btnClose2 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim btnClose1 As System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtMidInitial = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtState = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtZipCode = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPhone1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPhone2 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lboxVolunteerHist = New System.Windows.Forms.ListBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnClose2 = New System.Windows.Forms.Button
        Me.LstEvent = New System.Windows.Forms.ListBox
        Me.txtDuty = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtHours = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtVolID = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtEnterID = New System.Windows.Forms.TextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.btnSearchEvent = New System.Windows.Forms.Button
        Me.txtEventID = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.rtxtboxEventDesc = New System.Windows.Forms.RichTextBox
        Me.btnDeleteEvent = New System.Windows.Forms.Button
        Me.btnModifyEvent = New System.Windows.Forms.Button
        Me.Label21 = New System.Windows.Forms.Label
        Me.lboxEvents = New System.Windows.Forms.ListBox
        Me.btnCreateEvent = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtEventName = New System.Windows.Forms.TextBox
        Me.txtEventDate = New System.Windows.Forms.TextBox
        Me.txtStartTime = New System.Windows.Forms.TextBox
        Me.txtEndTime = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        btnClose1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose1
        '
        btnClose1.Location = New System.Drawing.Point(346, 260)
        btnClose1.Name = "btnClose1"
        btnClose1.Size = New System.Drawing.Size(103, 27)
        btnClose1.TabIndex = 19
        btnClose1.Text = "Close"
        btnClose1.UseVisualStyleBackColor = True
        AddHandler btnClose1.Click, AddressOf Me.btnClose1_Click
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(29, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(17, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Middle Initial"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(31, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(133, 96)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(104, 23)
        Me.txtFirstName.TabIndex = 3
        '
        'txtMidInitial
        '
        Me.txtMidInitial.Location = New System.Drawing.Point(133, 126)
        Me.txtMidInitial.Name = "txtMidInitial"
        Me.txtMidInitial.Size = New System.Drawing.Size(24, 23)
        Me.txtMidInitial.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(133, 155)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(144, 23)
        Me.txtLastName.TabIndex = 5
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(133, 250)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(104, 23)
        Me.txtCity.TabIndex = 11
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(133, 218)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(144, 23)
        Me.txtAddress2.TabIndex = 10
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(107, 115)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(144, 23)
        Me.txtAddress1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(61, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "City"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(36, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Address 2"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(42, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Address"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(133, 282)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(24, 23)
        Me.txtState.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(58, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "State"
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(133, 313)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(56, 23)
        Me.txtZipCode.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(45, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Zipcode"
        '
        'txtPhone1
        '
        Me.txtPhone1.Location = New System.Drawing.Point(133, 346)
        Me.txtPhone1.Name = "txtPhone1"
        Me.txtPhone1.Size = New System.Drawing.Size(104, 23)
        Me.txtPhone1.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(33, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Telephone"
        '
        'txtPhone2
        '
        Me.txtPhone2.Location = New System.Drawing.Point(133, 378)
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Size = New System.Drawing.Size(104, 23)
        Me.txtPhone2.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(22, 310)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Telephone 2"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(133, 411)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(104, 23)
        Me.txtEmail.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(56, 343)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 19)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Email"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAddress1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 375)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'lboxVolunteerHist
        '
        Me.lboxVolunteerHist.FormattingEnabled = True
        Me.lboxVolunteerHist.ItemHeight = 15
        Me.lboxVolunteerHist.Location = New System.Drawing.Point(294, 303)
        Me.lboxVolunteerHist.MultiColumn = True
        Me.lboxVolunteerHist.Name = "lboxVolunteerHist"
        Me.lboxVolunteerHist.Size = New System.Drawing.Size(248, 109)
        Me.lboxVolunteerHist.TabIndex = 50
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(291, 286)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 13)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Volunteer History:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(8, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(591, 490)
        Me.TabControl1.TabIndex = 52
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnClose2)
        Me.TabPage2.Controls.Add(Me.LstEvent)
        Me.TabPage2.Controls.Add(Me.txtDuty)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.txtHours)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.txtVolID)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(583, 462)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Event Information"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnClose2
        '
        Me.btnClose2.Location = New System.Drawing.Point(460, 106)
        Me.btnClose2.Name = "btnClose2"
        Me.btnClose2.Size = New System.Drawing.Size(103, 27)
        Me.btnClose2.TabIndex = 64
        Me.btnClose2.Text = "Close"
        Me.btnClose2.UseVisualStyleBackColor = True
        '
        'LstEvent
        '
        Me.LstEvent.FormattingEnabled = True
        Me.LstEvent.ItemHeight = 15
        Me.LstEvent.Location = New System.Drawing.Point(11, 32)
        Me.LstEvent.Name = "LstEvent"
        Me.LstEvent.Size = New System.Drawing.Size(168, 109)
        Me.LstEvent.TabIndex = 63
        '
        'txtDuty
        '
        Me.txtDuty.Location = New System.Drawing.Point(338, 124)
        Me.txtDuty.Name = "txtDuty"
        Me.txtDuty.Size = New System.Drawing.Size(100, 23)
        Me.txtDuty.TabIndex = 62
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(289, 132)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(32, 15)
        Me.Label28.TabIndex = 61
        Me.Label28.Text = "Duty:"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(338, 82)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 23)
        Me.txtHours.TabIndex = 60
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(460, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 27)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtVolID
        '
        Me.txtVolID.Location = New System.Drawing.Point(338, 44)
        Me.txtVolID.Name = "txtVolID"
        Me.txtVolID.Size = New System.Drawing.Size(100, 23)
        Me.txtVolID.TabIndex = 8
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(250, 52)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(71, 15)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Volunteer ID:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(284, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 15)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Hours:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(171, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Select Event Participated In:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 15)
        Me.Label12.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnSearch)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.txtEnterID)
        Me.TabPage1.Controls.Add(Me.btnClose)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.btnModify)
        Me.TabPage1.Controls.Add(Me.txtCity)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.lboxVolunteerHist)
        Me.TabPage1.Controls.Add(Me.txtFirstName)
        Me.TabPage1.Controls.Add(Me.txtMidInitial)
        Me.TabPage1.Controls.Add(Me.txtLastName)
        Me.TabPage1.Controls.Add(Me.txtAddress2)
        Me.TabPage1.Controls.Add(Me.txtState)
        Me.TabPage1.Controls.Add(Me.txtZipCode)
        Me.TabPage1.Controls.Add(Me.txtPhone1)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.txtPhone2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(583, 462)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Volunteer Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(366, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(103, 27)
        Me.btnSearch.TabIndex = 58
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(70, 35)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 15)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "Enter ID"
        '
        'txtEnterID
        '
        Me.txtEnterID.Location = New System.Drawing.Point(137, 27)
        Me.txtEnterID.Name = "txtEnterID"
        Me.txtEnterID.Size = New System.Drawing.Size(100, 23)
        Me.txtEnterID.TabIndex = 56
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(366, 168)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(103, 27)
        Me.btnClose.TabIndex = 55
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(366, 119)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 27)
        Me.btnSave.TabIndex = 54
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(366, 71)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(103, 27)
        Me.btnModify.TabIndex = 53
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(btnClose1)
        Me.TabPage3.Controls.Add(Me.btnSearchEvent)
        Me.TabPage3.Controls.Add(Me.txtEventID)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Controls.Add(Me.rtxtboxEventDesc)
        Me.TabPage3.Controls.Add(Me.btnDeleteEvent)
        Me.TabPage3.Controls.Add(Me.btnModifyEvent)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.lboxEvents)
        Me.TabPage3.Controls.Add(Me.btnCreateEvent)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(583, 462)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Create Event"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnSearchEvent
        '
        Me.btnSearchEvent.Location = New System.Drawing.Point(237, 12)
        Me.btnSearchEvent.Name = "btnSearchEvent"
        Me.btnSearchEvent.Size = New System.Drawing.Size(103, 27)
        Me.btnSearchEvent.TabIndex = 18
        Me.btnSearchEvent.Text = "Search"
        Me.btnSearchEvent.UseVisualStyleBackColor = True
        '
        'txtEventID
        '
        Me.txtEventID.Location = New System.Drawing.Point(118, 15)
        Me.txtEventID.Name = "txtEventID"
        Me.txtEventID.Size = New System.Drawing.Size(100, 23)
        Me.txtEventID.TabIndex = 17
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(35, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 15)
        Me.Label23.TabIndex = 16
        Me.Label23.Text = "Enter Event ID"
        '
        'rtxtboxEventDesc
        '
        Me.rtxtboxEventDesc.Location = New System.Drawing.Point(250, 73)
        Me.rtxtboxEventDesc.Name = "rtxtboxEventDesc"
        Me.rtxtboxEventDesc.Size = New System.Drawing.Size(261, 115)
        Me.rtxtboxEventDesc.TabIndex = 14
        Me.rtxtboxEventDesc.Text = ""
        '
        'btnDeleteEvent
        '
        Me.btnDeleteEvent.Location = New System.Drawing.Point(455, 210)
        Me.btnDeleteEvent.Name = "btnDeleteEvent"
        Me.btnDeleteEvent.Size = New System.Drawing.Size(103, 27)
        Me.btnDeleteEvent.TabIndex = 13
        Me.btnDeleteEvent.Text = "Delete Event"
        Me.btnDeleteEvent.UseVisualStyleBackColor = True
        '
        'btnModifyEvent
        '
        Me.btnModifyEvent.Location = New System.Drawing.Point(346, 210)
        Me.btnModifyEvent.Name = "btnModifyEvent"
        Me.btnModifyEvent.Size = New System.Drawing.Size(103, 27)
        Me.btnModifyEvent.TabIndex = 12
        Me.btnModifyEvent.Text = "Modify Event"
        Me.btnModifyEvent.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(28, 315)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 13)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "Events:"
        '
        'lboxEvents
        '
        Me.lboxEvents.FormattingEnabled = True
        Me.lboxEvents.ItemHeight = 15
        Me.lboxEvents.Location = New System.Drawing.Point(84, 315)
        Me.lboxEvents.Name = "lboxEvents"
        Me.lboxEvents.Size = New System.Drawing.Size(481, 109)
        Me.lboxEvents.TabIndex = 9
        '
        'btnCreateEvent
        '
        Me.btnCreateEvent.Location = New System.Drawing.Point(237, 210)
        Me.btnCreateEvent.Name = "btnCreateEvent"
        Me.btnCreateEvent.Size = New System.Drawing.Size(103, 27)
        Me.btnCreateEvent.TabIndex = 8
        Me.btnCreateEvent.Text = "Create Event"
        Me.btnCreateEvent.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtEventName)
        Me.GroupBox2.Controls.Add(Me.txtEventDate)
        Me.GroupBox2.Controls.Add(Me.txtStartTime)
        Me.GroupBox2.Controls.Add(Me.txtEndTime)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 243)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Event Information"
        '
        'txtEventName
        '
        Me.txtEventName.Location = New System.Drawing.Point(87, 43)
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.Size = New System.Drawing.Size(100, 23)
        Me.txtEventName.TabIndex = 1
        '
        'txtEventDate
        '
        Me.txtEventDate.Location = New System.Drawing.Point(87, 83)
        Me.txtEventDate.Name = "txtEventDate"
        Me.txtEventDate.Size = New System.Drawing.Size(100, 23)
        Me.txtEventDate.TabIndex = 3
        '
        'txtStartTime
        '
        Me.txtStartTime.Location = New System.Drawing.Point(87, 124)
        Me.txtStartTime.Name = "txtStartTime"
        Me.txtStartTime.Size = New System.Drawing.Size(100, 23)
        Me.txtStartTime.TabIndex = 5
        '
        'txtEndTime
        '
        Me.txtEndTime.Location = New System.Drawing.Point(87, 161)
        Me.txtEndTime.Name = "txtEndTime"
        Me.txtEndTime.Size = New System.Drawing.Size(100, 23)
        Me.txtEndTime.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 15)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Event Name:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(18, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 15)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Event Date:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(22, 133)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 15)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Start Time:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(27, 169)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 15)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "End Time:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(237, 49)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(288, 148)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Event Description"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(338, 67)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 23)
        Me.TextBox3.TabIndex = 60
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(464, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(338, 36)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 23)
        Me.TextBox4.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(267, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Volunteer ID:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(267, 70)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(38, 13)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "Hours:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 6)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(171, 13)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Select Event Participated In:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(8, 6)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(0, 13)
        Me.Label27.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 22)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(198, 95)
        Me.ListBox1.TabIndex = 0
        '
        'frmVolunteer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 16)
        Me.ClientSize = New System.Drawing.Size(596, 493)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmVolunteer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Volunteer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmVolunteer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect.ConnectionString = "Data Source=""C:\CAMODATA\CAMO.mdb""; Provider=""Microsoft.Jet.OLEDB.4.0"""

        Dim getData As New OleDbCommand

        getData.CommandText = "SELECT  EventID, Event from tblVolunteerEvent"

        getData.Parameters.Add(New OleDbParameter("EventID", "EventID"))
        getData.Parameters.Add(New OleDbParameter("Event", "Event"))
        'getData.Parameters("EventID").Value = txtEventID.Text

        getData.Connection = Connect

        Connect.Open()
        Dim reader As OleDbDataReader = getData.ExecuteReader

        reader.Read()

        Do
            LstEvent.Items.Add(reader(0) & "    " & reader(1))

        Loop While reader.Read

        reader.Close()
        Connect.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Enter data into database using OLE

        Dim enterData As New OleDbCommand
        enterData.CommandText = "INSERT INTO tblPerson ( FirstName, MiddleInitial, LastName , Address1 , Address2, City , State, Zip, PrimaryPhone, AltPhone, Email ) VALUES (?,?,?,?,?,?,?,?,?,?,?)"

        enterData.Parameters.Add(New OleDbParameter("FirstName", "FirstName"))
        enterData.Parameters.Add(New OleDbParameter("MiddleInitial", "MiddleInitial"))
        enterData.Parameters.Add(New OleDbParameter("LastName", "LastName"))
        enterData.Parameters.Add(New OleDbParameter("Address1", "Address1"))
        enterData.Parameters.Add(New OleDbParameter("Address2", "Address2"))
        enterData.Parameters.Add(New OleDbParameter("City", "City"))
        enterData.Parameters.Add(New OleDbParameter("State", "State "))
        enterData.Parameters.Add(New OleDbParameter("Zip", "Zip"))
        enterData.Parameters.Add(New OleDbParameter("PrimaryPhone", "PrimaryPhone"))
        enterData.Parameters.Add(New OleDbParameter("AltPhone", "AltPhone"))
        enterData.Parameters.Add(New OleDbParameter("Email", "Email"))

        'enterData.Parameters.Add(New OleDbParameter("LoginName", "LoginName"))
        'enterData.Parameters.Add(new OleDbParameter("FirstName", system.Data.OleDb.OleDbType.VarWChar, 50, "FirstName")

        enterData.Parameters("FirstName").Value = txtFirstName.Text
        enterData.Parameters("MiddleInitial").Value = txtMidInitial.Text
        enterData.Parameters("LastName").Value = txtLastName.Text
        enterData.Parameters("Address1").Value = txtAddress1.Text
        enterData.Parameters("Address2").Value = txtAddress2.Text
        enterData.Parameters("City").Value = txtCity.Text
        enterData.Parameters("State").Value = txtState.Text
        enterData.Parameters("Zip").Value = txtZipCode.Text
        enterData.Parameters("PrimaryPhone").Value = txtPhone1.Text
        enterData.Parameters("AltPhone").Value = txtPhone2.Text
        enterData.Parameters("Email").Value = txtEmail.Text

        'enterData.Parameters("LoginName").Value = txtLoginName.Text

        enterData.Connection = Connect

        Connect.Open()

        enterData.ExecuteNonQuery()
        Connect.Close()
        MsgBox("Created")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()


    End Sub

    Private Sub btnCreateEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateEvent.Click
        Dim enterData As New OleDbCommand
        enterData.CommandText = "INSERT INTO tblVolunteerEvent ( Event, eventDate , startTime , endTime , EventDescription) VALUES (?,?,?,?,?)"

        ' enterData.Parameters.Add(New OleDbParameter("EventID", "EventID"))
        enterData.Parameters.Add(New OleDbParameter("Event", "Event"))
        enterData.Parameters.Add(New OleDbParameter("eventDate", "eventDate"))
        enterData.Parameters.Add(New OleDbParameter("startTime", "startTime"))
        enterData.Parameters.Add(New OleDbParameter("endTime", "endTime"))
        enterData.Parameters.Add(New OleDbParameter("EventDescription", "EventDescription"))

        ' enterData.Parameters("EventID").Value = txtEventID.Text
        enterData.Parameters("Event").Value = txtEventName.Text
        enterData.Parameters("eventDate").Value = txtEventDate.Text
        enterData.Parameters("startTime").Value = txtStartTime.Text
        enterData.Parameters("endTime").Value = txtEndTime.Text
        enterData.Parameters("EventDescription").Value = rtxtboxEventDesc.Text
        'enterData.Parameters("LoginName").Value = txtLoginName.Text

        enterData.Connection = Connect

        Connect.Open()

        enterData.ExecuteNonQuery()
        Connect.Close()
        MsgBox("Created")

    End Sub

    Private Sub btnEventSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchEvent.Click
        Dim getData As New OleDbCommand

        getData.CommandText = "SELECT  Event, eventDate , startTime , endTime , EventDescription  from tblVolunteerEvent WHERE EventID=?"

        getData.Parameters.Add(New OleDbParameter("EventID", "EventID"))

        getData.Parameters("EventID").Value = txtEventID.Text

        getData.Connection = Connect

        Connect.Open()
        Dim reader As OleDbDataReader = getData.ExecuteReader

        reader.Read()

        If reader.HasRows = True Then
            txtEventName.Text = reader(0)
            txtEventDate.Text = reader(1)
            txtStartTime.Text = reader(2)
            txtEndTime.Text = reader(3)
            rtxtboxEventDesc.Text = reader(4)

        End If

        reader.Close()
        Connect.Close()
    End Sub
    Public Function disable() As Boolean
        'txtClientID.Enabled = False
        txtFirstName.Enabled = False
        txtMidInitial.Enabled = False
        txtLastName.Enabled = False
        txtAddress1.Enabled = False
        txtAddress2.Enabled = False
        txtCity.Enabled = False
        txtState.Enabled = False
        txtZipCode.Enabled = False
        txtPhone1.Enabled = False
        txtPhone2.Enabled = False
        txtEmail.Enabled = False

    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim getData As New OleDbCommand
        If txtEnterID.Text = "" Then
            MsgBox("Please type the ID to search")
            Exit Sub
        End If
        'disable()

        getData.CommandText = "SELECT  FirstName, MiddleInitial, LastName , Address1 , Address2, City , State, Zip, PrimaryPhone, AltPhone, Email from tblPerson WHERE ClientID=?"

        getData.Parameters.Add(New OleDbParameter("ClientID", "ClientID"))

        getData.Parameters("ClientID").Value = txtEnterID.Text

        getData.Connection = Connect

        Connect.Open()
        Dim reader As OleDbDataReader = getData.ExecuteReader

        reader.Read()

        If reader.HasRows = True Then
            txtFirstName.Text = reader(0)
            txtMidInitial.Text = reader(1)
            txtLastName.Text = reader(2)
            txtAddress1.Text = reader(3)
            txtAddress2.Text = reader(4)
            txtCity.Text = reader(5)
            txtState.Text = reader(6)
            txtZipCode.Text = reader(7)
            txtPhone1.Text = reader(8)
            txtPhone2.Text = reader(9)
            txtEmail.Text = reader(10)
        End If

        reader.Close()
        Connect.Close()

    End Sub

    Private Sub txtEnterID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEnterID.TextChanged

    End Sub

    Private Sub btnModifyEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifyEvent.Click
        Dim updateData As New OleDbCommand
        If txtEventID.Text = "" Then
            MsgBox("Please select a record to modify")
            Exit Sub
        End If

        updateData.Connection = Connect
        'enabletext()
        Dim sqlString As String
        sqlString = " UPDATE tblVolunteerEvent SET Event='" & txtEventName.Text & "', eventDate = '" & txtEventDate.Text & "', startTime = '" & txtStartTime.Text & "', endTime = '" & txtEndTime.Text & "', EventDescription = '" & rtxtboxEventDesc.Text & "' where EventID=?"
        updateData.CommandText = sqlString

        updateData.Parameters.Add(New OleDbParameter("EventID", System.Data.OleDb.OleDbType.Integer))
        updateData.Parameters(0).Value = Int(txtEventID.Text)
        Connect.Open()
        updateData.ExecuteNonQuery()
        Connect.Close()
        MessageBox.Show("Updated")
    End Sub

    Private Sub btnDeleteEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteEvent.Click
        Dim DeleteData As New OleDbCommand
        DeleteData.CommandText = "DELETE FROM tblVolunteerEvent where EventID = ?"

        ' enterData.Parameters.Add(New OleDbParameter("EventID", "EventID"))
        DeleteData.Parameters.Add(New OleDbParameter("EventID", "EventID"))

        ' enterData.Parameters("EventID").Value = txtEventID.Text
        DeleteData.Parameters("EventID").Value = txtEventName.Text


        'enterData.Parameters("LoginName").Value = txtLoginName.Text

        DeleteData.Connection = Connect

        Connect.Open()

        DeleteData.ExecuteNonQuery()
        Connect.Close()
        MsgBox("Deleted")
    End Sub




    Public Function enabletext() As Boolean
        'txtClientID.Enabled = True
        txtFirstName.Enabled = True
        txtMidInitial.Enabled = True
        txtLastName.Enabled = True
        txtAddress1.Enabled = True
        txtAddress2.Enabled = True
        txtCity.Enabled = True
        txtState.Enabled = True
        txtZipCode.Enabled = True
        txtPhone1.Enabled = True
        txtPhone2.Enabled = True
        txtEmail.Enabled = True

    End Function
    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Connect.ConnectionString = "Data Source=""C:\CAMODATA\CAMO.mdb""; Provider=""Microsoft.Jet.OLEDB.4.0"""
        Dim updateData As New OleDbCommand
        If txtEnterID.Text = "" Then
            MsgBox("Please select a record to modify")
            Exit Sub
        End If

        updateData.Connection = Connect
        'enabletext()
        Dim sqlString As String
        sqlString = " UPDATE tblPerson SET FirstName='" & txtFirstName.Text & "', MiddleInitial = '" & txtMidInitial.Text & "', LastName = '" & txtLastName.Text & "', Address1 = '" & txtAddress1.Text & "', Address2 = '" & txtAddress2.Text & "', City = '" & txtCity.Text & "', State = '" & txtState.Text & "', Zip = '" & txtZipCode.Text & "', PrimaryPhone = '" & txtPhone1.Text & "', AltPhone = '" & txtPhone2.Text & "', Email = '" & txtEmail.Text & "', TypeFK= '5' where ClientID=?"
        updateData.CommandText = sqlString

        updateData.Parameters.Add(New OleDbParameter("ClientID", System.Data.OleDb.OleDbType.Integer))
        updateData.Parameters(0).Value = Int(txtEnterID.Text)
        Connect.Open()
        updateData.ExecuteNonQuery()
        Connect.Close()
        MessageBox.Show("Updated")

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim enterData As New OleDbCommand
        Dim getdata As New OleDbCommand
        Dim temp As String
        Dim temp1 As Integer
        Dim tempdate As Date

        temp = LstEvent.SelectedItem
        temp1 = temp.Substring(0, 4)
        '        MsgBox(temp1)

        getdata.CommandText = "Select eventDate, EventID from tblVolunteerEvent where EventID = " & temp1 & ""

        getdata.Parameters.Add(New OleDbParameter("eventDate", "eventDate"))
        getdata.Parameters.Add(New OleDbParameter("EventID", "EventID"))
        getdata.Connection = Connect

        Connect.Open()
        Dim reader As OleDbDataReader = getdata.ExecuteReader

        reader.Read()

        If reader.HasRows = True Then
            If temp1 = reader(1) Then
                tempdate = CType(reader(0), Date)
                'MsgBox(tempdate)
            End If
        End If

        reader.Close()
        Connect.Close()

        enterData.CommandText = "INSERT INTO tblVolunteerDuties (EventDate,Duties,VolDutyID,Hours,EventFK) VALUES (?,?,?,?,?)"

        enterData.Parameters.Add(New OleDbParameter("EventDate", "EventDate"))
        enterData.Parameters.Add(New OleDbParameter("Duties", "Duties"))
        enterData.Parameters.Add(New OleDbParameter("VolDutyID", "VolDutyID"))
        enterData.Parameters.Add(New OleDbParameter("Hours", "Hours"))
        enterData.Parameters.Add(New OleDbParameter("EventFK", "EventFK"))

        enterData.Parameters("EventDate").Value = CDate(tempdate)
        enterData.Parameters("Duties").Value = txtDuty.Text
        enterData.Parameters("VolDutyID").Value = CInt(txtVolID.Text)
        enterData.Parameters("Hours").Value = CInt(txtHours.Text)
        enterData.Parameters("EventFK").Value = CInt(temp1)


        enterData.Connection = Connect

        Connect.Open()

        enterData.ExecuteNonQuery()
        Connect.Close()
        MsgBox("Information saved")
    End Sub

    Private Sub btnClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnClose2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose2.Click
        Me.Close()
    End Sub


    Public Function clearfield() As Boolean

        txtFirstName.Text = ""
        txtMidInitial.Text = ""
        txtLastName.Text = ""
        txtAddress1.Text = ""
        txtAddress2.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZipCode.Text = ""
        txtPhone1.Text = ""
        txtPhone2.Text = ""
        txtEmail.Text = ""
        
    End Function

    Public Function clearfield2() As Boolean

        txtEventName.Text = ""
        txtEventDate.Text = ""
        txtStartTime.Text = ""
        txtEndTime.Text = ""
        rtxtboxEventDesc.Text = ""
        
    End Function

    Public Function disable2() As Boolean

        txtEventName.Enabled = False
        txtEventDate.Enabled = False
        txtStartTime.Enabled = False
        txtEndTime.Enabled = False
        rtxtboxEventDesc.Enabled = False

    End Function

    Public Function enabletext2() As Boolean

        txtEventName.Enabled = True
        txtEventDate.Enabled = True
        txtStartTime.Enabled = True
        txtEndTime.Enabled = True
        rtxtboxEventDesc.Enabled = True

    End Function

    Public Function clearfield3() As Boolean

        txtVolID.Text = ""
        txtDuty.Text = ""
        txtHours.Text = ""

    End Function
    
    Public Function disable3() As Boolean

        txtVolID.Enabled = False
        txtDuty.Enabled = False
        txtHours.Enabled = False

    End Function


    Public Function enabletext3() As Boolean

        txtVolID.Enabled = True
        txtDuty.Enabled = True
        txtHours.Enabled = True

    End Function
End Class
