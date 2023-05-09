Public Class frmLogin
    Inherits System.Windows.Forms.Form
    Dim tmpUser As New UserObject
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
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents loginGroup As System.Windows.Forms.GroupBox
    Friend WithEvents tbxPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents tbxUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.loginGroup = New System.Windows.Forms.GroupBox
        Me.tbxPassword = New System.Windows.Forms.TextBox
        Me.lblPassword = New System.Windows.Forms.Label
        Me.tbxUserName = New System.Windows.Forms.TextBox
        Me.lblUserName = New System.Windows.Forms.Label
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.loginGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'loginGroup
        '
        Me.loginGroup.Controls.Add(Me.tbxPassword)
        Me.loginGroup.Controls.Add(Me.lblPassword)
        Me.loginGroup.Controls.Add(Me.tbxUserName)
        Me.loginGroup.Controls.Add(Me.lblUserName)
        Me.loginGroup.Location = New System.Drawing.Point(8, 8)
        Me.loginGroup.Name = "loginGroup"
        Me.loginGroup.Size = New System.Drawing.Size(280, 95)
        Me.loginGroup.TabIndex = 0
        Me.loginGroup.TabStop = False
        Me.loginGroup.Text = "Login"
        '
        'tbxPassword
        '
        Me.tbxPassword.Location = New System.Drawing.Point(80, 56)
        Me.tbxPassword.MaxLength = 32
        Me.tbxPassword.Name = "tbxPassword"
        Me.tbxPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.tbxPassword.Size = New System.Drawing.Size(189, 20)
        Me.tbxPassword.TabIndex = 2
        Me.tbxPassword.Text = ""
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(7, 59)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 16)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbxUserName
        '
        Me.tbxUserName.Location = New System.Drawing.Point(80, 24)
        Me.tbxUserName.MaxLength = 32
        Me.tbxUserName.Name = "tbxUserName"
        Me.tbxUserName.Size = New System.Drawing.Size(189, 20)
        Me.tbxUserName.TabIndex = 1
        Me.tbxUserName.Text = ""
        '
        'lblUserName
        '
        Me.lblUserName.Location = New System.Drawing.Point(7, 26)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(64, 16)
        Me.lblUserName.TabIndex = 6
        Me.lblUserName.Text = "User Name:"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(212, 112)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "&Ok"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(128, 112)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(296, 142)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.loginGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " User Login"
        Me.loginGroup.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If Me.tbxUserName.Text = "" Or Me.tbxPassword.Text = "" Then
            If Me.tbxUserName.Text = "" Then Me.tbxUserName.BackColor = Color.MistyRose Else Me.tbxUserName.BackColor = SystemColors.Window
            If Me.tbxPassword.Text = "" Then Me.tbxPassword.BackColor = Color.MistyRose Else Me.tbxPassword.BackColor = SystemColors.Window
            MsgBox("UserName & Password fields can NOT be left blank. Please check you input and try again!", MsgBoxStyle.Exclamation, "Login Error")
        Else
            If Me.loadUserData() = True Then
                Me.Dispose()
            Else
                Me.tbxPassword.Clear()
                Me.tbxUserName.Focus()
                Me.tbxUserName.SelectAll()
            End If
        End If
    End Sub


    Public Function getUser(ByVal owner As System.Windows.Forms.Form)
        Me.ShowDialog(owner)
        Return tmpUser
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Function loadUserData() As Boolean
        Dim sqlCmd As String
        Dim rdrResult As Data.OleDb.OleDbDataReader

        sqlCmd = "SELECT DISTINCT * FROM tblEmployee as t WHERE t.LoginName='" + Me.tbxUserName.Text + "' and t.Password='" + EnDecrypt(Me.tbxPassword.Text) + "'"
        If dbConn.State = ConnectionState.Closed Then dbConn.Open()
        dbCmd = New OleDb.OleDbCommand(sqlCmd, dbConn)
        rdrResult = dbCmd.ExecuteReader()
        If rdrResult.HasRows() = True Then
            rdrResult.Read()
            Me.tmpUser.EmployeeID = FieldToString(rdrResult, 0)
            Me.tmpUser.JobID = FieldToString(rdrResult, 1)
            Me.tmpUser.FirstName = FieldToString(rdrResult, 2)
            Me.tmpUser.LastName = FieldToString(rdrResult, 3)
            Me.tmpUser.RawPermissions = FieldToString(rdrResult, 11)
            Me.tmpUser.LoginName = FieldToString(rdrResult, 12)
            rdrResult.Close()
            dbConn.Close()
            Return True
        Else
            rdrResult.Close()
            dbConn.Close()
            MsgBox("Invalid UserName or Password" + vbCrLf + "Please Check You UserName and Password And Try Again!", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "Login Error")
            Return False
        End If
    End Function
End Class


