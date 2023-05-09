Imports System.Data.OleDb

Public Class frmChangePassword
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents newPasswordGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents lblNewPassword2 As System.Windows.Forms.Label
    Friend WithEvents lblNewPassword1 As System.Windows.Forms.Label
    Friend WithEvents oldPasswordGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents lblOldPassword As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.newPasswordGroupBox = New System.Windows.Forms.GroupBox
        Me.txtNewPassword2 = New System.Windows.Forms.TextBox
        Me.lblNewPassword2 = New System.Windows.Forms.Label
        Me.txtNewPassword1 = New System.Windows.Forms.TextBox
        Me.lblNewPassword1 = New System.Windows.Forms.Label
        Me.oldPasswordGroupBox = New System.Windows.Forms.GroupBox
        Me.txtOldPassword = New System.Windows.Forms.TextBox
        Me.lblOldPassword = New System.Windows.Forms.Label
        Me.newPasswordGroupBox.SuspendLayout()
        Me.oldPasswordGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(200, 200)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(80, 24)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "&Ok"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(112, 200)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 24)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Old & New Password Must Be Different"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.UseMnemonic = False
        '
        'newPasswordGroupBox
        '
        Me.newPasswordGroupBox.Controls.Add(Me.txtNewPassword2)
        Me.newPasswordGroupBox.Controls.Add(Me.lblNewPassword2)
        Me.newPasswordGroupBox.Controls.Add(Me.txtNewPassword1)
        Me.newPasswordGroupBox.Controls.Add(Me.lblNewPassword1)
        Me.newPasswordGroupBox.Location = New System.Drawing.Point(8, 96)
        Me.newPasswordGroupBox.Name = "newPasswordGroupBox"
        Me.newPasswordGroupBox.Size = New System.Drawing.Size(272, 95)
        Me.newPasswordGroupBox.TabIndex = 2
        Me.newPasswordGroupBox.TabStop = False
        Me.newPasswordGroupBox.Text = "New Password"
        '
        'txtNewPassword2
        '
        Me.txtNewPassword2.Location = New System.Drawing.Point(128, 56)
        Me.txtNewPassword2.MaxLength = 32
        Me.txtNewPassword2.Name = "txtNewPassword2"
        Me.txtNewPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword2.Size = New System.Drawing.Size(128, 20)
        Me.txtNewPassword2.TabIndex = 4
        '
        'lblNewPassword2
        '
        Me.lblNewPassword2.Location = New System.Drawing.Point(11, 59)
        Me.lblNewPassword2.Name = "lblNewPassword2"
        Me.lblNewPassword2.Size = New System.Drawing.Size(128, 16)
        Me.lblNewPassword2.TabIndex = 8
        Me.lblNewPassword2.Text = "Retype New Password:"
        '
        'txtNewPassword1
        '
        Me.txtNewPassword1.Location = New System.Drawing.Point(128, 24)
        Me.txtNewPassword1.MaxLength = 32
        Me.txtNewPassword1.Name = "txtNewPassword1"
        Me.txtNewPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword1.Size = New System.Drawing.Size(128, 20)
        Me.txtNewPassword1.TabIndex = 3
        '
        'lblNewPassword1
        '
        Me.lblNewPassword1.Location = New System.Drawing.Point(48, 26)
        Me.lblNewPassword1.Name = "lblNewPassword1"
        Me.lblNewPassword1.Size = New System.Drawing.Size(120, 16)
        Me.lblNewPassword1.TabIndex = 6
        Me.lblNewPassword1.Text = "New Password:"
        '
        'oldPasswordGroupBox
        '
        Me.oldPasswordGroupBox.Controls.Add(Me.txtOldPassword)
        Me.oldPasswordGroupBox.Controls.Add(Me.lblOldPassword)
        Me.oldPasswordGroupBox.Location = New System.Drawing.Point(8, 32)
        Me.oldPasswordGroupBox.Name = "oldPasswordGroupBox"
        Me.oldPasswordGroupBox.Size = New System.Drawing.Size(272, 56)
        Me.oldPasswordGroupBox.TabIndex = 0
        Me.oldPasswordGroupBox.TabStop = False
        Me.oldPasswordGroupBox.Text = "Old Password"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Location = New System.Drawing.Point(128, 22)
        Me.txtOldPassword.MaxLength = 32
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(128, 20)
        Me.txtOldPassword.TabIndex = 1
        '
        'lblOldPassword
        '
        Me.lblOldPassword.Location = New System.Drawing.Point(8, 25)
        Me.lblOldPassword.Name = "lblOldPassword"
        Me.lblOldPassword.Size = New System.Drawing.Size(120, 16)
        Me.lblOldPassword.TabIndex = 6
        Me.lblOldPassword.Text = "Type Old Password:"
        Me.lblOldPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmChangePassword
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(290, 236)
        Me.Controls.Add(Me.oldPasswordGroupBox)
        Me.Controls.Add(Me.newPasswordGroupBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Change User Password"
        Me.newPasswordGroupBox.ResumeLayout(False)
        Me.newPasswordGroupBox.PerformLayout()
        Me.oldPasswordGroupBox.ResumeLayout(False)
        Me.oldPasswordGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim oldPass As String = txtOldPassword.Text
        Dim newPass1 As String = txtNewPassword1.Text
        Dim newPass2 As String = txtNewPassword2.Text
        oldPass = hashPassword(oldPass)
        newPass1 = hashPassword(newPass1)
        newPass2 = hashPassword(newPass2)

        If oldPass.Equals(currPass) Then

            If newPass1.Equals(newPass2) Then
                Dim Connect As New OleDbConnection
                Dim sqlString As String

                Connect.ConnectionString = "Data Source=""C:\CAMODATA\CAMO.mdb""; Provider=""Microsoft.Jet.OLEDB.4.0"""
                Dim updateData As New OleDbCommand
                updateData.Connection = Connect
                sqlString = "UPDATE tblPerson SET [password]='" & newPass1 & "' where ClientID=?"
                updateData.CommandText = sqlString

                updateData.Parameters.Add(New OleDbParameter("ClientID", System.Data.OleDb.OleDbType.Integer))
                updateData.Parameters(0).Value = loggedInID

                Connect.Open()
                updateData.ExecuteNonQuery()
                Connect.Close()
                currPass = newPass1
                btnOk.Enabled = False
            Else
                MessageBox.Show("New passwords do not match.")

            End If
        Else
            MessageBox.Show("Old Password Incorrect")
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
