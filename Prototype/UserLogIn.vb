Imports System.Data.OleDb

Public Class UserLogIn
    Dim thisParent As System.Windows.Forms.Form
    Public Sub grabForm(ByVal thisForm As System.Windows.Forms.Form)
        thisParent = thisForm
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim username As String = txtUserName.Text
        Dim password As String = txtPassword.Text
        Dim Connect As New OleDbConnection
        Connect.ConnectionString = "Data Source=""C:\CAMODATA\CAMO.mdb""; Provider=""Microsoft.Jet.OLEDB.4.0"""
        Dim getData As New OleDbCommand

        getData.CommandText = "SELECT password,ClientID from tblPerson WHERE LoginName=?"
        getData.Parameters.Add(New OleDbParameter("Login", "Login"))
        getData.Parameters("Login").Value = username
        getData.Connection = Connect

        Connect.Open()
        Dim reader As OleDbDataReader = getData.ExecuteReader
        reader.Read()

        If reader.HasRows = True Then

            Dim pwd As String = CStr(reader(0))
            loggedInID = CInt(reader(1))
            password = hashPassword(password)
            If pwd.Equals(password) Then

                MessageBox.Show("Welcome.")
                loggedInUser = username
                currPass = pwd
                Connect.Close()
                Me.Close()
            End If

        Else
            MsgBox("Username does not exist.")
        End If
        reader.Close()
        Connect.Close()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        thisParent.Close()

    End Sub

End Class
