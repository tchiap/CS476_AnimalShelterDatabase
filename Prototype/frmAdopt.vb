Public Class frmAdopt
    Inherits System.Windows.Forms.Form
    Private dbConn As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + DBFILE)
    Private dbCmd As OleDb.OleDbCommand

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTagNo As System.Windows.Forms.TextBox
    Friend WithEvents txtLogNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAnName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNewClient As System.Windows.Forms.Button
    Friend WithEvents btnAdopt As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtClientID As System.Windows.Forms.TextBox
    Friend WithEvents txtClientName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAnimalID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFee As FlxMaskBox.FlexMaskEditBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAdopt))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtFee = New FlxMaskBox.FlexMaskEditBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtAnimalID = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAnName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLogNo = New System.Windows.Forms.TextBox
        Me.txtTagNo = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnNewClient = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtClientName = New System.Windows.Forms.TextBox
        Me.txtClientID = New System.Windows.Forms.TextBox
        Me.btnAdopt = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFee)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtAnimalID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtAnName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtLogNo)
        Me.GroupBox1.Controls.Add(Me.txtTagNo)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Animal"
        '
        'txtFee
        '
        Me.txtFee.FieldType = FlxMaskBox.FlexMaskEditBox._FieldType.NUMERIC
        Me.txtFee.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFee.Location = New System.Drawing.Point(56, 128)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(64, 20)
        Me.txtFee.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "DB ID:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAnimalID
        '
        Me.txtAnimalID.Location = New System.Drawing.Point(56, 24)
        Me.txtAnimalID.Name = "txtAnimalID"
        Me.txtAnimalID.ReadOnly = True
        Me.txtAnimalID.Size = New System.Drawing.Size(80, 20)
        Me.txtAnimalID.TabIndex = 8
        Me.txtAnimalID.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Fee:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAnName
        '
        Me.txtAnName.Location = New System.Drawing.Point(56, 96)
        Me.txtAnName.Name = "txtAnName"
        Me.txtAnName.ReadOnly = True
        Me.txtAnName.Size = New System.Drawing.Size(144, 20)
        Me.txtAnName.TabIndex = 5
        Me.txtAnName.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Log No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tag No.:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLogNo
        '
        Me.txtLogNo.Location = New System.Drawing.Point(56, 72)
        Me.txtLogNo.Name = "txtLogNo"
        Me.txtLogNo.ReadOnly = True
        Me.txtLogNo.Size = New System.Drawing.Size(120, 20)
        Me.txtLogNo.TabIndex = 1
        Me.txtLogNo.Text = ""
        '
        'txtTagNo
        '
        Me.txtTagNo.Location = New System.Drawing.Point(56, 48)
        Me.txtTagNo.Name = "txtTagNo"
        Me.txtTagNo.ReadOnly = True
        Me.txtTagNo.Size = New System.Drawing.Size(120, 20)
        Me.txtTagNo.TabIndex = 0
        Me.txtTagNo.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnNewClient)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtClientName)
        Me.GroupBox2.Controls.Add(Me.txtClientID)
        Me.GroupBox2.Location = New System.Drawing.Point(248, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(232, 112)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Client"
        '
        'btnNewClient
        '
        Me.btnNewClient.Location = New System.Drawing.Point(80, 80)
        Me.btnNewClient.Name = "btnNewClient"
        Me.btnNewClient.Size = New System.Drawing.Size(80, 24)
        Me.btnNewClient.TabIndex = 5
        Me.btnNewClient.Text = "New Client"
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(176, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(32, 24)
        Me.btnSearch.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Client ID:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtClientName
        '
        Me.txtClientName.Location = New System.Drawing.Point(72, 48)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(152, 20)
        Me.txtClientName.TabIndex = 1
        Me.txtClientName.Text = ""
        '
        'txtClientID
        '
        Me.txtClientID.Location = New System.Drawing.Point(72, 16)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.Size = New System.Drawing.Size(96, 20)
        Me.txtClientID.TabIndex = 0
        Me.txtClientID.Text = ""
        '
        'btnAdopt
        '
        Me.btnAdopt.Location = New System.Drawing.Point(272, 136)
        Me.btnAdopt.Name = "btnAdopt"
        Me.btnAdopt.Size = New System.Drawing.Size(72, 32)
        Me.btnAdopt.TabIndex = 2
        Me.btnAdopt.Text = "Adopt!"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(384, 136)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 32)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        '
        'frmAdopt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(496, 182)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdopt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAdopt"
        Me.Text = "Adopt Animal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim sqlCmd As String
        Dim tmpField As SelectField
        Dim rdrResult As Data.OleDb.OleDbDataReader
        Dim frmSearch As New frmSearchDlg
        Dim choice As Integer
        Dim sel As ListViewItem = Nothing

        ' Set up search fields for this type of object
        arrSearchFields.Clear()
        arrSearchFields.Add(New SelectField("ClientID", "Client ID", INT_FIELD))
        arrSearchFields.Add(New SelectField("FirstName", "First Name", STRING_FIELD))
        arrSearchFields.Add(New SelectField("LastName", "Last Name", STRING_FIELD))
        arrSearchFields.Add(New SelectField("Address1", "Address", STRING_FIELD))
        arrSearchFields.Add(New SelectField("City", "City", STRING_FIELD))
        arrSearchFields.Add(New SelectField("PrimaryPhone", "Phone", STRING_FIELD))

        ' Get first 100 records
        sqlCmd = "SELECT TOP 100 ClientID,FirstName,LastName,Address1,City,PrimaryPhone from tblClient"
        If dbConn.State = ConnectionState.Closed Then dbConn.Open()
        dbCmd = New OleDb.OleDbCommand(sqlCmd, dbConn)
        rdrResult = dbCmd.ExecuteReader()
        frmSearch.Init(rdrResult)
        sel = frmSearch.Display("tblClient")
        rdrResult.Close()
        If Not sel Is Nothing Then
            tmpField = arrSearchFields(0)
            sqlCmd = "SELECT * FROM tblClient WHERE " + tmpField.getFieldName + " = " + sel.Text
            Try
                dbCmd = New OleDb.OleDbCommand(sqlCmd, dbConn)
                rdrResult = dbCmd.ExecuteReader(CommandBehavior.SingleRow)
                rdrResult.Read()

                ' X-Filed clients may not be able to adopt, so double check
                If rdrResult.GetBoolean(19) = True Then
                    choice = MsgBox("This client is X-File flagged.  Are you sure they should adopt?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Client Warning")
                    If choice = vbNo Then
                        rdrResult.Close()
                        dbConn.Close()
                        Return
                    End If
                End If
                Me.txtClientID.Text = FieldToString(rdrResult, 0)
                Me.txtClientName.Text = (FieldToString(rdrResult, 3) + ", " + FieldToString(rdrResult, 1))
                Me.btnAdopt.Enabled = True
                rdrResult.Close()
                Me.Refresh()
            Catch ex As Exception

            End Try
            dbConn.Close()
        End If
    End Sub

    Private Sub frmAdopt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnAdopt.Enabled = False
        If currentUser.canAddClient Then Me.btnNewClient.Enabled = True Else Me.btnNewClient.Enabled = False
    End Sub

    Private Sub btnNewClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewClient.Click
        Dim clientForm As New frmClient
        Dim clientInfo(2) As String

        clientInfo = clientForm.InlineNew()
        If clientInfo Is Nothing Then Return
        Me.txtClientID.Text = clientInfo(0)
        Me.txtClientName.Text = clientInfo(1)
    End Sub

    Private Sub btnAdopt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdopt.Click
        Dim confirm As Integer
        If Me.txtClientID.Text <> "" Then
            confirm = MsgBox("You are about to adopt this animal out.  Are you sure?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Adoption")
            If confirm = vbYes Then
                Me.AdoptAnimal(Me.txtLogNo.Text, Me.txtTagNo.Text, Me.txtClientID.Text, Me.txtFee.Text, Me.txtAnName.Text, Me.txtClientName.Text, Me.txtAnimalID.Text)
                Me.Close()
            End If
        Else
            MsgBox("You must select a Client to adopt to.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Missing Data")
        End If
    End Sub

    Private Sub AdoptAnimal(ByVal inLogNo As String, ByVal inTagNo As String, ByVal inClientID As String, ByVal inFee As String, ByVal inAnName As String, ByVal inClientName As String, ByVal inAnimalID As String)
        Dim sqlCmd As String

        dbConn.Open()
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

        dbCmd.Parameters("@logNo").Value = inLogNo
        dbCmd.Parameters("@incidentDate").Value = Today.Date
        dbCmd.Parameters("@clientID").Value = CType(inClientID, Integer)
        dbCmd.Parameters("@empID").Value = CType(currentUser.EmployeeID, Integer)
        dbCmd.Parameters("@incidentType").Value = ITYPE_ADOPT
        dbCmd.Parameters("@muni").Value = 0
        dbCmd.Parameters("@fee").Value = CType(inFee, Double)
        dbCmd.Parameters("@desc").Value = "Adoption of " + inAnName + " to " + inClientName
        dbCmd.Parameters("@notes").Value = " "

        Try
            If dbCmd.ExecuteNonQuery() = 1 Then
                sqlCmd = "UPDATE tblAnimalPrimary SET Adopted = TRUE WHERE AnimalID = " + inAnimalID
                dbCmd = New OleDb.OleDbCommand(sqlCmd, dbConn)
                dbCmd.ExecuteNonQuery()
                dbConn.Close()
            End If
        Catch ex As Exception
        End Try

    End Sub
End Class
