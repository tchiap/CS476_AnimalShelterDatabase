
Imports System.Data.OleDb
Public Class frmDonation

    Inherits System.Windows.Forms.Form
    Dim Connect As New OleDbConnection
    Dim flag As Boolean = True
    Dim flag1 As Boolean = True
    Dim flag2 As Boolean = True
    Private Sub frmDonation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect.ConnectionString = "Data Source=""C:\CAMODATA\CAMO.mdb""; Provider=""Microsoft.Jet.OLEDB.4.0"""
        disable()

    End Sub

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
        txtPrimaryTel.Text = ""
        txtAlternateTel.Text = ""
        txtEmail.Text = ""
        rtbNote.Text = ""
        txtDonationNumber.Text = ""
        txtDonationDate.Text = ""
        txtAmount.Text = ""
        txtService.Text = ""
        txtTangible.Text = ""
        txtOrigin.Text = ""
        txtSpecific.Text = ""
        txtMemory.Text = ""
        txtMemorial.Text = ""

    End Function

    Public Function disable() As Boolean
        txtClientID.Enabled = False
        txtFirstName.Enabled = False
        txtMiddleInitial.Enabled = False
        txtLastName.Enabled = False
        txtAddress1.Enabled = False
        txtAddress2.Enabled = False
        txtCity.Enabled = False
        txtState.Enabled = False
        txtZipCode.Enabled = False
        txtPrimaryTel.Enabled = False
        txtAlternateTel.Enabled = False
        txtEmail.Enabled = False
        rtbNote.Enabled = False
        ' txtDonationNumber.Text = ""
        txtDonationDate.Enabled = False
        txtAmount.Enabled = False
        txtService.Enabled = False
        txtTangible.Enabled = False
        txtOrigin.Enabled = False
        txtSpecific.Enabled = False
        txtMemory.Enabled = False
        txtMemorial.Enabled = False

    End Function

    Public Function enabletext() As Boolean
        txtClientID.Enabled = True
        txtFirstName.Enabled = True
        txtMiddleInitial.Enabled = True
        txtLastName.Enabled = True
        txtAddress1.Enabled = True
        txtAddress2.Enabled = True
        txtCity.Enabled = True
        txtState.Enabled = True
        txtZipCode.Enabled = True
        txtPrimaryTel.Enabled = True
        txtAlternateTel.Enabled = True
        txtEmail.Enabled = True
        rtbNote.Enabled = True
        '  txtDonationNumber.Text = ""
        txtDonationDate.Enabled = True
        txtAmount.Enabled = True
        txtService.Enabled = True
        txtTangible.Enabled = True
        txtOrigin.Enabled = True
        txtSpecific.Enabled = True
        txtMemory.Enabled = True
        txtMemorial.Enabled = True
    End Function

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim enterData As New OleDbCommand


        If flag = True Then
            btnInsert.Text = "Save"
            txtDonationNumber.Enabled = False
            enabletext()
            clearfield()
            flag = False
        Else

            enterData.CommandText = "INSERT INTO tblDonations ( DonationDate, Amount, Service, TangibleDonation, OriginofDonation, SpecificDonation, ClientID, FirstName, MiddleInitial, LastName, Address1, Address2, City, State, Zip, PrimaryPhone, AltPhone, Email, Memorial, Memoryof, Notes ) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            'enterData.CommandText = "INSERT INTO tblDonations (ClientID,Amount,Service, TangibleDonation, OriginofDonation, SpecificDonation,  FirstName, MiddleInitial, LastName, Address1, Address2, City, State, Zip, PrimaryPhone, AltPhone, Email, Memorial, Memoryof, Notes ) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"

            enterData.Parameters.Add(New OleDbParameter("ClientID", "ClientID"))
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
            enterData.Parameters.Add(New OleDbParameter("Amount", "Amount"))
            enterData.Parameters.Add(New OleDbParameter("Service", "Service"))
            enterData.Parameters.Add(New OleDbParameter("TangibleDonation", "TangibleDonation"))
            enterData.Parameters.Add(New OleDbParameter("OriginofDonation", "OriginofDonation"))
            enterData.Parameters.Add(New OleDbParameter("SpecificDonation", "SpecificDonation"))
            enterData.Parameters.Add(New OleDbParameter("Memoryof", "Memoryof"))
            enterData.Parameters.Add(New OleDbParameter("Memorial", "Memorial"))
            enterData.Parameters.Add(New OleDbParameter("DonationDate", "DonationDate"))

            enterData.Parameters("ClientID").Value = CInt(txtClientID.Text)
            enterData.Parameters("FirstName").Value = txtFirstName.Text
            enterData.Parameters("MiddleInitial").Value = txtMiddleInitial.Text
            enterData.Parameters("LastName").Value = txtLastName.Text
            enterData.Parameters("Address1").Value = txtAddress1.Text
            enterData.Parameters("Address2").Value = txtAddress2.Text
            enterData.Parameters("City").Value = txtCity.Text
            enterData.Parameters("State").Value = txtState.Text
            enterData.Parameters("Zip").Value = txtZipcode.Text
            enterData.Parameters("PrimaryPhone").Value = txtPrimaryTel.Text
            enterData.Parameters("AltPhone").Value = txtAlternateTel.Text
            enterData.Parameters("Email").Value = txtEmail.Text
            enterData.Parameters("Notes").Value = rtbNote.Text
            enterData.Parameters("Amount").Value = CInt(txtAmount.Text)
            enterData.Parameters("Service").Value = txtService.Text
            enterData.Parameters("TangibleDonation").Value = txtTangible.Text
            enterData.Parameters("OriginofDonation").Value = txtOrigin.Text
            enterData.Parameters("SpecificDonation").Value = txtSpecific.Text
            enterData.Parameters("Memoryof").Value = txtMemory.Text
            enterData.Parameters("Memorial").Value = txtMemorial.Text
            enterData.Parameters("DonationDate").Value = CDate(txtDonationDate.Text)


            enterData.Connection = Connect

            Connect.Open()

            enterData.ExecuteNonQuery()
            Connect.Close()

            MsgBox("Record Inserted")
            flag = True
            clearfield()
            txtDonationNumber.Enabled = True
            btnInsert.Text = "Add New"
            disable()
        End If

    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim updateData As New OleDbCommand

        If txtDonationNumber.Text = "" Then
            MsgBox("Please select a record to modify")
            Exit Sub
        End If

        If flag1 = True Then
            btnModify.Text = "Update"
            txtDonationNumber.Enabled = False
            enabletext()
            ' clearfield()
            flag1 = False
        Else

            updateData.Connection = Connect

            Dim sqlString As String

            sqlString = " UPDATE tblDonations SET Memorial = '" & txtMemorial.Text & "', Memoryof = '" & txtMemory.Text & "',SpecificDonation = '" & txtSpecific.Text & "',OriginofDonation = '" & txtOrigin.Text & "',TangibleDonation = '" & txtTangible.Text & "', Amount = " & txtAmount.Text & ", Service = '" & txtService.Text & "', FirstName='" & txtFirstName.Text & "', MiddleInitial = '" & txtMiddleInitial.Text & "', LastName = '" & txtLastName.Text & "', Address1 = '" & txtAddress1.Text & "', Address2 = '" & txtAddress2.Text & "', City = '" & txtCity.Text & "', State = '" & txtState.Text & "', Zip = '" & txtZipcode.Text & "', PrimaryPhone = '" & txtPrimaryTel.Text & "', AltPhone = '" & txtAlternateTel.Text & "', Email = '" & txtEmail.Text & "', Notes = '" & rtbNote.Text & "', DonationDate = " & txtDonationDate.Text & " where DonationNumber=?"
            updateData.CommandText = sqlString

            updateData.Parameters.Add(New OleDbParameter("DonationNumber", System.Data.OleDb.OleDbType.Integer))

            updateData.Parameters(0).Value = txtDonationNumber.Text

            Connect.Open()
            updateData.ExecuteNonQuery()
            Connect.Close()
            MessageBox.Show("Updated")


            txtDonationNumber.Enabled = True
            btnModify.Text = "Modify"
            flag1 = True
            disable()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim getData As New OleDbCommand
        If txtDonationNumber.Text = "" Then
            MsgBox("Please type the DonationNumber to search")
            Exit Sub
        End If
        disable()

        getData.CommandText = "SELECT  DonationDate, Amount, Service, TangibleDonation, OriginofDonation, SpecificDonation, ClientID, FirstName, MiddleInitial, LastName, Address1, Address2, City, State, Zip, PrimaryPhone, AltPhone, Email, Memorial, Memoryof, Notes from tblDonations WHERE DonationNumber=?"

        getData.Parameters.Add(New OleDbParameter("DonationNumber", "DonationNumber"))

        getData.Parameters("DonationNumber").Value = txtDonationNumber.Text
        'MsgBox(getData.Parameters("DonationNumber").Value)
        getData.Connection = Connect

        Connect.Open()
        Dim reader As OleDbDataReader = getData.ExecuteReader

        reader.Read()

        If reader.HasRows = True Then
            txtDonationDate.Text = CDate(reader(0)).Date
            txtAmount.Text = reader(1)
            txtService.Text = reader(2)
            txtTangible.Text = reader(3)
            txtOrigin.Text = reader(4)
            txtSpecific.Text = reader(5)
            txtClientID.Text = reader(6)
            txtFirstName.Text = reader(7)
            txtMiddleInitial.Text = reader(8)
            txtLastName.Text = reader(9)
            txtAddress1.Text = reader(10)
            txtAddress2.Text = reader(11)
            txtCity.Text = reader(12)
            txtState.Text = reader(13)
            txtZipcode.Text = reader(14)
            txtPrimaryTel.Text = reader(15)
            txtAlternateTel.Text = reader(16)
            txtEmail.Text = reader(17)
            txtMemory.Text = reader(18)
            txtMemorial.Text = reader(19)
            rtbNote.Text = reader(20)
        End If

        reader.Close()
        Connect.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


End Class