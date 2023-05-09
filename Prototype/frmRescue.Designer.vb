<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRescue
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtState = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtZipCode = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPhone1 = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtWebSite = New System.Windows.Forms.TextBox
        Me.rtxtboxNotes = New System.Windows.Forms.RichTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRescueID = New System.Windows.Forms.TextBox
        Me.txtRescueName = New System.Windows.Forms.TextBox
        Me.txtRescueContact = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(110, 154)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(104, 23)
        Me.txtCity.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 18)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Address"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "City"
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(110, 120)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(144, 23)
        Me.txtAddress1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "State"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(110, 184)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(24, 23)
        Me.txtState.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 18)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Zipcode"
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(110, 215)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(56, 23)
        Me.txtZipCode.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 245)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 18)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Telephone"
        '
        'txtPhone1
        '
        Me.txtPhone1.Location = New System.Drawing.Point(110, 245)
        Me.txtPhone1.Name = "txtPhone1"
        Me.txtPhone1.Size = New System.Drawing.Size(104, 23)
        Me.txtPhone1.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(110, 279)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(104, 23)
        Me.txtEmail.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(6, 279)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 18)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Email"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtWebSite)
        Me.GroupBox1.Controls.Add(Me.rtxtboxNotes)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtRescueID)
        Me.GroupBox1.Controls.Add(Me.txtRescueName)
        Me.GroupBox1.Controls.Add(Me.txtRescueContact)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtAddress1)
        Me.GroupBox1.Controls.Add(Me.txtPhone1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtZipCode)
        Me.GroupBox1.Controls.Add(Me.txtState)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 522)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rescue Information"
        '
        'txtWebSite
        '
        Me.txtWebSite.Location = New System.Drawing.Point(110, 313)
        Me.txtWebSite.Name = "txtWebSite"
        Me.txtWebSite.Size = New System.Drawing.Size(100, 23)
        Me.txtWebSite.TabIndex = 10
        '
        'rtxtboxNotes
        '
        Me.rtxtboxNotes.Location = New System.Drawing.Point(47, 358)
        Me.rtxtboxNotes.Name = "rtxtboxNotes"
        Me.rtxtboxNotes.Size = New System.Drawing.Size(207, 141)
        Me.rtxtboxNotes.TabIndex = 11
        Me.rtxtboxNotes.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 358)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 15)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Notes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 15)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "WebSite"
        '
        'txtRescueID
        '
        Me.txtRescueID.Location = New System.Drawing.Point(110, 24)
        Me.txtRescueID.Name = "txtRescueID"
        Me.txtRescueID.Size = New System.Drawing.Size(100, 23)
        Me.txtRescueID.TabIndex = 1
        '
        'txtRescueName
        '
        Me.txtRescueName.Location = New System.Drawing.Point(110, 55)
        Me.txtRescueName.Name = "txtRescueName"
        Me.txtRescueName.Size = New System.Drawing.Size(100, 23)
        Me.txtRescueName.TabIndex = 2
        '
        'txtRescueContact
        '
        Me.txtRescueContact.Location = New System.Drawing.Point(110, 85)
        Me.txtRescueContact.Name = "txtRescueContact"
        Me.txtRescueContact.Size = New System.Drawing.Size(100, 23)
        Me.txtRescueContact.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Rescue Contact"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "RescueID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Rescue Name"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(306, 173)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(103, 27)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(306, 262)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 27)
        Me.btnSave.TabIndex = 60
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(306, 215)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(103, 27)
        Me.btnModify.TabIndex = 59
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(306, 300)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(103, 27)
        Me.btnDelete.TabIndex = 62
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(306, 347)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(103, 27)
        Me.btnClose.TabIndex = 63
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmRescue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 564)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRescue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rescue Groups"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPhone1 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRescueID As System.Windows.Forms.TextBox
    Friend WithEvents txtRescueName As System.Windows.Forms.TextBox
    Friend WithEvents txtRescueContact As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtWebSite As System.Windows.Forms.TextBox
    Friend WithEvents rtxtboxNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
