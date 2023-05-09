Imports System.Data.OleDb
Public Class frmIncident

    Inherits System.Windows.Forms.Form
    Dim Connect As New OleDbConnection
    Dim flag As Boolean = True
    Dim flag1 As Boolean = True
    Dim flag2 As Boolean = True
  

    Private Sub frmIncident_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect.ConnectionString = "Data Source=""C:\CAMODATA\CAMO.mdb""; Provider=""Microsoft.Jet.OLEDB.4.0"""
        disable()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim getData As New OleDbCommand
        If txtIncidentID.Text = "" Then
            MsgBox("Please type the ClientID to search")
            Exit Sub
        End If
        disable()

        getData.CommandText = "SELECT AnimalLogNumber, IncidentDate, ClientID, EmployeeID, IncidentType, MuniID, Fee, Description, Notes from tblincident WHERE IncidentID=?"

        getData.Parameters.Add(New OleDbParameter("IncidentID", "IncidentID"))

        getData.Parameters("IncidentID").Value = txtIncidentID.Text

        getData.Connection = Connect

        Connect.Open()
        Dim reader As OleDbDataReader = getData.ExecuteReader

        reader.Read()

        If reader.HasRows = True Then

            txtAnimalID.Text = reader(0)
            txtDate.Text = reader(1)
            txtClientID.Text = reader(2)
            txtEmployeeID.Text = reader(3)
            txtIncidentType.Text = reader(4)
            txtMuniID.Text = reader(5)
            txtFee.Text = reader(6)
            txtDescription.Text = reader(7)
            rtbNote.Text = reader(8)

        End If

        reader.Close()
        Connect.Close()
    End Sub
    Public Function clearfield() As Boolean

        txtIncidentID.Text = ""
        txtAnimalID.Text = ""
        txtClientId.Text = ""
        txtMuniID.Text = ""
        txtEmployeeID.Text = ""
        txtIncidentType.Text = ""
        txtDate.Text = ""
        txtFee.Text = ""
        txtDescription.Text = ""
        rtbNote.Text = ""
    End Function

    Public Function disable() As Boolean


        txtAnimalID.Enabled = False
        txtClientID.Enabled = False
        txtMuniID.Enabled = False
        txtEmployeeID.Enabled = False
        txtIncidentType.Enabled = False
        txtDate.Enabled = False
        txtFee.Enabled = False
        txtDescription.Enabled = False
        rtbNote.Enabled = False
    End Function

    Public Function enabletext() As Boolean

        txtAnimalID.Enabled = True
        txtClientID.Enabled = True
        txtMuniID.Enabled = True
        txtEmployeeID.Enabled = True
        txtIncidentType.Enabled = True
        txtDate.Enabled = True
        txtFee.Enabled = True
        txtDescription.Enabled = True
        rtbNote.Enabled = True
    End Function

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim enterData As New OleDbCommand

        If flag = True Then
            btnInsert.Text = "Save"
            txtIncidentID.Enabled = False
            enabletext()
            clearfield()
            flag = False
        Else

            enterData.CommandText = "INSERT INTO tblIncident ( AnimalLogNumber, IncidentDate, ClientID, EmployeeID, IncidentType, MuniID, Fee, Description, Notes ) VALUES (?,?,?,?,?,?,?,?,?)"

            ' enterData.Parameters.Add(New OleDbParameter("ClientID", "ClientID"))
            enterData.Parameters.Add(New OleDbParameter("AnimalLogNumber", "AnimalLogNumber"))
            enterData.Parameters.Add(New OleDbParameter("IncidentDate", "IncidentDate"))
            enterData.Parameters.Add(New OleDbParameter("ClientID", "ClientID"))
            enterData.Parameters.Add(New OleDbParameter("EmployeeID", "EmployeeID"))
            enterData.Parameters.Add(New OleDbParameter("IncidentType", "IncidentType"))
            enterData.Parameters.Add(New OleDbParameter("MuniID", "MuniID"))
            enterData.Parameters.Add(New OleDbParameter("Fee", "Fee"))
            enterData.Parameters.Add(New OleDbParameter("Description", "Description"))
            enterData.Parameters.Add(New OleDbParameter("Notes", "Notes"))
   

            ' enterData.Parameters("ClientID").Value = txtClientID.Text
            enterData.Parameters("AnimalLogNumber").Value = txtAnimalID.Text
            enterData.Parameters("IncidentDate").Value = CDate(txtDate.Text)
            enterData.Parameters("ClientID").Value = txtClientID.Text
            enterData.Parameters("EmployeeID").Value = txtEmployeeID.Text
            enterData.Parameters("IncidentType").Value = txtIncidentType.Text
            enterData.Parameters("MuniID").Value = txtMuniID.Text
            enterData.Parameters("Fee").Value = txtFee.Text
            enterData.Parameters("Description").Value = txtDescription.Text
            enterData.Parameters("Notes").Value = rtbNote.Text
            


            enterData.Connection = Connect

            Connect.Open()

            enterData.ExecuteNonQuery()
            Connect.Close()

            MsgBox("Record Inserted")
            flag = True
            clearfield()
            txtIncidentID.Enabled = True
            btnInsert.Text = "Add New"
            disable()
        End If
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Connect.ConnectionString = "Data Source=""C:\CAMODATA\CAMO.mdb""; Provider=""Microsoft.Jet.OLEDB.4.0"""
        Dim updateData As New OleDbCommand

        If txtIncidentID.Text = "" Then
            MsgBox("Please select a record to modify")
            Exit Sub
        End If

        If flag1 = True Then
            btnModify.Text = "Update"
            txtIncidentID.Enabled = False
            enabletext()
            ' clearfield()
            flag1 = False
        Else

           
            updateData.Connection = Connect

            Dim sqlString As String
            sqlString = " UPDATE tblIncident SET AnimalLogNumber='" & txtAnimalID.Text & "', IncidentDate = " & txtDate.Text & ", ClientID = " & txtClientID.Text & ", EmployeeID = " & txtEmployeeID.Text & ", IncidentType = " & txtIncidentType.Text & ", Fee = " & txtFee.Text & ", Description = '" & txtDescription.Text & "', MuniId = " & CInt(txtMuniID.Text) & ", Notes = '" & rtbNote.Text & "' where IncidentID=?"
            updateData.CommandText = sqlString

            updateData.Parameters.Add(New OleDbParameter("IncidentID", System.Data.OleDb.OleDbType.Integer))
            'updateData.Parameters.Add(New OleDbParameter("FirstName", System.Data.OleDb.OleDbType.WChar))


            updateData.Parameters(0).Value = txtIncidentID.Text
            ' updateData.Parameters("FirstName").Value = "Jay"
            Connect.Open()
            updateData.ExecuteNonQuery()
            Connect.Close()
            MessageBox.Show("Updated")


            txtIncidentID.Enabled = True
            btnModify.Text = "Modify"
            flag1 = True
            disable()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class