<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.OpenCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnClient = New System.Windows.Forms.Button
        Me.btnAnimal = New System.Windows.Forms.Button
        Me.btnMember = New System.Windows.Forms.Button
        Me.btnVolunteer = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnIncident = New System.Windows.Forms.Button
        Me.btnDonation = New System.Windows.Forms.Button
        Me.btnMuni = New System.Windows.Forms.Button
        Me.btnRescue = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnMedical = New System.Windows.Forms.Button
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 501)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(817, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripSeparator9})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(817, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenCloseToolStripMenuItem, Me.mnuChangePasswordToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripDropDownButton1.Text = "File"
        '
        'OpenCloseToolStripMenuItem
        '
        Me.OpenCloseToolStripMenuItem.Name = "OpenCloseToolStripMenuItem"
        Me.OpenCloseToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.OpenCloseToolStripMenuItem.Text = "Open"
        '
        'mnuChangePasswordToolStripMenuItem
        '
        Me.mnuChangePasswordToolStripMenuItem.Name = "mnuChangePasswordToolStripMenuItem"
        Me.mnuChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.mnuChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnClient
        '
        Me.btnClient.Location = New System.Drawing.Point(60, 2)
        Me.btnClient.Name = "btnClient"
        Me.btnClient.Size = New System.Drawing.Size(52, 27)
        Me.btnClient.TabIndex = 10
        Me.btnClient.Text = "Client"
        Me.btnClient.UseVisualStyleBackColor = True
        '
        'btnAnimal
        '
        Me.btnAnimal.Location = New System.Drawing.Point(118, 2)
        Me.btnAnimal.Name = "btnAnimal"
        Me.btnAnimal.Size = New System.Drawing.Size(54, 27)
        Me.btnAnimal.TabIndex = 11
        Me.btnAnimal.Text = "Animal"
        Me.btnAnimal.UseVisualStyleBackColor = True
        '
        'btnMember
        '
        Me.btnMember.Location = New System.Drawing.Point(178, 2)
        Me.btnMember.Name = "btnMember"
        Me.btnMember.Size = New System.Drawing.Size(62, 27)
        Me.btnMember.TabIndex = 12
        Me.btnMember.Text = "Member"
        Me.btnMember.UseVisualStyleBackColor = True
        '
        'btnVolunteer
        '
        Me.btnVolunteer.Location = New System.Drawing.Point(246, 2)
        Me.btnVolunteer.Name = "btnVolunteer"
        Me.btnVolunteer.Size = New System.Drawing.Size(72, 27)
        Me.btnVolunteer.TabIndex = 13
        Me.btnVolunteer.Text = "Volunteer"
        Me.btnVolunteer.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(324, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 27)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Employee"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnIncident
        '
        Me.btnIncident.Location = New System.Drawing.Point(392, 2)
        Me.btnIncident.Name = "btnIncident"
        Me.btnIncident.Size = New System.Drawing.Size(62, 27)
        Me.btnIncident.TabIndex = 17
        Me.btnIncident.Text = "Incident"
        Me.btnIncident.UseVisualStyleBackColor = True
        '
        'btnDonation
        '
        Me.btnDonation.Location = New System.Drawing.Point(460, 2)
        Me.btnDonation.Name = "btnDonation"
        Me.btnDonation.Size = New System.Drawing.Size(62, 27)
        Me.btnDonation.TabIndex = 18
        Me.btnDonation.Text = "Donation"
        Me.btnDonation.UseVisualStyleBackColor = True
        '
        'btnMuni
        '
        Me.btnMuni.Location = New System.Drawing.Point(528, 2)
        Me.btnMuni.Name = "btnMuni"
        Me.btnMuni.Size = New System.Drawing.Size(66, 27)
        Me.btnMuni.TabIndex = 19
        Me.btnMuni.Text = "Municipal"
        Me.btnMuni.UseVisualStyleBackColor = True
        '
        'btnRescue
        '
        Me.btnRescue.Location = New System.Drawing.Point(600, 2)
        Me.btnRescue.Name = "btnRescue"
        Me.btnRescue.Size = New System.Drawing.Size(66, 27)
        Me.btnRescue.TabIndex = 20
        Me.btnRescue.Text = "Rescue"
        Me.btnRescue.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(744, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 27)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnMedical
        '
        Me.btnMedical.Location = New System.Drawing.Point(672, 2)
        Me.btnMedical.Name = "btnMedical"
        Me.btnMedical.Size = New System.Drawing.Size(66, 27)
        Me.btnMedical.TabIndex = 22
        Me.btnMedical.Text = "Medical"
        Me.btnMedical.UseVisualStyleBackColor = True
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 523)
        Me.Controls.Add(Me.btnMedical)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnRescue)
        Me.Controls.Add(Me.btnMuni)
        Me.Controls.Add(Me.btnDonation)
        Me.Controls.Add(Me.btnIncident)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnVolunteer)
        Me.Controls.Add(Me.btnMember)
        Me.Controls.Add(Me.btnAnimal)
        Me.Controls.Add(Me.btnClient)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.Name = "MDIParent1"
        Me.Text = "Safe Harbor Database"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents OpenCloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnClient As System.Windows.Forms.Button
    Friend WithEvents btnAnimal As System.Windows.Forms.Button
    Friend WithEvents btnMember As System.Windows.Forms.Button
    Friend WithEvents btnVolunteer As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents mnuChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnIncident As System.Windows.Forms.Button
    Friend WithEvents btnDonation As System.Windows.Forms.Button
    Friend WithEvents btnMuni As System.Windows.Forms.Button
    Friend WithEvents btnRescue As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnMedical As System.Windows.Forms.Button

End Class
