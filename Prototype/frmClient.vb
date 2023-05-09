
Imports System.Data.OleDb
Public Class frmClient

    Inherits System.Windows.Forms.Form
    Dim Connect As New OleDbConnection
    Dim flag As Boolean = True
    Dim flag1 As Boolean = True
    Dim flag2 As Boolean = False

    Private Sub frmClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect.ConnectionString = "Data Source=""C:\CAMODATA\CAMO.mdb""; Provider=""Microsoft.Jet.OLEDB.4.0"""
        disable()


    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim enterData As New OleDbCommand

        If flag = True Then
            btnInsert.Text = "Save"
            txtClientID.Enabled = False
            enabletext()
            clearfield()
            flag = False
        Else

            If checkfield() = False Then
                Exit Sub
            End If

            enterData.CommandText = "INSERT INTO tblPerson ( FirstName, MiddleInitial, LastName, Address1, Address2, City, State, Zip, MuniId, PrimaryPhone, AltPhone, Email, Alias, LicStateIDNumber, LicState, Notes, DateofBirth, XFIle, TypeFK ) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"

            ' enterData.Parameters.Add(New OleDbParameter("ClientID", "ClientID"))
            enterData.Parameters.Add(New OleDbParameter("FirstName", "FirstName"))
            enterData.Parameters.Add(New OleDbParameter("MiddleInitial", "MiddleInitial"))
            enterData.Parameters.Add(New OleDbParameter("LastName", "LastName"))
            enterData.Parameters.Add(New OleDbParameter("Address1", "Address1"))
            enterData.Parameters.Add(New OleDbParameter("Address2", "Address2"))
            enterData.Parameters.Add(New OleDbParameter("City", "City"))
            enterData.Parameters.Add(New OleDbParameter("State", "State"))
            enterData.Parameters.Add(New OleDbParameter("Zip", "Zip"))
            enterData.Parameters.Add(New OleDbParameter("MuniId", "MuniId"))
            enterData.Parameters.Add(New OleDbParameter("PrimaryPhone", "PrimaryPhone"))
            enterData.Parameters.Add(New OleDbParameter("AltPhone", "AltPhone"))
            enterData.Parameters.Add(New OleDbParameter("Email", "Email"))
            enterData.Parameters.Add(New OleDbParameter("Alias", "Alias"))
            enterData.Parameters.Add(New OleDbParameter("LicStateIDNumber", "LicStateIDNumber"))
            enterData.Parameters.Add(New OleDbParameter("LicState", "LicState"))
            enterData.Parameters.Add(New OleDbParameter("Notes", "Notes"))
            enterData.Parameters.Add(New OleDbParameter("DateofBirth", "DateofBirth"))
            enterData.Parameters.Add(New OleDbParameter("XFile", "XFile"))
            enterData.Parameters.Add(New OleDbParameter("TypeFK", "TypeFK"))

            ' enterData.Parameters("ClientID").Value = txtClientID.Text
            enterData.Parameters("FirstName").Value = txtFirstName.Text
            enterData.Parameters("MiddleInitial").Value = txtMiddleInitial.Text
            enterData.Parameters("LastName").Value = txtLastName.Text
            enterData.Parameters("Address1").Value = txtAddress1.Text
            enterData.Parameters("Address2").Value = txtAddress2.Text
            enterData.Parameters("City").Value = txtCity.Text
            enterData.Parameters("State").Value = txtState.Text
            enterData.Parameters("Zip").Value = txtZipCode.Text
            enterData.Parameters("MuniId").Value = CInt(txtMuniID.Text)
            enterData.Parameters("PrimaryPhone").Value = txtPrimaryTel.Text
            enterData.Parameters("AltPhone").Value = txtAlternateTel.Text
            enterData.Parameters("Email").Value = txtEmail.Text
            enterData.Parameters("Alias").Value = txtAlias.Text
            enterData.Parameters("LicStateIDNumber").Value = txtlicence.Text
            enterData.Parameters("LicState").Value = txtIssueState.Text
            enterData.Parameters("Notes").Value = rtbNote.Text
            enterData.Parameters("DateofBirth").Value = txtDateofBirth.Text

            If ckbXFile.Checked Then
                enterData.Parameters("XFile").Value = True
            Else
                enterData.Parameters("XFile").Value = False
            End If

            enterData.Parameters("TypeFK").Value = 5

            enterData.Connection = Connect

            Connect.Open()

            enterData.ExecuteNonQuery()
            Connect.Close()

            MsgBox("Record Inserted")
            flag = True
            clearfield()
            txtClientID.Enabled = True
            btnInsert.Text = "Add New"
            disable()
        End If
    End Sub

    Public Function checkfield() As Boolean
        If txtFirstName.Text = "" Then
            MsgBox("Please enter First Name ")
            Return False
        ElseIf txtPrimaryTel.Text = "" Then
            MsgBox("Please enter Primary Telephone Number")
            Return False
        ElseIf txtDateofBirth.Text = "" Then
            MsgBox("Please enter date of birth")
            Return False
        Else
            Return True
        End If

    End Function

    Public Function clearfield() As Boolean
        txtClientID.Text = ""
        txtFirstName.Text = ""
        txtMiddleInitial.Text = ""
        txtLastName.Text = ""
        txtAddress1.Text = ""
        txtAddress2.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZipCode.Text = ""
        txtMuniID.Text = ""
        txtPrimaryTel.Text = ""
        txtAlternateTel.Text = ""
        txtEmail.Text = ""
        txtAlias.Text = ""
        txtlicence.Text = ""
        txtIssueState.Text = ""
        rtbNote.Text = ""
        txtDateofBirth.Text = ""
    End Function

    Public Function disable() As Boolean
        'txtClientID.Enabled = False
        txtFirstName.Enabled = False
        txtMiddleInitial.Enabled = False
        txtLastName.Enabled = False
        txtAddress1.Enabled = False
        txtAddress2.Enabled = False
        txtCity.Enabled = False
        txtState.Enabled = False
        txtZipCode.Enabled = False
        txtMuniID.Enabled = False
        txtPrimaryTel.Enabled = False
        txtAlternateTel.Enabled = False
        txtEmail.Enabled = False
        txtAlias.Enabled = False
        txtlicence.Enabled = False
        txtIssueState.Enabled = False
        rtbNote.Enabled = False
        txtDateofBirth.Enabled = False
    End Function

    Public Function enabletext() As Boolean
        'txtClientID.Enabled = True
        txtFirstName.Enabled = True
        txtMiddleInitial.Enabled = True
        txtLastName.Enabled = True
        txtAddress1.Enabled = True
        txtAddress2.Enabled = True
        txtCity.Enabled = True
        txtState.Enabled = True
        txtZipCode.Enabled = True
        txtMuniID.Enabled = True
        txtPrimaryTel.Enabled = True
        txtAlternateTel.Enabled = True
        txtEmail.Enabled = True
        txtAlias.Enabled = True
        txtlicence.Enabled = True
        txtIssueState.Enabled = True
        rtbNote.Enabled = True
        txtDateofBirth.Enabled = True
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim getData As New OleDbCommand
        If txtClientID.Text = "" Then
            MsgBox("Please type the ClientID to search")
            Exit Sub
        End If
        disable()

        getData.CommandText = "SELECT  FirstName, LastName, MiddleInitial, Address1, Address2, City, State, Zip, MuniId, PrimaryPhone, AltPhone, Email, Alias, Notes, LicStateIDNumber, LicState, DateofBirth, XFile from tblPerson WHERE ClientID=?"

        getData.Parameters.Add(New OleDbParameter("ClientID", "ClientID"))

        getData.Parameters("ClientID").Value = txtClientID.Text

        getData.Connection = Connect

        Connect.Open()
        Dim reader As OleDbDataReader = getData.ExecuteReader

        reader.Read()

        If reader.HasRows = True Then
            txtFirstName.Text = reader(0)
            txtLastName.Text = reader(1)
            txtMiddleInitial.Text = reader(2)
            txtAddress1.Text = reader(3)
            txtAddress2.Text = reader(4)
            txtCity.Text = reader(5)
            txtState.Text = reader(6)
            txtZipCode.Text = reader(7)
            txtMuniID.Text = reader(8)
            txtPrimaryTel.Text = reader(9)
            txtAlternateTel.Text = reader(10)
            txtEmail.Text = reader(11)
            txtAlias.Text = reader(12)
            rtbNote.Text = reader(13)
            txtlicence.Text = reader(14)
            txtIssueState.Text = reader(15)
            txtDateofBirth.Text = reader(16)
            ckbXFile.Checked = reader(17)

        End If

        reader.Close()
        Connect.Close()


    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click

        Connect.ConnectionString = "Data Source=""C:\CAMODATA\CAMO.mdb""; Provider=""Microsoft.Jet.OLEDB.4.0"""
        Dim updateData As New OleDbCommand

        If txtClientID.Text = "" Then
            MsgBox("Please select a record to modify")
            Exit Sub
        End If

        If flag1 = True Then
            btnModify.Text = "Update"
            txtClientID.Enabled = False
            enabletext()
            ' clearfield()
            flag1 = False
        Else

            If checkfield() = False Then
                Exit Sub
            End If
            updateData.Connection = Connect

            Dim sqlString As String
            sqlString = " UPDATE tblPerson SET FirstName='" & txtFirstName.Text & "', MiddleInitial = '" & txtMiddleInitial.Text & "', LastName = '" & txtLastName.Text & "', Address1 = '" & txtAddress1.Text & "', Address2 = '" & txtAddress2.Text & "', City = '" & txtCity.Text & "', State = '" & txtState.Text & "', Zip = '" & txtZipCode.Text & "', MuniId = " & txtMuniID.Text & ", PrimaryPhone = '" & txtPrimaryTel.Text & "', AltPhone = '" & txtAlternateTel.Text & "', Email = '" & txtEmail.Text & "', Alias = '" & txtAlias.Text & "', LicStateIDNumber = '" & txtlicence.Text & "', LicState = '" & txtIssueState.Text & "', Notes = '" & rtbNote.Text & "', DateofBirth = " & txtDateofBirth.Text & ", XFIle = " & ckbXFile.Checked & ", TypeFK= '5' where ClientID=?"
            updateData.CommandText = sqlString

            updateData.Parameters.Add(New OleDbParameter("ClientID", System.Data.OleDb.OleDbType.Integer))
            'updateData.Parameters.Add(New OleDbParameter("FirstName", System.Data.OleDb.OleDbType.WChar))


            updateData.Parameters(0).Value = txtClientID.Text
            ' updateData.Parameters("FirstName").Value = "Jay"
            Connect.Open()
            updateData.ExecuteNonQuery()
            Connect.Close()
            MessageBox.Show("Updated")


            txtClientID.Enabled = True
            btnModify.Text = "Modify"
            flag1 = True
            disable()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    flag2 = True
    '    If flag2 = True Then
    '        disable()
    '        txtClientID.Enabled = True
    '        btnInsert.Text = "Add New"
    '        flag2 = False
    '        Exit Sub
    '    End If
    'End Sub
End Class
