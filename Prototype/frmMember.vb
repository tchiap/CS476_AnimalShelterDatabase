' frmMember
' Member Form

' Tom Chiapete

Imports System.Data.OleDb

Public Class frmMember
    Inherits System.Windows.Forms.Form

    'Flags to determine behaviors and captions of buttons
    Dim Flag As Boolean = True
    Dim Flag2 As Boolean = True

    ' Connection OleDbConnection variable
    Dim Connect As New OleDbConnection


    ' Form load
    Private Sub frmMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Connection string - data source and provider
        Connect.ConnectionString = "Data Source=""C:\CAMODATA\CAMO.mdb""; Provider=""Microsoft.Jet.OLEDB.4.0"""

        ' Initially disable all fields
        disableFields()
    End Sub

    ' Add New and Save
    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click

        ' Enter data OLE command variable - for first INSERT - tblPerson
        Dim enterData As New OleDbCommand

        ' Get data OLE command variable - for SELECT - get ClientID for a join
        Dim getData As New OleDbCommand

        ' Enter data OLE command variable - for second INSERT - tblMembership
        Dim enterData3 As New OleDbCommand

        ' If our flag is set to true, change "Add New" button to "Save"
        ' Disable MemberID field.  Enable all fields.  Clear all fields.
        ' Finally, set flag to false
        If Flag = True Then
            btnAddNew.Text = "Save"
            txtMemberID.Enabled = False
            enableFields()
            clearFields()
            Flag = False
        Else

            ' If it doesn't pass our checks, exit this sub.
            If checkField() = False Then
                Exit Sub
            End If

            ' ------------------------------------------------------


            ' INSERT SQL to tblPerson
            enterData.CommandText = "INSERT INTO tblPerson ( FirstName, MiddleInitial, LastName, Address1, Address2, City, State, Zip, PrimaryPhone, AltPhone, Email, Notes) VALUES (?,?,?,?,?,?,?,?,?,?,?,?)"

            ' Add parameters
            enterData.Parameters.Add(New OleDbParameter("FirstName", "FirstName"))
            enterData.Parameters.Add(New OleDbParameter("MiddleInitial", "MiddleInitial"))
            enterData.Parameters.Add(New OleDbParameter("LastName", "LastName"))
            enterData.Parameters.Add(New OleDbParameter("Address1", "Address1"))
            enterData.Parameters.Add(New OleDbParameter("Address2", "Address2"))
            enterData.Parameters.Add(New OleDbParameter("City", "City"))
            enterData.Parameters.Add(New OleDbParameter("State", "State"))
            enterData.Parameters.Add(New OleDbParameter("Zip", "Zip"))
            enterData.Parameters.Add(New OleDbParameter("PrimaryPhone", "PrimaryPhone"))
            enterData.Parameters.Add(New OleDbParameter("AltPhone", "AltPhone"))
            enterData.Parameters.Add(New OleDbParameter("Email", "Email"))
            enterData.Parameters.Add(New OleDbParameter("Notes", "Notes"))

            ' Bring in data from form
            enterData.Parameters("FirstName").Value = txtFirstName.Text
            enterData.Parameters("MiddleInitial").Value = txtMiddleInitial.Text
            enterData.Parameters("LastName").Value = txtLastName.Text
            enterData.Parameters("Address1").Value = txtAddress1.Text
            enterData.Parameters("Address2").Value = txtAddress2.Text
            enterData.Parameters("City").Value = txtCity.Text
            enterData.Parameters("State").Value = txtState.Text
            enterData.Parameters("Zip").Value = txtZip.Text
            enterData.Parameters("PrimaryPhone").Value = txtPrimaryPhone.Text
            enterData.Parameters("AltPhone").Value = txtAltPhone.Text
            enterData.Parameters("Email").Value = txtEmail.Text
            enterData.Parameters("Notes").Value = rtxtNotes.Text


            ' Do First DB Write 
            enterData.Connection = Connect
            Connect.Open()
            enterData.ExecuteNonQuery()
            Connect.Close()

            ' ------------------------------------------------------------

            ' Look up member ID - SELECT SQL
            getData.CommandText = "SELECT ClientID FROM tblPerson WHERE FirstName=? and MiddleInitial=? and LastName=? and Address1=? and Address2=?"

            ' Add parameters
            getData.Parameters.Add(New OleDbParameter("FirstName", "FirstName"))
            getData.Parameters.Add(New OleDbParameter("MiddleInitial", "MiddleInitial"))
            getData.Parameters.Add(New OleDbParameter("LastName", "LastName"))
            getData.Parameters.Add(New OleDbParameter("Address1", "Address1"))
            getData.Parameters.Add(New OleDbParameter("Address2", "Address2"))

            ' Bring in data from form
            getData.Parameters("FirstName").Value = txtFirstName.Text
            getData.Parameters("MiddleInitial").Value = txtMiddleInitial.Text
            getData.Parameters("LastName").Value = txtLastName.Text
            getData.Parameters("Address1").Value = txtAddress1.Text
            getData.Parameters("Address2").Value = txtAddress2.Text

            ' Open connection
            getData.Connection = Connect
            Connect.Open()

            ' Declare a reader
            Dim reader As OleDbDataReader = getData.ExecuteReader

            ' Read into our reader
            reader.Read()

            Dim ClientID As String = ""

            ' Assuming we have a ClientID that exists, bring it in and store it into ClientID
            If reader.HasRows = True Then
                ClientID = reader(0)
            End If

            ' Close our reader and connection
            reader.Close()
            Connect.Close()

            ' ---------------------------------------------------------

            ' Write into Memberships - INSERT SQL
            enterData3.CommandText = "INSERT INTO tblMemberships (ID, MemID, RenewedDate, TypeOfMembership, MemDate, SourceOfMem) VALUES (?,?,?,?,?,?)"

            ' Add Parameters
            enterData3.Parameters.Add(New OleDbParameter("ID", "ID"))
            enterData3.Parameters.Add(New OleDbParameter("MemID", "MemID"))
            enterData3.Parameters.Add(New OleDbParameter("RenewedDate", "RenewedDate"))
            enterData3.Parameters.Add(New OleDbParameter("TypeOfMembership", "TypeOfMembership"))
            enterData3.Parameters.Add(New OleDbParameter("MemDate", "MemDate"))
            enterData3.Parameters.Add(New OleDbParameter("SourceOfMem", "SourceOfMem"))

            ' Bring in data from form, and ClientID from variable ClientID
            enterData3.Parameters("ID").Value = ClientID
            enterData3.Parameters("MemID").Value = txtFirstName.Text + txtPrimaryPhone.Text
            enterData3.Parameters("RenewedDate").Value = txtRenewDate.Text
            enterData3.Parameters("TypeOfMembership").Value = txtMemberType.Text
            enterData3.Parameters("MemDate").Value = txtMembershipDate.Text
            enterData3.Parameters("SourceOfMem").Value = cboReferrer.Text


            ' Do Second DB Write 
            enterData3.Connection = Connect
            Connect.Open()
            enterData3.ExecuteNonQuery()
            Connect.Close()

            ' Alert the user
            MsgBox("New Record Has Been Inserted.")

            ' Set flag to true, clear our fields, set MemberID to disabled
            ' Change caption to "Add New" and disable all fields
            Flag = True
            clearFields()
            txtMemberID.Enabled = True
            btnAddNew.Text = "Add New"
            disableFields()

        End If

    End Sub

    Private Sub btnModSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModSave.Click

        ' OleDbCommand variable for the UPDATE
        Dim updateData As New OleDbCommand

        ' If no MemberID is entered, tell them to enter something, and exit the sub
        If txtMemberID.Text = "" Then
            MsgBox("Please type the MemberID to search")
            Exit Sub
        End If

        ' If the flag is true, change the button caption to "Update"
        ' Enable all fields and set the flag back to false
        If Flag2 = True Then
            btnModSave.Text = "Update"
            txtMemberID.Enabled = False
            enableFields()
            Flag2 = False

            ' Otherwise, if flag is false
        Else

            ' Check and see if our input tests pass.  If it doesn't pass, 
            ' Exit the sub
            If checkField() = False Then
                Exit Sub
            End If

            updateData.Connection = Connect

            ' Set up UPDATE SQL
            Dim sqlString As String
            sqlString = "UPDATE tblPerson p, tblMemberships m SET FirstName = '" + txtFirstName.Text + "', "
            sqlString += "p.MiddleInitial = '" + txtMiddleInitial.Text + "', "
            sqlString += "p.LastName = '" + txtLastName.Text + "', "
            sqlString += "p.Address1 = '" + txtAddress1.Text + "', "
            sqlString += "p.Address2 = '" + txtAddress2.Text + "', "
            sqlString += "p.City = '" + txtCity.Text + "', "
            sqlString += "p.State = '" + txtState.Text + "', "
            sqlString += "p.Zip = '" + txtZip.Text + "', "
            sqlString += "p.PrimaryPhone = '" + txtPrimaryPhone.Text + "', "
            sqlString += "p.AltPhone = '" + txtAltPhone.Text + "', "
            sqlString += "p.Email = '" + txtEmail.Text + "', "
            sqlString += "p.Notes = '" + rtxtNotes.Text + "', "
            sqlString += "m.RenewedDate = '" + txtRenewDate.Text + "', "
            sqlString += "m.TypeOfMembership = '" + txtMemberType.Text + "', "
            sqlString += "m.MemDate = '" + txtMembershipDate.Text + "', "
            sqlString += "m.SourceOfMem = '" + cboReferrer.Text + "' "
            sqlString += "WHERE p.ClientID = m.ID AND ClientID = " + "?"



            updateData.CommandText = sqlString

            ' Add ClientID parameter
            updateData.Parameters.Add(New OleDbParameter("ClientID", System.Data.OleDb.OleDbType.Integer))

            updateData.Parameters(0).Value = txtMemberID.Text

            ' Open connection
            Connect.Open()
            updateData.ExecuteNonQuery()
            Connect.Close()

            ' Alert user of success - record has been update
            MessageBox.Show("This record has been updated.")

            ' Set MemberID to enabled, change caption to "Modify", 
            ' Set flag to true, disable all fields
            txtMemberID.Enabled = True
            btnModSave.Text = "Modify"
            Flag2 = True
            disableFields()

        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        ' OleDbCommand for SELECT
        Dim getData As New OleDbCommand

        ' If memberID is blank, let them know they need to enter one.  Exit Sub.
        If txtMemberID.Text = "" Then
            MsgBox("Please type the MemberID to search")
            Exit Sub
        End If

        ' Next, Disable All Fields
        disableFields()

        ' SELECT SQL - retrieve all field information
        getData.CommandText = "SELECT p.FirstName, p.MiddleInitial, p.LastName, p.Address1, p.Address2, p.City, p.State, p.Zip, p.PrimaryPhone, p.AltPhone, p.Email, p.Notes, m.MemDate, m.TypeOfMembership, m.RenewedDate, m.SourceOfMem FROM tblPerson p, tblMemberships m WHERE p.ClientID = m.ID and p.ClientID=?"

        ' Add parameters
        getData.Parameters.Add(New OleDbParameter("p.ClientID", "p.ClientID"))
        getData.Parameters.Add(New OleDbParameter("p.MiddleInitial", "p.MiddleInitial"))
        getData.Parameters.Add(New OleDbParameter("p.LastName", "p.LastName"))
        getData.Parameters.Add(New OleDbParameter("p.Address1", "p.Address1"))
        getData.Parameters.Add(New OleDbParameter("p.Address2", "p.Address2"))
        getData.Parameters.Add(New OleDbParameter("p.City", "p.City"))
        getData.Parameters.Add(New OleDbParameter("p.State", "p.State"))
        getData.Parameters.Add(New OleDbParameter("p.Zip", "p.Zip"))
        getData.Parameters.Add(New OleDbParameter("p.PrimaryPhone", "p.PrimaryPhone"))
        getData.Parameters.Add(New OleDbParameter("p.AltPhone", "p.AltPhone"))
        getData.Parameters.Add(New OleDbParameter("p.Email", "p.Email"))
        getData.Parameters.Add(New OleDbParameter("p.Notes", "p.Notes"))
        getData.Parameters.Add(New OleDbParameter("m.MemDate", "m.MemDate"))
        getData.Parameters.Add(New OleDbParameter("m.TypeOfMembership", "m.TypeOfMembership"))
        getData.Parameters.Add(New OleDbParameter("m.MemDate", "m.MemDate"))
        getData.Parameters.Add(New OleDbParameter("m.RenewedDate", "m.RenewedDate"))
        getData.Parameters.Add(New OleDbParameter("m.SourceOfMem", "m.SourceOfMem"))

        ' Bring in the MemberID from the form
        getData.Parameters("p.ClientID").Value = CInt(txtMemberID.Text)

        ' Open data connection
        getData.Connection = Connect
        Connect.Open()

        ' Declare a reader
        Dim reader As OleDbDataReader = getData.ExecuteReader

        ' Read in record
        reader.Read()

        ' Show results in form fields
        If reader.HasRows = True Then
            txtFirstName.Text = reader(0)
            txtMiddleInitial.Text = reader(1)
            txtLastName.Text = reader(2)
            txtAddress1.Text = reader(3)
            txtAddress2.Text = reader(4)
            txtCity.Text = reader(5)
            txtState.Text = reader(6)
            txtZip.Text = reader(7)
            txtPrimaryPhone.Text = reader(8)
            txtAltPhone.Text = reader(9)
            txtEmail.Text = reader(10)
            rtxtNotes.Text = reader(11)
            txtMembershipDate.Text = reader(12)
            txtMemberType.Text = reader(13)
            txtRenewDate.Text = reader(14)
            cboReferrer.Text = reader(15)

            ' Otherwise, if there was nobody with this member ID, alert the user
        Else
            MsgBox("There is no person with this Member ID.")
        End If

        ' Close reader and connection
        reader.Close()
        Connect.Close()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        ' Close form
        Me.Close()

    End Sub

    ' Disable all form fields - except member ID
    Private Sub disableFields()
        txtFirstName.Enabled = False
        txtMiddleInitial.Enabled = False
        txtLastName.Enabled = False
        txtAddress1.Enabled = False
        txtAddress2.Enabled = False
        txtCity.Enabled = False
        txtState.Enabled = False
        txtZip.Enabled = False
        txtPrimaryPhone.Enabled = False
        txtAltPhone.Enabled = False
        txtEmail.Enabled = False
        rtxtNotes.Enabled = False
        txtMembershipDate.Enabled = False
        txtMemberType.Enabled = False
        txtRenewDate.Enabled = False
        cboReferrer.Enabled = False
    End Sub

    ' Clear all form fields
    Private Sub clearFields()
        txtFirstName.Text = ""
        txtMiddleInitial.Text = ""
        txtLastName.Text = ""
        txtAddress1.Text = ""
        txtAddress2.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZip.Text = ""
        txtPrimaryPhone.Text = ""
        txtAltPhone.Text = ""
        txtEmail.Text = ""
        rtxtNotes.Text = ""
        txtMembershipDate.Text = ""
        txtMemberType.Text = ""
        txtRenewDate.Text = ""
        cboReferrer.Text = ""
    End Sub

    ' Enable all form fields - except member ID
    Private Sub enableFields()
        txtFirstName.Enabled = True
        txtMiddleInitial.Enabled = True
        txtLastName.Enabled = True
        txtAddress1.Enabled = True
        txtAddress2.Enabled = True
        txtCity.Enabled = True
        txtState.Enabled = True
        txtZip.Enabled = True
        txtPrimaryPhone.Enabled = True
        txtAltPhone.Enabled = True
        txtEmail.Enabled = True
        rtxtNotes.Enabled = True
        txtMembershipDate.Enabled = True
        txtMemberType.Enabled = True
        txtRenewDate.Enabled = True
        cboReferrer.Enabled = True
    End Sub

    ' Check for required fields
    ' Returns Boolean
    Public Function checkField() As Boolean

        ' If no first name is entered, return false
        If txtFirstName.Text = "" Then
            MsgBox("Please Enter a First Name")
            Return False

            ' If no phone number is entered, return false
        ElseIf txtPrimaryPhone.Text = "" Then
            MsgBox("Please Enter a Phone Number")
            Return False

            ' Otherwise, return true.
        Else
            Return True
        End If
    End Function

   
End Class