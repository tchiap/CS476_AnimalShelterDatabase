Public Class frmAnimal
    Inherits System.Windows.Forms.Form
    Private modMode As Boolean = False, addMode As Boolean = False
    Private dbConn As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + DBFILE)
    Private dbConn2 As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + DBFILE)
    Private dbCmd As OleDb.OleDbCommand
    Private dbCmd2 As OleDb.OleDbCommand

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
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtOldLogNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCHSNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCHSTagNo As System.Windows.Forms.TextBox
    Friend WithEvents rbtnGenderM As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnGenderF As System.Windows.Forms.RadioButton
    Friend WithEvents txtRescueID As System.Windows.Forms.TextBox
    Friend WithEvents txtEuthID As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents pboxPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents grpBasicInfo As System.Windows.Forms.GroupBox
    Friend WithEvents grpID As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chkAltered As System.Windows.Forms.CheckBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents chkDepositReq As System.Windows.Forms.CheckBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents rtxtNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cmbBreed As System.Windows.Forms.ComboBox
    Friend WithEvents tabAnimal As System.Windows.Forms.TabControl
    Friend WithEvents lsvIncidents As System.Windows.Forms.ListView
    Friend WithEvents lsvAdopt As System.Windows.Forms.ListView
    Friend WithEvents lsvReturn As System.Windows.Forms.ListView
    Friend WithEvents lsvMedical As System.Windows.Forms.ListView
    Friend WithEvents chkAvailToShow As System.Windows.Forms.CheckBox
    Friend WithEvents chkHealthAlert As System.Windows.Forms.CheckBox
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnModSave As System.Windows.Forms.Button
    Friend WithEvents btnKennelCard As System.Windows.Forms.Button
    Friend WithEvents sbarAnimal As System.Windows.Forms.StatusBar
    Friend WithEvents chkDeclawed As System.Windows.Forms.CheckBox
    Friend WithEvents chkExpired As System.Windows.Forms.CheckBox
    Friend WithEvents txtDBID As System.Windows.Forms.TextBox
    Friend WithEvents dlgFileOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents panel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents btnAddIncident As System.Windows.Forms.Button
    Friend WithEvents btnAdopt As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnMedical As System.Windows.Forms.Button
    Friend WithEvents txtDepositAmount As FlxMaskBox.FlexMaskEditBox
    Friend WithEvents txtDateDepRefund As FlxMaskBox.FlexMaskEditBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAnimal))
        Me.txtDBID = New System.Windows.Forms.TextBox
        Me.txtOldLogNo = New System.Windows.Forms.TextBox
        Me.txtCHSNo = New System.Windows.Forms.TextBox
        Me.txtCHSTagNo = New System.Windows.Forms.TextBox
        Me.tabAnimal = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lsvIncidents = New System.Windows.Forms.ListView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lsvAdopt = New System.Windows.Forms.ListView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.lsvReturn = New System.Windows.Forms.ListView
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.lsvMedical = New System.Windows.Forms.ListView
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.rtxtNotes = New System.Windows.Forms.RichTextBox
        Me.rbtnGenderM = New System.Windows.Forms.RadioButton
        Me.rbtnGenderF = New System.Windows.Forms.RadioButton
        Me.txtRescueID = New System.Windows.Forms.TextBox
        Me.txtEuthID = New System.Windows.Forms.TextBox
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtWeight = New System.Windows.Forms.TextBox
        Me.pboxPhoto = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.grpBasicInfo = New System.Windows.Forms.GroupBox
        Me.chkExpired = New System.Windows.Forms.CheckBox
        Me.chkDeclawed = New System.Windows.Forms.CheckBox
        Me.chkHealthAlert = New System.Windows.Forms.CheckBox
        Me.cmbBreed = New System.Windows.Forms.ComboBox
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.chkAltered = New System.Windows.Forms.CheckBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.chkAvailToShow = New System.Windows.Forms.CheckBox
        Me.grpID = New System.Windows.Forms.GroupBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.chkDepositReq = New System.Windows.Forms.CheckBox
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.btnModSave = New System.Windows.Forms.Button
        Me.btnKennelCard = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.sbarAnimal = New System.Windows.Forms.StatusBar
        Me.panel1 = New System.Windows.Forms.StatusBarPanel
        Me.dlgFileOpen = New System.Windows.Forms.OpenFileDialog
        Me.btnAddIncident = New System.Windows.Forms.Button
        Me.btnAdopt = New System.Windows.Forms.Button
        Me.btnReturn = New System.Windows.Forms.Button
        Me.btnMedical = New System.Windows.Forms.Button
        Me.txtDepositAmount = New FlxMaskBox.FlexMaskEditBox
        Me.txtDateDepRefund = New FlxMaskBox.FlexMaskEditBox
        Me.tabAnimal.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.grpBasicInfo.SuspendLayout()
        Me.grpID.SuspendLayout()
        CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDBID
        '
        Me.txtDBID.Enabled = False
        Me.txtDBID.Location = New System.Drawing.Point(88, 24)
        Me.txtDBID.Name = "txtDBID"
        Me.txtDBID.ReadOnly = True
        Me.txtDBID.Size = New System.Drawing.Size(80, 20)
        Me.txtDBID.TabIndex = 0
        Me.txtDBID.TabStop = False
        Me.txtDBID.Text = ""
        '
        'txtOldLogNo
        '
        Me.txtOldLogNo.Location = New System.Drawing.Point(88, 72)
        Me.txtOldLogNo.Name = "txtOldLogNo"
        Me.txtOldLogNo.Size = New System.Drawing.Size(80, 20)
        Me.txtOldLogNo.TabIndex = 2
        Me.txtOldLogNo.Text = ""
        '
        'txtCHSNo
        '
        Me.txtCHSNo.Location = New System.Drawing.Point(88, 48)
        Me.txtCHSNo.Name = "txtCHSNo"
        Me.txtCHSNo.Size = New System.Drawing.Size(80, 20)
        Me.txtCHSNo.TabIndex = 1
        Me.txtCHSNo.Text = ""
        '
        'txtCHSTagNo
        '
        Me.txtCHSTagNo.Location = New System.Drawing.Point(88, 96)
        Me.txtCHSTagNo.Name = "txtCHSTagNo"
        Me.txtCHSTagNo.Size = New System.Drawing.Size(80, 20)
        Me.txtCHSTagNo.TabIndex = 3
        Me.txtCHSTagNo.Text = ""
        '
        'tabAnimal
        '
        Me.tabAnimal.Controls.Add(Me.TabPage1)
        Me.tabAnimal.Controls.Add(Me.TabPage2)
        Me.tabAnimal.Controls.Add(Me.TabPage3)
        Me.tabAnimal.Controls.Add(Me.TabPage4)
        Me.tabAnimal.Controls.Add(Me.TabPage5)
        Me.tabAnimal.Location = New System.Drawing.Point(16, 280)
        Me.tabAnimal.Name = "tabAnimal"
        Me.tabAnimal.SelectedIndex = 0
        Me.tabAnimal.Size = New System.Drawing.Size(584, 224)
        Me.tabAnimal.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lsvIncidents)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(576, 198)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Incidents"
        '
        'lsvIncidents
        '
        Me.lsvIncidents.FullRowSelect = True
        Me.lsvIncidents.GridLines = True
        Me.lsvIncidents.Location = New System.Drawing.Point(8, 8)
        Me.lsvIncidents.MultiSelect = False
        Me.lsvIncidents.Name = "lsvIncidents"
        Me.lsvIncidents.Size = New System.Drawing.Size(560, 184)
        Me.lsvIncidents.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lsvIncidents.TabIndex = 20
        Me.lsvIncidents.View = System.Windows.Forms.View.Details
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lsvAdopt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(576, 198)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Adoptions"
        '
        'lsvAdopt
        '
        Me.lsvAdopt.FullRowSelect = True
        Me.lsvAdopt.GridLines = True
        Me.lsvAdopt.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvAdopt.Location = New System.Drawing.Point(8, 8)
        Me.lsvAdopt.MultiSelect = False
        Me.lsvAdopt.Name = "lsvAdopt"
        Me.lsvAdopt.Size = New System.Drawing.Size(560, 184)
        Me.lsvAdopt.TabIndex = 0
        Me.lsvAdopt.View = System.Windows.Forms.View.Details
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lsvReturn)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(576, 198)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Returns"
        '
        'lsvReturn
        '
        Me.lsvReturn.FullRowSelect = True
        Me.lsvReturn.GridLines = True
        Me.lsvReturn.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvReturn.Location = New System.Drawing.Point(8, 8)
        Me.lsvReturn.MultiSelect = False
        Me.lsvReturn.Name = "lsvReturn"
        Me.lsvReturn.Size = New System.Drawing.Size(560, 184)
        Me.lsvReturn.TabIndex = 0
        Me.lsvReturn.View = System.Windows.Forms.View.Details
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lsvMedical)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(576, 198)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Medical"
        '
        'lsvMedical
        '
        Me.lsvMedical.FullRowSelect = True
        Me.lsvMedical.GridLines = True
        Me.lsvMedical.Location = New System.Drawing.Point(8, 8)
        Me.lsvMedical.MultiSelect = False
        Me.lsvMedical.Name = "lsvMedical"
        Me.lsvMedical.Size = New System.Drawing.Size(560, 184)
        Me.lsvMedical.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lsvMedical.TabIndex = 0
        Me.lsvMedical.View = System.Windows.Forms.View.Details
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.rtxtNotes)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(576, 198)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Notes"
        '
        'rtxtNotes
        '
        Me.rtxtNotes.Location = New System.Drawing.Point(8, 8)
        Me.rtxtNotes.Name = "rtxtNotes"
        Me.rtxtNotes.Size = New System.Drawing.Size(560, 184)
        Me.rtxtNotes.TabIndex = 0
        Me.rtxtNotes.Text = ""
        '
        'rbtnGenderM
        '
        Me.rbtnGenderM.Location = New System.Drawing.Point(144, 120)
        Me.rbtnGenderM.Name = "rbtnGenderM"
        Me.rbtnGenderM.Size = New System.Drawing.Size(48, 16)
        Me.rbtnGenderM.TabIndex = 1
        Me.rbtnGenderM.Text = "Male"
        '
        'rbtnGenderF
        '
        Me.rbtnGenderF.Checked = True
        Me.rbtnGenderF.Location = New System.Drawing.Point(80, 120)
        Me.rbtnGenderF.Name = "rbtnGenderF"
        Me.rbtnGenderF.Size = New System.Drawing.Size(64, 16)
        Me.rbtnGenderF.TabIndex = 10
        Me.rbtnGenderF.TabStop = True
        Me.rbtnGenderF.Text = "Female"
        '
        'txtRescueID
        '
        Me.txtRescueID.Location = New System.Drawing.Point(88, 120)
        Me.txtRescueID.Name = "txtRescueID"
        Me.txtRescueID.Size = New System.Drawing.Size(80, 20)
        Me.txtRescueID.TabIndex = 4
        Me.txtRescueID.Text = ""
        '
        'txtEuthID
        '
        Me.txtEuthID.Location = New System.Drawing.Point(88, 144)
        Me.txtEuthID.Name = "txtEuthID"
        Me.txtEuthID.Size = New System.Drawing.Size(80, 20)
        Me.txtEuthID.TabIndex = 5
        Me.txtEuthID.Text = ""
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(72, 72)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(56, 20)
        Me.txtAge.TabIndex = 8
        Me.txtAge.Text = ""
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(72, 24)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(192, 20)
        Me.txtName.TabIndex = 6
        Me.txtName.Text = ""
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(72, 168)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(192, 64)
        Me.txtDescription.TabIndex = 12
        Me.txtDescription.Text = ""
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(72, 96)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(56, 20)
        Me.txtWeight.TabIndex = 9
        Me.txtWeight.Text = ""
        '
        'pboxPhoto
        '
        Me.pboxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pboxPhoto.Location = New System.Drawing.Point(272, 24)
        Me.pboxPhoto.Name = "pboxPhoto"
        Me.pboxPhoto.Size = New System.Drawing.Size(184, 208)
        Me.pboxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxPhoto.TabIndex = 16
        Me.pboxPhoto.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "DB ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "CHS Tag No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "CHS Log No.:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Old Log No.:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Location:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Name:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Description:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Weight:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(40, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Age:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(24, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Rescue ID:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 16)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Euth. ID:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 240)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 16)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Deposit Refunded:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 216)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 16)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Amount of Deposit:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpBasicInfo
        '
        Me.grpBasicInfo.Controls.Add(Me.chkExpired)
        Me.grpBasicInfo.Controls.Add(Me.chkDeclawed)
        Me.grpBasicInfo.Controls.Add(Me.chkHealthAlert)
        Me.grpBasicInfo.Controls.Add(Me.cmbBreed)
        Me.grpBasicInfo.Controls.Add(Me.txtLocation)
        Me.grpBasicInfo.Controls.Add(Me.chkAltered)
        Me.grpBasicInfo.Controls.Add(Me.Label16)
        Me.grpBasicInfo.Controls.Add(Me.Label15)
        Me.grpBasicInfo.Controls.Add(Me.Label8)
        Me.grpBasicInfo.Controls.Add(Me.Label6)
        Me.grpBasicInfo.Controls.Add(Me.Label9)
        Me.grpBasicInfo.Controls.Add(Me.txtWeight)
        Me.grpBasicInfo.Controls.Add(Me.txtDescription)
        Me.grpBasicInfo.Controls.Add(Me.txtAge)
        Me.grpBasicInfo.Controls.Add(Me.txtName)
        Me.grpBasicInfo.Controls.Add(Me.Label5)
        Me.grpBasicInfo.Controls.Add(Me.rbtnGenderM)
        Me.grpBasicInfo.Controls.Add(Me.rbtnGenderF)
        Me.grpBasicInfo.Controls.Add(Me.pboxPhoto)
        Me.grpBasicInfo.Controls.Add(Me.Label7)
        Me.grpBasicInfo.Controls.Add(Me.chkAvailToShow)
        Me.grpBasicInfo.Location = New System.Drawing.Point(240, 8)
        Me.grpBasicInfo.Name = "grpBasicInfo"
        Me.grpBasicInfo.Size = New System.Drawing.Size(464, 264)
        Me.grpBasicInfo.TabIndex = 7
        Me.grpBasicInfo.TabStop = False
        Me.grpBasicInfo.Text = "Basic Information"
        '
        'chkExpired
        '
        Me.chkExpired.Location = New System.Drawing.Point(24, 240)
        Me.chkExpired.Name = "chkExpired"
        Me.chkExpired.Size = New System.Drawing.Size(64, 16)
        Me.chkExpired.TabIndex = 13
        Me.chkExpired.Text = "Expired"
        '
        'chkDeclawed
        '
        Me.chkDeclawed.Location = New System.Drawing.Point(112, 240)
        Me.chkDeclawed.Name = "chkDeclawed"
        Me.chkDeclawed.Size = New System.Drawing.Size(80, 16)
        Me.chkDeclawed.TabIndex = 14
        Me.chkDeclawed.Text = "Declawed"
        '
        'chkHealthAlert
        '
        Me.chkHealthAlert.Location = New System.Drawing.Point(216, 240)
        Me.chkHealthAlert.Name = "chkHealthAlert"
        Me.chkHealthAlert.Size = New System.Drawing.Size(88, 16)
        Me.chkHealthAlert.TabIndex = 15
        Me.chkHealthAlert.Text = "Health Alert"
        '
        'cmbBreed
        '
        Me.cmbBreed.Location = New System.Drawing.Point(72, 48)
        Me.cmbBreed.Name = "cmbBreed"
        Me.cmbBreed.Size = New System.Drawing.Size(192, 21)
        Me.cmbBreed.TabIndex = 7
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(72, 144)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(192, 20)
        Me.txtLocation.TabIndex = 11
        Me.txtLocation.Text = ""
        '
        'chkAltered
        '
        Me.chkAltered.Location = New System.Drawing.Point(200, 120)
        Me.chkAltered.Name = "chkAltered"
        Me.chkAltered.Size = New System.Drawing.Size(64, 16)
        Me.chkAltered.TabIndex = 29
        Me.chkAltered.TabStop = False
        Me.chkAltered.Text = "Altered"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(24, 120)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 16)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Gender:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 16)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Breed:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAvailToShow
        '
        Me.chkAvailToShow.Location = New System.Drawing.Point(328, 240)
        Me.chkAvailToShow.Name = "chkAvailToShow"
        Me.chkAvailToShow.Size = New System.Drawing.Size(120, 16)
        Me.chkAvailToShow.TabIndex = 16
        Me.chkAvailToShow.Text = "Available to Show?"
        '
        'grpID
        '
        Me.grpID.Controls.Add(Me.btnSearch)
        Me.grpID.Controls.Add(Me.txtDBID)
        Me.grpID.Controls.Add(Me.Label4)
        Me.grpID.Controls.Add(Me.Label1)
        Me.grpID.Controls.Add(Me.txtOldLogNo)
        Me.grpID.Controls.Add(Me.txtCHSNo)
        Me.grpID.Controls.Add(Me.txtCHSTagNo)
        Me.grpID.Controls.Add(Me.Label3)
        Me.grpID.Controls.Add(Me.Label2)
        Me.grpID.Controls.Add(Me.Label11)
        Me.grpID.Controls.Add(Me.txtRescueID)
        Me.grpID.Controls.Add(Me.Label12)
        Me.grpID.Controls.Add(Me.txtEuthID)
        Me.grpID.Location = New System.Drawing.Point(8, 8)
        Me.grpID.Name = "grpID"
        Me.grpID.Size = New System.Drawing.Size(224, 176)
        Me.grpID.TabIndex = 32
        Me.grpID.TabStop = False
        Me.grpID.Text = "Identification"
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(176, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(32, 24)
        Me.btnSearch.TabIndex = 29
        '
        'chkDepositReq
        '
        Me.chkDepositReq.Location = New System.Drawing.Point(16, 192)
        Me.chkDepositReq.Name = "chkDepositReq"
        Me.chkDepositReq.Size = New System.Drawing.Size(112, 16)
        Me.chkDepositReq.TabIndex = 17
        Me.chkDepositReq.Text = "Deposit Required"
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(616, 304)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 32)
        Me.btnAddNew.TabIndex = 34
        Me.btnAddNew.TabStop = False
        Me.btnAddNew.Text = "Add New"
        '
        'btnModSave
        '
        Me.btnModSave.Location = New System.Drawing.Point(616, 360)
        Me.btnModSave.Name = "btnModSave"
        Me.btnModSave.Size = New System.Drawing.Size(80, 32)
        Me.btnModSave.TabIndex = 35
        Me.btnModSave.TabStop = False
        Me.btnModSave.Text = "Modify This"
        '
        'btnKennelCard
        '
        Me.btnKennelCard.Location = New System.Drawing.Point(616, 416)
        Me.btnKennelCard.Name = "btnKennelCard"
        Me.btnKennelCard.Size = New System.Drawing.Size(80, 32)
        Me.btnKennelCard.TabIndex = 36
        Me.btnKennelCard.TabStop = False
        Me.btnKennelCard.Text = "Kennel Card"
        Me.btnKennelCard.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(616, 472)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 32)
        Me.btnClose.TabIndex = 37
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Close"
        '
        'sbarAnimal
        '
        Me.sbarAnimal.Location = New System.Drawing.Point(0, 549)
        Me.sbarAnimal.Name = "sbarAnimal"
        Me.sbarAnimal.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.panel1})
        Me.sbarAnimal.ShowPanels = True
        Me.sbarAnimal.Size = New System.Drawing.Size(712, 24)
        Me.sbarAnimal.TabIndex = 38
        '
        'panel1
        '
        Me.panel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.panel1.Width = 696
        '
        'dlgFileOpen
        '
        Me.dlgFileOpen.Filter = "All Picture Files (*.bmp,*.gif,*.jpg,*.jpeg,*.png)|*.bmp;*.gif;*jpg;*.jpeg;*.png|" & _
        "All Files (*.*)|*.*"
        Me.dlgFileOpen.Title = "Choose Animal Photo"
        '
        'btnAddIncident
        '
        Me.btnAddIncident.Location = New System.Drawing.Point(56, 512)
        Me.btnAddIncident.Name = "btnAddIncident"
        Me.btnAddIncident.Size = New System.Drawing.Size(96, 32)
        Me.btnAddIncident.TabIndex = 39
        Me.btnAddIncident.Text = "Add Incident"
        Me.btnAddIncident.Visible = False
        '
        'btnAdopt
        '
        Me.btnAdopt.Location = New System.Drawing.Point(192, 512)
        Me.btnAdopt.Name = "btnAdopt"
        Me.btnAdopt.Size = New System.Drawing.Size(96, 32)
        Me.btnAdopt.TabIndex = 40
        Me.btnAdopt.Text = "Adopt Animal"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(328, 512)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(96, 32)
        Me.btnReturn.TabIndex = 41
        Me.btnReturn.Text = "Return Animal"
        '
        'btnMedical
        '
        Me.btnMedical.Location = New System.Drawing.Point(464, 512)
        Me.btnMedical.Name = "btnMedical"
        Me.btnMedical.Size = New System.Drawing.Size(96, 32)
        Me.btnMedical.TabIndex = 42
        Me.btnMedical.Text = "Add Medical"
        Me.btnMedical.Visible = False
        '
        'txtDepositAmount
        '
        Me.txtDepositAmount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDepositAmount.Location = New System.Drawing.Point(120, 216)
        Me.txtDepositAmount.Mask = "###d##"
        Me.txtDepositAmount.Name = "txtDepositAmount"
        Me.txtDepositAmount.Size = New System.Drawing.Size(72, 20)
        Me.txtDepositAmount.TabIndex = 43
        '
        'txtDateDepRefund
        '
        Me.txtDateDepRefund.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDateDepRefund.Location = New System.Drawing.Point(120, 240)
        Me.txtDateDepRefund.Mask = "##s##s####"
        Me.txtDateDepRefund.Name = "txtDateDepRefund"
        Me.txtDateDepRefund.Size = New System.Drawing.Size(72, 20)
        Me.txtDateDepRefund.TabIndex = 44
        '
        'frmAnimal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(712, 573)
        Me.Controls.Add(Me.txtDateDepRefund)
        Me.Controls.Add(Me.txtDepositAmount)
        Me.Controls.Add(Me.btnMedical)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnAdopt)
        Me.Controls.Add(Me.btnAddIncident)
        Me.Controls.Add(Me.sbarAnimal)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnKennelCard)
        Me.Controls.Add(Me.btnModSave)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.chkDepositReq)
        Me.Controls.Add(Me.grpBasicInfo)
        Me.Controls.Add(Me.grpID)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tabAnimal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAnimal"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Animal Edit"
        Me.tabAnimal.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.grpBasicInfo.ResumeLayout(False)
        Me.grpID.ResumeLayout(False)
        CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim sqlCmd As String
        Dim tmpField As SelectField
        Dim rdrResult As Data.OleDb.OleDbDataReader
        Dim frmSearch As New frmSearchDlg
        Dim sel As ListViewItem = Nothing

        arrSearchFields.Clear()
        arrSearchFields.Add(New SelectField("AnimalID", "Animal ID", INT_FIELD))
        arrSearchFields.Add(New SelectField("CHSNumber", "Log Number", STRING_FIELD))
        arrSearchFields.Add(New SelectField("AnimalName", "Name", STRING_FIELD))
        sqlCmd = "SELECT TOP 100 AnimalID,CHSTagNumber,AnimalName from tblAnimalPrimary"
        If dbConn.State = ConnectionState.Closed Then dbConn.Open()
        dbCmd = New OleDb.OleDbCommand(sqlCmd, dbConn)
        rdrResult = dbCmd.ExecuteReader()
        frmSearch.Init(rdrResult)

        rdrResult.Close()
        sel = frmSearch.Display("tblAnimalPrimary")
        If Not sel Is Nothing Then
            tmpField = arrSearchFields(0)
            sqlCmd = "SELECT * FROM tblAnimalPrimary WHERE " + tmpField.getFieldName + " = " + sel.Text
            try
                dbCmd = New OleDb.OleDbCommand(sqlCmd, dbConn)
                rdrResult = dbCmd.ExecuteReader(CommandBehavior.SingleRow)
                Me.PopulateFields(rdrResult)
                rdrResult.Close()
            Catch ex As Exception

            End Try
            dbConn.Close()
        End If
    End Sub

    Private Sub ClearFields()
        Me.txtAge.Text = ""
        Me.txtCHSNo.Text = ""
        Me.txtCHSTagNo.Text = ""
        Me.txtDateDepRefund.Text = ""
        Me.txtDepositAmount.Text = ""
        Me.txtDescription.Text = ""
        Me.txtEuthID.Text = ""
        Me.txtLocation.Text = ""
        Me.txtDBID.Text = ""
        Me.txtName.Text = ""
        Me.txtOldLogNo.Text = ""
        Me.txtRescueID.Text = ""
        Me.txtWeight.Text = ""
        Me.chkAltered.Checked = False
        Me.chkDepositReq.Checked = False
        Me.chkExpired.Checked = False
        Me.cmbBreed.Text = ""
        Me.rbtnGenderF.Checked = True
        Me.pboxPhoto.Image = Nothing
        Me.lsvIncidents.Items.Clear()
        Me.lsvMedical.Items.Clear()
        Me.lsvReturn.Items.Clear()
        Me.lsvAdopt.Items.Clear()
        Me.btnAddNew.Enabled = True
        Me.btnModSave.Enabled = False
        Me.btnKennelCard.Enabled = False
    End Sub

    Public Sub PopulateFields(ByVal inRec As Data.OleDb.OleDbDataReader)
        Dim sqlCmd As String
        Dim rdrIncidents As Data.OleDb.OleDbDataReader
        Dim rdrBreed As Data.OleDb.OleDbDataReader
        Dim arrIncidents As ArrayList = New ArrayList
        Dim tmpIncident As Incident
        Dim c As Integer
        Dim entry, entryClone As ListViewItem
        Dim entryString As String
        Dim incidentEnum As System.Collections.IEnumerator

        If inRec.Read() Then
            Me.txtDBID.Text = FieldToString(inRec, 0)
            Me.txtCHSNo.Text = FieldToString(inRec, 1)
            Me.txtCHSTagNo.Text = FieldToString(inRec, 2)
            Me.cmbBreed.SelectedIndex = inRec.GetInt16(3)
            Me.cmbBreed.Text = FieldToString(inRec, 3)
            If FieldToString(inRec, 4).Equals("F") Then Me.rbtnGenderF.Checked = True Else Me.rbtnGenderM.Checked = True
            Me.txtAge.Text = FieldToString(inRec, 5)
            Me.txtWeight.Text = FieldToString(inRec, 6)
            Me.txtDescription.Text = FieldToString(inRec, 7)
            If FieldToString(inRec, 8).Equals("T") Then Me.chkDeclawed.Checked = True Else Me.chkDeclawed.Checked = False
            If FieldToString(inRec, 9).Equals("T") Then Me.chkAltered.Checked = True Else Me.chkAltered.Checked = False
            Me.txtName.Text = FieldToString(inRec, 10)
            Me.txtOldLogNo.Text = FieldToString(inRec, 11)
            Me.txtLocation.Text = FieldToString(inRec, 12)
            If FieldToString(inRec, 13).Equals("T") Then Me.chkAvailToShow.Checked = True Else Me.chkAvailToShow.Checked = False
            If FieldToString(inRec, 14).Equals("T") Then Me.chkHealthAlert.Checked = True Else Me.chkHealthAlert.Checked = False
            Me.txtDepositAmount.Text = FieldToString(inRec, 15)
            If FieldToString(inRec, 16).Equals("T") Then Me.chkExpired.Checked = True Else Me.chkExpired.Checked = False
            If FieldToString(inRec, 17).Equals("T") Then Me.chkDepositReq.Checked = True Else Me.chkDepositReq.Checked = False
            Me.txtEuthID.Text = FieldToString(inRec, 18)
            Me.txtRescueID.Text = FieldToString(inRec, 19)
            Me.rtxtNotes.Text = FieldToString(inRec, 20)
            If Not FieldToString(inRec, 21).Equals("01/01/1900") Then Me.txtDateDepRefund.Text = FieldToString(inRec, 21)
            If (inRec.GetBoolean(16) = True) Then
                Me.btnReturn.Enabled = False
                Me.btnAdopt.Enabled = False
            ElseIf (inRec.GetBoolean(22) = True) Then
                Me.btnAdopt.Enabled = False
                Me.btnReturn.Enabled = True
            Else : Me.btnAdopt.Enabled = True
            End If
            Me.LockFields()
            inRec.Close()
            dbConn.Close()

            sqlCmd = "SELECT IncidentID,AnimalLogNumber,IncidentDate,IncidentType,Description FROM tblIncident WHERE AnimalLogNumber = " + Chr(34) + Me.txtCHSNo.Text + Chr(34) + " ORDER BY IncidentID"
            dbConn.Open()
            dbCmd = New Data.OleDb.OleDbCommand(sqlCmd, dbConn)
            rdrIncidents = dbCmd.ExecuteReader()
            arrIncidents.Clear()
            Me.lsvAdopt.Items.Clear()
            Me.lsvIncidents.Items.Clear()
            Me.lsvMedical.Items.Clear()
            Me.lsvReturn.Items.Clear()

            lsvIncidents.Columns.Add("Incident ID", -2, HorizontalAlignment.Left)
            lsvIncidents.Columns.Add("Type", -2, HorizontalAlignment.Left)
            lsvIncidents.Columns.Add("Date", -2, HorizontalAlignment.Left)
            lsvIncidents.Columns.Add("Description", -2, HorizontalAlignment.Left)
            lsvIncidents.Columns(0).Width = 80
            lsvIncidents.Columns(1).Width = 80
            lsvIncidents.Columns(2).Width = 80
            lsvIncidents.Columns(3).Width = 320

            lsvAdopt.Columns.Add("Incident ID", -2, HorizontalAlignment.Left)
            lsvAdopt.Columns.Add("Type", -2, HorizontalAlignment.Left)
            lsvAdopt.Columns.Add("Date", -2, HorizontalAlignment.Left)
            lsvAdopt.Columns.Add("Description", -2, HorizontalAlignment.Left)
            lsvAdopt.Columns(0).Width = 80
            lsvAdopt.Columns(1).Width = 80
            lsvAdopt.Columns(2).Width = 80
            lsvAdopt.Columns(3).Width = 320

            lsvReturn.Columns.Add("Incident ID", -2, HorizontalAlignment.Left)
            lsvReturn.Columns.Add("Type", -2, HorizontalAlignment.Left)
            lsvReturn.Columns.Add("Date", -2, HorizontalAlignment.Left)
            lsvReturn.Columns.Add("Description", -2, HorizontalAlignment.Left)
            lsvReturn.Columns(0).Width = 80
            lsvReturn.Columns(1).Width = 80
            lsvReturn.Columns(2).Width = 80
            lsvReturn.Columns(3).Width = 318

            lsvMedical.Columns.Add("Incident ID", -2, HorizontalAlignment.Left)
            lsvMedical.Columns.Add("Type", -2, HorizontalAlignment.Left)
            lsvMedical.Columns.Add("Date", -2, HorizontalAlignment.Left)
            lsvMedical.Columns.Add("Description", -2, HorizontalAlignment.Left)
            lsvMedical.Columns(0).Width = 80
            lsvMedical.Columns(1).Width = 80
            lsvMedical.Columns(2).Width = 80
            lsvMedical.Columns(3).Width = 318

            While rdrIncidents.Read()
                tmpIncident = New Incident(rdrIncidents.GetInt32(0), rdrIncidents.GetString(1), rdrIncidents.GetDateTime(2).Date, rdrIncidents.GetInt16(3), rdrIncidents.GetString(4))
                arrIncidents.Add(tmpIncident)

                tmpIncident = Nothing
            End While
            rdrIncidents.Close()
            dbConn.Close()

            incidentEnum = arrIncidents.GetEnumerator()
            While incidentEnum.MoveNext()
                tmpIncident = CType(incidentEnum.Current, Incident)
                entry = New ListViewItem(tmpIncident.getIncidentID().ToString())
                entry.SubItems.Add(iTypeDesc(tmpIncident.getIncidentType()))
                entry.SubItems.Add(tmpIncident.getDate().ToString("MM/dd/yyyy"))
                entry.SubItems.Add(tmpIncident.getDescription())
                lsvIncidents.Items.Add(entry)
                entryClone = entry.Clone()

                Select Case tmpIncident.getIncidentType()
                    Case ITYPE_ADOPT
                        lsvAdopt.Items.Add(entryClone)
                    Case ITYPE_RETURN
                        lsvReturn.Items.Add(entryClone)
                    Case ITYPE_MEDICAL
                        lsvMedical.Items.Add(entryClone)
                End Select
                entry = Nothing
            End While

            If currentUser.canModifyAnimal Then
                Me.btnModSave.Enabled = True
                Me.btnAddIncident.Enabled = True
                Me.btnMedical.Enabled = True
            Else
                Me.btnModSave.Enabled = False
                Me.btnAddIncident.Enabled = False
                Me.btnMedical.Enabled = False
            End If

            Me.sbarAnimal.Panels(0).Text = "Record loaded."
            Me.sbarAnimal.Refresh()
            dbConn.Close()
            Me.Text = "Animal Edit (" + Me.txtName.Text + ")"
        End If
    End Sub

    Private Sub SaveRecord(ByVal saveType As Byte)
        Dim sqlCmd As String

        dbConn.Open()
        If Me.ValidateEntry() Then
            If saveType = SAVE_MOD_REC Then
                sqlCmd = "UPDATE tblAnimalPrimary SET CHSNumber='" + Me.txtCHSNo.Text.Trim() + _
                "',CHSTagNumber='" + Me.txtCHSTagNo.Text.Trim() + "',Breed=" + Me.cmbBreed.SelectedIndex.ToString() + _
                ",Altered=" + Me.chkAltered.Checked.ToString() + ",Sex='"

                If Me.rbtnGenderF.Checked Then sqlCmd = sqlCmd + "F'" Else sqlCmd = sqlCmd + "M'"
                sqlCmd = sqlCmd + ",Age=" + Me.txtAge.Text.Trim() + ",Weight=" + Me.txtWeight.Text.Trim() + "," + _
                "Description='" + Me.txtDescription.Text + "',AnimalName='" + Me.txtName.Text.Trim() + "'," + _
                "OldLogNumber='" + Me.txtOldLogNo.Text.Trim() + "',AnLocation='" + Me.txtLocation.Text.Trim() + _
                ",Avail2Show=" + Me.chkAvailToShow.Checked.ToString() + ",HealthAlert=" + Me.chkHealthAlert.Checked.ToString() + _
                ",AmountOfDeposit=" + Me.txtDepositAmount.Text.Trim() + ",DepositRequired=" + Me.chkDepositReq.Checked.ToString() + _
                ",Notes='" + Me.rtxtNotes.Text + "',DepositRefundedDate=#" + Me.txtDateDepRefund.Text.Trim() + "# WHERE " + _
                "AnimalID = " + Me.txtDBID.Text
                dbCmd = New Data.OleDb.OleDbCommand(sqlCmd, dbConn)
            Else
                sqlCmd = "INSERT INTO tblAnimalPrimary (CHSNumber,CHSTagNumber,Breed,Sex,Age,Weight,Description,Declawed,Altered,AnimalName,OldLogNumber,AnLocation,Avail2Show,HealthAlert,AmountOfDeposit,AnimalExpired,DepositRequired,EuthID,RescueID,Notes,DepositRefundedDate,Adopted) VALUES (@chsNum,@chsTag,@breed,@sex,@age,@weight,@desc,@declaw,@alter,@name,@oldLog,@loc,@canShow,@hAlert,@depAmt,@expired,@depReq,@euthID,@rescueID,@notes,@depRefund,@adopted)"
                dbCmd = New Data.OleDb.OleDbCommand(sqlCmd, dbConn)

                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@chsNum", OleDb.OleDbType.VarChar))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@chsTag", OleDb.OleDbType.VarChar))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@breed", OleDb.OleDbType.Integer))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@sex", OleDb.OleDbType.VarChar))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@age", OleDb.OleDbType.Single))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@weight", OleDb.OleDbType.Single))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@desc", OleDb.OleDbType.VarChar))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@declaw", OleDb.OleDbType.Boolean))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@alter", OleDb.OleDbType.Boolean))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@name", OleDb.OleDbType.VarChar))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@oldLog", OleDb.OleDbType.VarChar))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@loc", OleDb.OleDbType.VarChar))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@canShow", OleDb.OleDbType.Boolean))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@hAlert", OleDb.OleDbType.Boolean))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@depAmount", OleDb.OleDbType.Double))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@expired", OleDb.OleDbType.Boolean))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@depReq", OleDb.OleDbType.Boolean))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@euthID", OleDb.OleDbType.Integer))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@rescueID", OleDb.OleDbType.Integer))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@notes", OleDb.OleDbType.VarChar))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@depRefund", OleDb.OleDbType.Date))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@adopted", OleDb.OleDbType.Boolean))

                dbCmd.Parameters("@chsNum").Value = Me.txtCHSNo.Text
                dbCmd.Parameters("@chsTag").Value = Me.txtCHSTagNo.Text
                dbCmd.Parameters("@breed").Value = Me.cmbBreed.SelectedIndex
                If Me.rbtnGenderF.Checked = True Then dbCmd.Parameters("@sex").Value = "F" Else dbCmd.Parameters("@sex").Value = "M"
                dbCmd.Parameters("@age").Value = CType(Me.txtAge.Text, Single)
                dbCmd.Parameters("@weight").Value = CType(Me.txtWeight.Text, Single)
                dbCmd.Parameters("@desc").Value = Me.txtDescription.Text
                dbCmd.Parameters("@declaw").Value = Me.chkDeclawed.Checked
                dbCmd.Parameters("@alter").Value = Me.chkAltered.Checked
                dbCmd.Parameters("@name").Value = Me.txtName.Text
                dbCmd.Parameters("@oldLog").Value = Me.txtOldLogNo.Text
                dbCmd.Parameters("@loc").Value = Me.txtLocation.Text
                dbCmd.Parameters("@canShow").Value = Me.chkAvailToShow.Checked
                dbCmd.Parameters("@hAlert").Value = Me.chkHealthAlert.Checked
                dbCmd.Parameters("@depAmount").Value = CType(Me.txtDepositAmount.Text, Double)
                dbCmd.Parameters("@expired").Value = Me.chkExpired.Checked
                dbCmd.Parameters("@depReq").Value = Me.chkDepositReq.Checked
                dbCmd.Parameters("@euthID").Value = CType(Me.txtEuthID.Text, Integer)
                dbCmd.Parameters("@rescueID").Value = CType(Me.txtRescueID.Text, Integer)
                dbCmd.Parameters("@notes").Value = Me.rtxtNotes.Text
                dbCmd.Parameters("@depRefund").Value = CType(Me.txtDateDepRefund.Text, Date)
                dbCmd.Parameters("@adopted").Value = False
            End If
            Try
                If dbCmd.ExecuteNonQuery() = 1 Then
                    Me.LockFields()
                    Me.lsvIncidents.Enabled = True
                    Me.lsvMedical.Enabled = True
                    Me.lsvReturn.Enabled = True
                    Me.btnModSave.Text = "Modify This"
                    Me.modMode = False
                    Me.addMode = False
                    Me.btnClose.Text = "Close"
                    Me.btnSearch.Enabled = True
                    Me.btnKennelCard.Enabled = True
                    Me.btnAddNew.Enabled = True
                    If currentUser.canAddAnimal Then Me.btnAddNew.Enabled = True Else Me.btnAddNew.Enabled = False
                    If currentUser.canModifyAnimal Then Me.btnModSave.Enabled = True Else Me.btnModSave.Enabled = False
                    Me.sbarAnimal.Panels(0).Text = "Record modifications saved."
                    Me.sbarAnimal.Refresh()
                Else
                    Me.sbarAnimal.Panels(0).Text = "Record modification failed (error during save)"
                    Me.sbarAnimal.Refresh()
                End If
                dbConn.Close()
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        End If
    End Sub

    Private Sub LockFields()
        Me.txtCHSNo.ReadOnly = True
        Me.txtCHSTagNo.ReadOnly = True
        Me.cmbBreed.Enabled = False
        Me.txtAge.ReadOnly = True
        Me.txtWeight.ReadOnly = True
        Me.txtDescription.ReadOnly = True
        Me.txtName.ReadOnly = True
        Me.txtOldLogNo.ReadOnly = True
        Me.txtLocation.ReadOnly = True
        Me.chkAvailToShow.Enabled = False
        Me.chkHealthAlert.Enabled = False
        Me.chkDeclawed.Enabled = False
        Me.txtDepositAmount.ReadOnly = True
        Me.chkDepositReq.Enabled = False
        Me.txtEuthID.ReadOnly = True
        Me.txtRescueID.ReadOnly = True
        Me.rtxtNotes.ReadOnly = True
        Me.txtDateDepRefund.ReadOnly = True
        Me.chkAltered.Enabled = False
        Me.chkExpired.Enabled = False
        Me.rbtnGenderF.Enabled = False
        Me.rbtnGenderM.Enabled = False
    End Sub

    Private Sub UnlockFields()
        Me.txtCHSNo.ReadOnly = False
        Me.txtCHSTagNo.ReadOnly = False
        Me.cmbBreed.Enabled = True
        Me.txtAge.ReadOnly = False
        Me.txtWeight.ReadOnly = False
        Me.txtDescription.ReadOnly = False
        Me.txtName.ReadOnly = False
        Me.txtOldLogNo.ReadOnly = False
        Me.txtLocation.ReadOnly = False
        Me.chkAvailToShow.Enabled = True
        Me.chkHealthAlert.Enabled = True
        Me.txtDepositAmount.ReadOnly = False
        Me.chkDepositReq.Enabled = True
        Me.txtEuthID.ReadOnly = False
        Me.txtRescueID.ReadOnly = False
        Me.rtxtNotes.ReadOnly = False
        Me.txtDateDepRefund.ReadOnly = False
        Me.chkAltered.Enabled = True
        Me.chkExpired.Enabled = True
        Me.chkDeclawed.Enabled = True
        Me.rbtnGenderF.Enabled = True
        Me.rbtnGenderM.Enabled = True
    End Sub

    Private Sub frmAnimal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rdrBreed As Data.OleDb.OleDbDataReader

        Me.btnModSave.Enabled = False
        If currentUser.canAddAnimal Then Me.btnAddNew.Enabled = True Else Me.btnAddNew.Enabled = False
        Me.btnAddIncident.Enabled = False
        Me.btnMedical.Enabled = False
        Me.btnReturn.Enabled = False
        Me.btnAdopt.Enabled = False
        ClearFields()
        LockFields()
        dbConn.Open()
        dbCmd = New Data.OleDb.OleDbCommand("SELECT * FROM tblAnimalBreed", dbConn)
        rdrBreed = dbCmd.ExecuteReader()
        If rdrBreed.HasRows Then
            cmbBreed.Items.Clear()
            While rdrBreed.Read()
                cmbBreed.Items.Add(rdrBreed(1))
            End While
            rdrBreed.Close()
        End If
        dbConn.Close()
    End Sub

    Private Function ValidateEntry() As Boolean

        If Me.txtAge.Text = "" Then Me.txtAge.Text = "0"
        If Me.txtDepositAmount.Text = "   ." Then Me.txtDepositAmount.Text = "000.00"
        If Me.txtDescription.Text = "" Then Me.txtDescription.Text = "N/A"
        If Me.txtEuthID.Text = "" Then Me.txtEuthID.Text = "0"
        If Me.txtLocation.Text = "" Then Me.txtLocation.Text = " "
        If Me.txtOldLogNo.Text = "" Then Me.txtOldLogNo.Text = "N/A"
        If Me.txtRescueID.Text = "" Then Me.txtRescueID.Text = "0"
        If Me.txtWeight.Text = "" Then Me.txtWeight.Text = "0"
        If Me.rtxtNotes.Text = "" Then Me.rtxtNotes.Text = " "
        If Me.txtDateDepRefund.Text = "  /  /" Then Me.txtDateDepRefund.Text = "01/01/1900"
        Return True

    End Function

    Private Sub btnModSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModSave.Click
        If Me.addMode Then
            If ValidateEntry() = False Then
                MsgBox("Required fields are missing.  Please enter data into the fields marked in red and then try to save again.", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Required Fields Missing")
                Return
            End If
            SaveRecord(SAVE_NEW_REC)
        Else
            If Me.modMode = False Then
                Me.UnlockFields()
                Me.btnModSave.Text = "Save"
                Me.btnClose.Text = "Cancel"
                Me.btnAddNew.Enabled = False
                Me.btnSearch.Enabled = False
                Me.btnKennelCard.Enabled = False
                Me.modMode = True
            Else
                SaveRecord(SAVE_MOD_REC)
            End If
        End If
    End Sub

    Private Sub lsvMedical_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lsvIncidents.ColumnClick
        ' Set the ListViewItemSorter property to a new ListViewItemComparer object.
        Me.lsvMedical.ListViewItemSorter = New ListViewItemComparer(e.Column)
        ' Call the sort method to manually sort the column based on the ListViewItemComparer implementation.
        Me.lsvMedical.Sort()
    End Sub

    Private Sub lsvIncidents_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lsvIncidents.ColumnClick
        ' Set the ListViewItemSorter property to a new ListViewItemComparer object.
        Me.lsvIncidents.ListViewItemSorter = New ListViewItemComparer(e.Column)
        ' Call the sort method to manually sort the column based on the ListViewItemComparer implementation.
        Me.lsvIncidents.Sort()
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        'If Not user.userAllowed(ADD_NEW_ANIMAL) Then
        '    btnAddNew.Enabled = False
        '    Return
        'End If

        Me.ClearFields()
        Me.UnlockFields()
        Me.btnModSave.Enabled = True
        If dbConn.State = ConnectionState.Open Then dbConn.Close()
        Me.btnModSave.Text = "Save"
        Me.btnClose.Text = "Cancel"
        Me.btnAddNew.Enabled = False
        Me.btnSearch.Enabled = False
        Me.btnKennelCard.Enabled = False
        addMode = True
        Me.sbarAnimal.Panels(0).Text = "Enter data and click Save or Cancel."
        Me.sbarAnimal.Refresh()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If modMode Then
            If MsgBox("All changes to this record will be lost.  Are you sure?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Confirm Cancel") = MsgBoxResult.Yes Then
                Me.ClearFields()
                Me.LockFields()
                Me.btnModSave.Text = "Modify This"
                Me.modMode = False
                Me.btnClose.Text = "Close"
                Me.btnKennelCard.Enabled = True
                Me.btnAddNew.Enabled = True
                If currentUser.canModifyAnimal Then Me.btnModSave.Enabled = True Else Me.btnModSave.Enabled = False
                Me.sbarAnimal.Panels(0).Text = "Record modifications cancelled."
                Me.sbarAnimal.Refresh()
            End If
        ElseIf addMode Then
            Me.ClearFields()
            Me.LockFields()
            Me.btnModSave.Text = "Modify This"
            Me.modMode = False
            Me.btnClose.Text = "Close"
            Me.btnSearch.Enabled = True
            Me.btnKennelCard.Enabled = True
            Me.btnAddNew.Enabled = True
            If currentUser.canModifyAnimal Then Me.btnModSave.Enabled = True Else Me.btnModSave.Enabled = False
            Me.sbarAnimal.Panels(0).Text = "New record cancelled."
            Me.sbarAnimal.Update()
            addMode = False
        Else
            If dbConn.State = ConnectionState.Open Then dbConn.Close()
            Me.Close()
        End If
    End Sub

    Private Sub pboxPhoto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pboxPhoto.DoubleClick
        If Me.addMode Or Me.modMode Then
            Me.dlgFileOpen.ShowDialog()
            Me.pboxPhoto.Image = Me.pboxPhoto.Image.FromFile(Me.dlgFileOpen.FileName)
            ' Me.pboxPhoto.Update()
        End If
    End Sub

    Private Sub btnAdopt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdopt.Click
        Dim adoptForm As New frmAdopt
        adoptForm.MdiParent = Me.MdiParent
        adoptForm.txtAnName.Text = Me.txtName.Text
        adoptForm.txtLogNo.Text = Me.txtCHSNo.Text
        adoptForm.txtTagNo.Text = Me.txtCHSTagNo.Text
        adoptForm.txtAnimalID.Text = Me.txtDBID.Text
        adoptForm.Show()
    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Dim choice As Integer
        Dim sqlCmd As String
        Dim rdrClient As OleDb.OleDbDataReader
        Dim clientID As Integer
        Dim clientName As String

        dbConn.Open()
        sqlCmd = "SELECT ClientID from tblIncident WHERE AnimalLogNumber = '" + Me.txtCHSNo.Text + "' AND IncidentType = " + ITYPE_ADOPT.ToString() + " ORDER BY IncidentDate"
        dbCmd = New OleDb.OleDbCommand(sqlCmd, dbConn)
        Try
            rdrClient = dbCmd.ExecuteReader(CommandBehavior.SingleRow)
        Catch ex As Exception
        End Try
        If rdrClient.HasRows Then
            choice = MsgBox("You are about to return an animal from an adoption." + Chr(13) + "Are you sure?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Confirm Return")
            If choice = vbYes Then
                rdrClient.Read()
                clientID = rdrClient.GetInt16(0)
                rdrClient.Close()

                sqlCmd = "SELECT FirstName,LastName from tblClient where ClientID = " + clientID.ToString()
                dbCmd = New Data.OleDb.OleDbCommand(sqlCmd, dbConn)
                Try
                    rdrClient = dbCmd.ExecuteReader(CommandBehavior.SingleRow)
                Catch ex As Exception
                End Try
                If rdrClient.Read() Then clientName = rdrClient.GetString(0)
                rdrClient.Close()

                sqlCmd = "INSERT INTO tblIncident (AnimalLogNumber,IncidentDate,ClientID,EmployeeID,IncidentType,MuniID,Fee,Description,Notes) VALUES (@logNo,@date,@clientID,@empID,@incidentType,@muni,@fee,@desc,@notes)"
                dbCmd = New Data.OleDb.OleDbCommand(sqlCmd, dbConn)

                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@logNo", OleDb.OleDbType.VarChar))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@incidentDate", OleDb.OleDbType.Date))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@clientID", OleDb.OleDbType.Integer))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@empID", OleDb.OleDbType.Integer))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@incidentType", OleDb.OleDbType.Integer))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@muni", OleDb.OleDbType.Integer))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@fee", OleDb.OleDbType.Double))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@desc", OleDb.OleDbType.VarChar))
                dbCmd.Parameters.Add(New OleDb.OleDbParameter("@notes", OleDb.OleDbType.LongVarChar))

                dbCmd.Parameters("@logNo").Value = Me.txtCHSNo.Text
                dbCmd.Parameters("@incidentDate").Value = Today.Date
                dbCmd.Parameters("@clientID").Value = CType(clientID, Integer)
                dbCmd.Parameters("@empID").Value = CType(currentUser.EmployeeID, Integer)
                dbCmd.Parameters("@incidentType").Value = ITYPE_RETURN
                dbCmd.Parameters("@muni").Value = 0
                dbCmd.Parameters("@fee").Value = 0
                dbCmd.Parameters("@desc").Value = "Adoption return of " + Me.txtName.Text + " from " + clientName
                dbCmd.Parameters("@notes").Value = " "

                Try
                    If dbCmd.ExecuteNonQuery() = 1 Then
                        sqlCmd = "UPDATE tblAnimalPrimary SET Adopted = FALSE WHERE AnimalID = " + Me.txtDBID.Text
                        dbCmd = New OleDb.OleDbCommand(sqlCmd, dbConn)
                        dbCmd.ExecuteNonQuery()
                        dbConn.Close()
                    End If
                Catch ex As Exception
                End Try

            End If
        End If
    End Sub

    Private Sub lsvIncidents_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvIncidents.ItemActivate
        Dim CID As Integer

        Dim sqlCmd As String
        Dim rdrResult As Data.OleDb.OleDbDataReader

        sqlCmd = "SELECT I.ClientID from tblIncident I WHERE I.IncidentID=" + Me.lsvIncidents.SelectedItems.Item(0).SubItems.Item(0).Text
        If dbConn.State = ConnectionState.Closed Then dbConn.Open()
        dbCmd = New OleDb.OleDbCommand(sqlCmd, dbConn)
        rdrResult = dbCmd.ExecuteReader()

        While rdrResult.Read()
            CID = FieldToString(rdrResult, 0)
        End While

        Dim client As New frmClient
        client.MdiParent = Me.ParentForm
        client.Show()
        rdrResult.Close()
        dbConn.Close()

        sqlCmd = "SELECT * FROM tblClient c WHERE c.ClientID=" + CID.ToString
        If dbConn.State = ConnectionState.Closed Then dbConn.Open()
        dbCmd = New OleDb.OleDbCommand(sqlCmd, dbConn)
        rdrResult = dbCmd.ExecuteReader(CommandBehavior.SingleRow)
        client.PopulateFields(rdrResult)
        rdrResult.Close()
        dbConn.Close()


    End Sub

    Private Sub lsvAdopt_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvAdopt.ItemActivate
        Dim CID As Integer

        Dim sqlCmd As String
        Dim rdrResult As Data.OleDb.OleDbDataReader

        sqlCmd = "SELECT I.ClientID from tblIncident I WHERE I.IncidentID=" + Me.lsvAdopt.SelectedItems.Item(0).SubItems.Item(0).Text
        If dbConn.State = ConnectionState.Closed Then dbConn.Open()
        dbCmd = New OleDb.OleDbCommand(sqlCmd, dbConn)
        rdrResult = dbCmd.ExecuteReader()

        While rdrResult.Read()
            CID = FieldToString(rdrResult, 0)
        End While

        Dim client As New frmClient
        client.MdiParent = Me.ParentForm
        client.Show()
        rdrResult.Close()
        dbConn.Close()

        sqlCmd = "SELECT * FROM tblClient c WHERE c.ClientID=" + CID.ToString
        If dbConn.State = ConnectionState.Closed Then dbConn.Open()
        dbCmd = New OleDb.OleDbCommand(sqlCmd, dbConn)
        rdrResult = dbCmd.ExecuteReader(CommandBehavior.SingleRow)
        client.PopulateFields(rdrResult)
        rdrResult.Close()
        dbConn.Close()

    End Sub

    Private Sub lsvReturn_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvReturn.ItemActivate
        Dim CID As Integer

        Dim sqlCmd As String
        Dim rdrResult As Data.OleDb.OleDbDataReader

        sqlCmd = "SELECT I.ClientID from tblIncident I WHERE I.IncidentID=" + Me.lsvReturn.SelectedItems.Item(0).SubItems.Item(0).Text
        If dbConn.State = ConnectionState.Closed Then dbConn.Open()
        dbCmd = New OleDb.OleDbCommand(sqlCmd, dbConn)
        rdrResult = dbCmd.ExecuteReader()

        While rdrResult.Read()
            CID = FieldToString(rdrResult, 0)
        End While

        Dim client As New frmClient
        client.MdiParent = Me.ParentForm
        client.Show()
        rdrResult.Close()
        dbConn.Close()

        sqlCmd = "SELECT * FROM tblClient c WHERE c.ClientID=" + CID.ToString
        If dbConn.State = ConnectionState.Closed Then dbConn.Open()
        dbCmd = New OleDb.OleDbCommand(sqlCmd, dbConn)
        rdrResult = dbCmd.ExecuteReader(CommandBehavior.SingleRow)
        client.PopulateFields(rdrResult)
        rdrResult.Close()
        dbConn.Close()

    End Sub


    Private Sub lsvMedical_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvMedical.ItemActivate
        Dim CID As Integer

        Dim sqlCmd As String
        Dim rdrResult As Data.OleDb.OleDbDataReader

        sqlCmd = "SELECT I.ClientID from tblIncident I WHERE I.IncidentID=" + Me.lsvMedical.SelectedItems.Item(0).SubItems.Item(0).Text
        If dbConn.State = ConnectionState.Closed Then dbConn.Open()
        dbCmd = New OleDb.OleDbCommand(sqlCmd, dbConn)
        rdrResult = dbCmd.ExecuteReader()

        While rdrResult.Read()
            CID = FieldToString(rdrResult, 0)
        End While

        Dim client As New frmClient
        client.MdiParent = Me.ParentForm
        client.Show()
        rdrResult.Close()
        dbConn.Close()

        sqlCmd = "SELECT * FROM tblClient c WHERE c.ClientID=" + CID.ToString
        If dbConn.State = ConnectionState.Closed Then dbConn.Open()
        dbCmd = New OleDb.OleDbCommand(sqlCmd, dbConn)
        rdrResult = dbCmd.ExecuteReader(CommandBehavior.SingleRow)
        client.PopulateFields(rdrResult)
        rdrResult.Close()
        dbConn.Close()

    End Sub

    Private Sub btnMedical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedical.Click

    End Sub

    Private Sub btnAddIncident_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddIncident.Click

    End Sub

    Private Sub pboxPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pboxPhoto.Click

    End Sub
End Class