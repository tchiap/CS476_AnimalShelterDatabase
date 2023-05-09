Imports System.Data.OleDb
Public Class frmMuni
    Inherits System.Windows.Forms.Form
    Dim Connect As New OleDbConnection

    Private Sub frmMuni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect.ConnectionString = "Data Source=""C:\CAMODATA\CAMO.mdb""; Provider=""Microsoft.Jet.OLEDB.4.0"""
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim getData As New OleDbCommand
        If txtMuniID.Text = "" Then
            MsgBox("Please type the ID to search")
            Exit Sub
        End If
        'disable()

        getData.CommandText = "SELECT  MuniID, NameOfMuni, Rate , HoldingFacility, LawEnforcementContact  from tblMuni WHERE MuniID=?"

        getData.Parameters.Add(New OleDbParameter("MuniID", "MuniID"))

        getData.Parameters("MuniID").Value = txtMuniID.Text

        getData.Connection = Connect

        Connect.Open()
        Dim reader As OleDbDataReader = getData.ExecuteReader

        reader.Read()

        If reader.HasRows = True Then
            txtNameOfMuni.Text = reader(1)
            txtRate.Text = reader(2)
            txtHoldingFacility.Text = reader(3)
            txtLawEnforcementContact.Text = reader(4)
        End If

        reader.Close()
        Connect.Close()
    End Sub

  

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim updateData As New OleDbCommand
        If txtMuniID.Text = "" Then
            MsgBox("Please select a record to modify")
            Exit Sub
        End If

        updateData.Connection = Connect
        'enabletext()
        Dim sqlString As String

        sqlString = " UPDATE tblMuni SET NameOfMuni = '" & txtNameOfMuni.Text & "', Rate = '" & txtRate.Text & "', HoldingFacility = '" & txtHoldingFacility.Text & "', LawEnforcementContact = '" & txtLawEnforcementContact.Text & "' where MuniID=?"
        updateData.CommandText = sqlString

        updateData.Parameters.Add(New OleDbParameter("RescueID", System.Data.OleDb.OleDbType.Integer))
        updateData.Parameters(0).Value = Int(txtMuniID.Text)
        Connect.Open()
        updateData.ExecuteNonQuery()
        Connect.Close()
        MessageBox.Show("Updated")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim enterData As New OleDbCommand
        'MuniID, NameOfMuni, Rate , HoldingFacility, LawEnforcementContact
        enterData.CommandText = "INSERT INTO tblMuni ( NameOfMuni, Rate, HoldingFacility , LawEnforcementContact ) VALUES (?,?,?,?)"

        'enterData.Parameters.Add(New OleDbParameter("MuniID", "MuniID"))
        enterData.Parameters.Add(New OleDbParameter("NameOfMuni", "NameOfMuni"))
        enterData.Parameters.Add(New OleDbParameter("Rate", "Rate"))
        enterData.Parameters.Add(New OleDbParameter("HoldingFacility", "HoldingFacility"))
        enterData.Parameters.Add(New OleDbParameter("LawEnforcementContact", "LawEnforcmentContact"))

        'enterData.Parameters("MuniID").Value = txtMuniID.Text
        enterData.Parameters("NameOfMuni").Value = txtNameOfMuni.Text
        enterData.Parameters("Rate").Value = txtRate.Text
        enterData.Parameters("HoldingFacility").Value = txtHoldingFacility.Text
        enterData.Parameters("LawEnforcementContact").Value = txtLawEnforcementContact.Text
 
        enterData.Connection = Connect

        Connect.Open()

        enterData.ExecuteNonQuery()
        Connect.Close()
        MsgBox("Created")
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim DeleteData As New OleDbCommand
        DeleteData.CommandText = "DELETE FROM tblMuni where MuniID = ?"

        DeleteData.Parameters.Add(New OleDbParameter("MuniID", "MuniID"))

        DeleteData.Parameters("MuniID").Value = txtMuniID.Text

        DeleteData.Connection = Connect

        Connect.Open()

        DeleteData.ExecuteNonQuery()
        Connect.Close()
        MsgBox("Deleted")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Public Function clearfield() As Boolean

        txtNameOfMuni.Text = ""
        txtRate.Text = ""
        txtHoldingFacility.Text = ""
        txtLawEnforcementContact.Text = ""
    End Function

    Public Function disable() As Boolean


        txtNameOfMuni.Enabled = False
        txtRate.Enabled = False
        txtHoldingFacility.Enabled = False
        txtLawEnforcementContact.Enabled = False
    End Function

    Public Function enabletext() As Boolean

        txtNameOfMuni.Enabled = True
        txtRate.Enabled = True
        txtHoldingFacility.Enabled = True
        txtLawEnforcementContact.Enabled = True
    End Function

End Class