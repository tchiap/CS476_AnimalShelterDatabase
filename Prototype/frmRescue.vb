Imports System.Data.OleDb
Public Class frmRescue
    Inherits System.Windows.Forms.Form
    Dim Connect As New OleDbConnection
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim getData As New OleDbCommand
        If txtRescueID.Text = "" Then
            MsgBox("Please type the ID to search")
            Exit Sub
        End If
        'disable()

        getData.CommandText = "SELECT  RescueID, RescueName, RescueContact, Address, City , State, Zip, Phone, Email ,Website, Notes  from tblRescueGroups WHERE RescueID=?"

        getData.Parameters.Add(New OleDbParameter("RescueID", "RescueID"))

        getData.Parameters("RescueID").Value = txtRescueID.Text

        getData.Connection = Connect

        Connect.Open()
        Dim reader As OleDbDataReader = getData.ExecuteReader

        reader.Read()

        If reader.HasRows = True Then
            txtRescueName.Text = reader(1)
            txtRescueContact.Text = reader(2)
            txtAddress1.Text = reader(3)
            txtCity.Text = reader(4)
            txtState.Text = reader(5)
            txtZipCode.Text = reader(6)
            txtPhone1.Text = reader(7)
            txtEmail.Text = reader(8)
            txtWebSite.Text = reader(9)
            rtxtboxNotes.Text = reader(10)
        End If

        reader.Close()
        Connect.Close()
    End Sub

    Private Sub frmRescueGroups_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect.ConnectionString = "Data Source=""C:\CAMODATA\CAMO.mdb""; Provider=""Microsoft.Jet.OLEDB.4.0"""
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim enterData As New OleDbCommand
        enterData.CommandText = "INSERT INTO tblRescueGroups ( RescueID, RescueName, RescueContact, Address, City , State, Zip, Phone, Email ,Website, Notes ) VALUES (?,?,?,?,?,?,?,?,?,?,?)"

        enterData.Parameters.Add(New OleDbParameter("RescueID", "RescueID"))
        enterData.Parameters.Add(New OleDbParameter("RescueName", "RescueName"))
        enterData.Parameters.Add(New OleDbParameter("RescueContact", "RescueContact"))
        enterData.Parameters.Add(New OleDbParameter("Address", "Address"))
        enterData.Parameters.Add(New OleDbParameter("City", "City"))
        enterData.Parameters.Add(New OleDbParameter("State", "State "))
        enterData.Parameters.Add(New OleDbParameter("Zip", "Zip"))
        enterData.Parameters.Add(New OleDbParameter("Phone", "Phone"))
        enterData.Parameters.Add(New OleDbParameter("Email", "Email"))
        enterData.Parameters.Add(New OleDbParameter("Website", "Website"))
        enterData.Parameters.Add(New OleDbParameter("Notes", "Notes"))

        'enterData.Parameters.Add(New OleDbParameter("LoginName", "LoginName"))
        'enterData.Parameters.Add(new OleDbParameter("FirstName", system.Data.OleDb.OleDbType.VarWChar, 50, "FirstName")

        enterData.Parameters("RescueID").Value = txtRescueID.Text
        enterData.Parameters("RescueName").Value = txtRescueName.Text
        enterData.Parameters("RescueContact").Value = txtRescueContact.Text
        enterData.Parameters("Address").Value = txtAddress1.Text
        enterData.Parameters("City").Value = txtCity.Text
        enterData.Parameters("State").Value = txtState.Text
        enterData.Parameters("Zip").Value = txtZipCode.Text
        enterData.Parameters("Phone").Value = txtPhone1.Text
        enterData.Parameters("Email").Value = txtEmail.Text
        enterData.Parameters("Website").Value = txtWebSite.Text
        enterData.Parameters("Notes").Value = rtxtboxNotes.Text


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

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        ' Connect.ConnectionString = "Data Source=""C:\CAMODATA\CAMO.mdb""; Provider=""Microsoft.Jet.OLEDB.4.0"""
        Dim updateData As New OleDbCommand
        If txtRescueID.Text = "" Then
            MsgBox("Please select a record to modify")
            Exit Sub
        End If

        updateData.Connection = Connect
        'enabletext()
        Dim sqlString As String
        sqlString = " UPDATE tblRescueGroups SET RescueName = '" & txtRescueName.Text & "', RescueContact = '" & txtRescueContact.Text & "', Address = '" & txtAddress1.Text & "', City = '" & txtCity.Text & "', State = '" & txtState.Text & "', Zip = " & txtZipCode.Text & ", Phone = " & txtPhone1.Text & ", Email = '" & txtEmail.Text & "', Website = '" & txtWebSite.Text & "', Notes = '" & rtxtboxNotes.Text & "' where RescueID=?"
        updateData.CommandText = sqlString

        updateData.Parameters.Add(New OleDbParameter("RescueID", System.Data.OleDb.OleDbType.Integer))
        updateData.Parameters(0).Value = Int(txtRescueID.Text)
        Connect.Open()
        updateData.ExecuteNonQuery()
        Connect.Close()
        MessageBox.Show("Updated")
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim DeleteData As New OleDbCommand
        DeleteData.CommandText = "DELETE FROM tblRescueGroups where RescueID = ?"

        DeleteData.Parameters.Add(New OleDbParameter("RescueID", "RescueID"))

        DeleteData.Parameters("RescueID").Value = txtRescueID.Text

        DeleteData.Connection = Connect

        Connect.Open()

        DeleteData.ExecuteNonQuery()
        Connect.Close()
        MsgBox("Deleted")
    End Sub

    Public Function clearfield() As Boolean

        txtRescueName.Text = ""
        txtRescueContact.Text = ""
        txtAddress1.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZipCode.Text = ""
        txtPhone1.Text = ""
        txtEmail.Text = ""
        txtWebSite.Text = ""
        rtxtboxNotes.Text = ""
    End Function

    Public Function disable() As Boolean


        txtRescueName.Enabled = False
        txtRescueContact.Enabled = False
        txtAddress1.Enabled = False
        txtCity.Enabled = False
        txtState.Enabled = False
        txtZipCode.Enabled = False
        txtPhone1.Enabled = False
        txtEmail.Enabled = False
        txtWebSite.Enabled = False
        rtxtboxNotes.Enabled = False
    End Function

    Public Function enabletext() As Boolean

        txtRescueName.Enabled = True
        txtRescueContact.Enabled = True
        txtAddress1.Enabled = True
        txtCity.Enabled = True
        txtState.Enabled = True
        txtZipCode.Enabled = True
        txtPhone1.Enabled = True
        txtEmail.Enabled = True
        txtWebSite.Enabled = True
        rtxtboxNotes.Enabled = True
    End Function

End Class