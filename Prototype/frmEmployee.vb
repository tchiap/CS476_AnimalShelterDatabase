Imports System.Data.OleDb

Public Class frmEmployee
    Dim Connect As New OleDbConnection
    ' Dim flag As Boolean = True
    Dim flag1 As Boolean = True

    Dim flag As Boolean = True
    'Dim flag2 As Boolean = True

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim getEmployee As New OleDbCommand
        getEmployee.Connection = Connect
        getEmployee.CommandText = "SELECT FirstName, MiddleInitial, LastName, Address1, Address2, City, State, Zip, PrimaryPhone, AltPhone, Email, Alias, loginName, DateOfBirth FROM tblPerson where ClientID=?"
        getEmployee.Parameters.Add(New OleDbParameter("ClientID", System.Data.OleDb.OleDbType.Integer))
        getEmployee.Parameters("ClientID").Value = CInt(txtEmpID.Text)
        Connect.Open()
        Dim reader As OleDbDataReader = getEmployee.ExecuteReader

        reader.Read()

        If reader.HasRows Then
            grpBasic.Enabled = True
            grpContact.Enabled = True
            txtFName.Text = reader(0)
            txtMidInit.Text = reader(1)
            txtLName.Text = reader(2)
            txtAddress1.Text = reader(3)
            txtAddress2.Text = reader(4)
            txtCity.Text = reader(5)
            txtState.Text = reader(6)
            txtZip.Text = reader(7)
            txtPriPhone.Text = reader(8)
            txtAltPhone.Text = reader(9)
            txtEmail.Text = reader(10)
            txtAlias.Text = reader(11)
            txtUsername.Text = reader(12)
            txtBirthday.Text = reader(13)


            reader.Close()
            Connect.Close()

            txtEmpID.Enabled = False
            txtUsername.Enabled = False
        Else
            MsgBox("No Employee Found.")
        End If
    End Sub

    Private Sub frmEmployee_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Connect.ConnectionString = "Data Source=""C:\CAMODATA\CAMO.mdb""; Provider=""Microsoft.Jet.OLEDB.4.0"""
        disable()
    End Sub

    
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        grpContact.Enabled = True
        grpBasic.Enabled = True
        If flag = False Then

            txtEmpID.Enabled = False
            Dim addEmployee As New OleDbCommand
            addEmployee.Connection = Connect
            addEmployee.CommandText = "INSERT INTO tblPerson ( FirstName, MiddleInitial, LastName, Address1, Address2, City, State, Zip, PrimaryPhone, AltPhone, Email, Alias, loginName,[password], DateOfBirth) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            'Connect.Open()
            Dim pwd As String = hashPassword("password")

            addEmployee.Parameters.Add(New OleDbParameter("FirstName", "FirstName"))
            addEmployee.Parameters.Add(New OleDbParameter("MiddleInitial", "MiddleInitial"))
            addEmployee.Parameters.Add(New OleDbParameter("LastName", "LastName"))
            addEmployee.Parameters.Add(New OleDbParameter("Address1", "Address1"))
            addEmployee.Parameters.Add(New OleDbParameter("Address2", "Address2"))
            addEmployee.Parameters.Add(New OleDbParameter("City", "City"))
            addEmployee.Parameters.Add(New OleDbParameter("State", "State"))
            addEmployee.Parameters.Add(New OleDbParameter("Zip", "Zip"))
            addEmployee.Parameters.Add(New OleDbParameter("Email", "Email"))
            addEmployee.Parameters.Add(New OleDbParameter("Alias", "Alias"))
            addEmployee.Parameters.Add(New OleDbParameter("PrimaryPhone", "PrimaryPhone"))
            addEmployee.Parameters.Add(New OleDbParameter("AltPhone", "AltPhone"))
            addEmployee.Parameters.Add(New OleDbParameter("Login", "Login"))
            addEmployee.Parameters.Add(New OleDbParameter("password", "password"))
            addEmployee.Parameters.Add(New OleDbParameter("DateOfBirth", "DateOfBirth"))

            addEmployee.Parameters("FirstName").Value = txtFName.Text
            addEmployee.Parameters("MiddleInitial").Value = txtMidInit.Text
            addEmployee.Parameters("LastName").Value = txtLName.Text
            addEmployee.Parameters("Address1").Value = txtAddress1.Text
            addEmployee.Parameters("Address2").Value = txtAddress2.Text
            addEmployee.Parameters("City").Value = txtCity.Text
            addEmployee.Parameters("State").Value = txtState.Text
            addEmployee.Parameters("Zip").Value = txtZip.Text
            addEmployee.Parameters("Email").Value = txtEmail.Text
            addEmployee.Parameters("Alias").Value = txtAlias.Text
            addEmployee.Parameters("PrimaryPhone").Value = txtPriPhone.Text
            addEmployee.Parameters("AltPhone").Value = txtAltPhone.Text
            addEmployee.Parameters("Login").Value = txtUsername.Text
            addEmployee.Parameters("password").Value = pwd
            addEmployee.Parameters("DateOfBirth").Value = CDate(txtBirthday.Text)

            Connect.Open()
            addEmployee.ExecuteNonQuery()
            Connect.Close()
            MsgBox("Record Inserted")
        Else
            grpContact.Enabled = True
            grpBasic.Enabled = True
            flag = False
            btnAdd.Text = "Save"
            clearBoxes()

        End If
       
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim updateEmployee As New OleDbCommand
        updateEmployee.Connection = Connect
        updateEmployee.CommandText = "UPDATE tblPerson SET FirstName='" & txtFName.Text & "', MiddleInitial='" & _
        txtMidInit.Text & "', LastName='" & txtLName.Text & "', Address1='" & txtAddress1.Text & "', Address2='" & _
        txtAddress2.Text & "', City='" & txtCity.Text & "', State='" & txtState.Text & "', Zip='" & txtZip.Text & "', PrimaryPhone='" & _
        txtPriPhone.Text & "', AltPhone='" & txtAltPhone.Text & "', Email='" & txtEmail.Text & "', Alias='" & txtAlias.Text & "', DateOfBirth = " & _
        CDate(txtBirthday.Text) & " where ClientID=?"

        Dim pwd As String = hashPassword("password")


        updateEmployee.Parameters.Add(New OleDbParameter("ClientID", System.Data.OleDb.OleDbType.Integer))
        updateEmployee.Parameters(0).Value = CInt(txtEmpID.Text)

        'updateEmployee.Parameters.Add(New OleDbParameter("ClientID", "ClientID"))
        'updateEmployee.Parameters.Add(New OleDbParameter("FirstName", "FirstName"))
        'updateEmployee.Parameters.Add(New OleDbParameter("MiddleInitial", "MiddleInitial"))
        'updateEmployee.Parameters.Add(New OleDbParameter("LastName", "LastName"))
        'updateEmployee.Parameters.Add(New OleDbParameter("Address1", "Address1"))
        'updateEmployee.Parameters.Add(New OleDbParameter("Address2", "Address2"))
        'updateEmployee.Parameters.Add(New OleDbParameter("City", "City"))
        'updateEmployee.Parameters.Add(New OleDbParameter("State", "State"))
        'updateEmployee.Parameters.Add(New OleDbParameter("Zip", "Zip"))
        'updateEmployee.Parameters.Add(New OleDbParameter("Email", "Email"))
        'updateEmployee.Parameters.Add(New OleDbParameter("Alias", "Alias"))
        'updateEmployee.Parameters.Add(New OleDbParameter("PrimaryPhone", "PrimaryPhone"))
        'updateEmployee.Parameters.Add(New OleDbParameter("AltPhone", "AltPhone"))

        'updateEmployee.Parameters("ClientID").Value = CInt(txtEmpID.Text)
        'updateEmployee.Parameters("FirstName").Value = txtFName.Text
        'updateEmployee.Parameters("MiddleInitial").Value = txtMidInit.Text
        'updateEmployee.Parameters("LastName").Value = txtLName.Text
        'updateEmployee.Parameters("Address1").Value = txtAddress1.Text
        'updateEmployee.Parameters("Address2").Value = txtAddress2.Text
        'updateEmployee.Parameters("City").Value = txtCity.Text
        'updateEmployee.Parameters("State").Value = txtState.Text
        'updateEmployee.Parameters("Zip").Value = txtZip.Text
        'updateEmployee.Parameters("Email").Value = txtEmail.Text
        'updateEmployee.Parameters("Alias").Value = txtAlias.Text
        'updateEmployee.Parameters("PrimaryPhone").Value = txtPriPhone.Text
        'updateEmployee.Parameters("AltPhone").Value = txtAltPhone.Text
       

        Connect.Open()
        updateEmployee.ExecuteNonQuery()
        Connect.Close()
        MsgBox("Record Updated")
    End Sub
    Public Sub clearBoxes()
        txtFName.Text = ""
        txtMidInit.Text = ""
        txtLName.Text = ""
        txtAddress1.Text = ""
        txtAddress2.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZip.Text = ""
        txtPriPhone.Text = ""
        txtAltPhone.Text = ""
        txtEmail.Text = ""
        txtAlias.Text = ""
        txtUsername.Text = ""
        txtBirthday.Text = ""
    End Sub
    

    Public Function disable() As Boolean


        txtFName.Enabled = False
        txtMidInit.Enabled = False
        txtLName.Enabled = False
        txtAddress1.Enabled = False
        txtAddress2.Enabled = False
        txtCity.Enabled = False
        txtState.Enabled = False
        txtZip.Enabled = False
        txtPriPhone.Enabled = False
        txtAltPhone.Enabled = False
        txtEmail.Enabled = False
        txtAlias.Enabled = False
        txtUsername.Enabled = False
        txtBirthday.Enabled = False
    End Function

    Public Function enabletext() As Boolean

        txtFName.Enabled = True
        txtMidInit.Enabled = True
        txtLName.Enabled = True
        txtAddress1.Enabled = True
        txtAddress2.Enabled = True
        txtCity.Enabled = True
        txtState.Enabled = True
        txtZip.Enabled = True
        txtPriPhone.Enabled = True
        txtAltPhone.Enabled = True
        txtEmail.Enabled = True
        txtAlias.Enabled = True
        txtUsername.Enabled = True
        txtBirthday.Enabled = True
    End Function

End Class