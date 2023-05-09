Imports System.Drawing
Public Class frmMainMDI
    Inherits System.Windows.Forms.Form

    ' This Stores Information About the Currently Logged in User
    '    Dim currentUser As New UserObject
    Dim graphics As System.Drawing.Graphics


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents tlbtnNew As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbtnOpen As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbtnSave As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbtlDivider1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbtnCut As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbtnCopy As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbtnPaste As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbtlDivider2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolbarPanel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents mnuViewDynamicContent As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileOpen As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuView As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOptions As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReports As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWindow As System.Windows.Forms.MenuItem
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents tlbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbtnPrintPreview As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbtnDivider3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbtnHelp As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuViewShowStatusBar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileLogout As System.Windows.Forms.MenuItem
    Friend WithEvents tlbtnViewRecord As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbtnDeleteRecord As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbtnDivider4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents contentpanel As System.Windows.Forms.Panel
    Friend WithEvents mnuFileChangePass As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileSysAdmin As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFilePrintSetup As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFilePrintReports As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileSep3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewToolbar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWinTileH As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWinTileV As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWinCascade As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWinSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuAdd As System.Windows.Forms.ContextMenu
    Friend WithEvents cmnuModify As System.Windows.Forms.ContextMenu
    Friend WithEvents cmnuView As System.Windows.Forms.ContextMenu
    Friend WithEvents cmnuDelete As System.Windows.Forms.ContextMenu
    Friend WithEvents cmnuAddAnimal As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuAddClient As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuAddMember As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuAddVolunteer As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuModifyAnimal As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuModifyClient As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuModifyMember As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuModifVolunteer As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuViewAnimal As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuViewClient As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuViewMember As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuViewVolunteer As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents tlbtnAnimal As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbtnClient As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMainMDI))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFileOpen = New System.Windows.Forms.MenuItem
        Me.mnuFileLogout = New System.Windows.Forms.MenuItem
        Me.mnuFileSep1 = New System.Windows.Forms.MenuItem
        Me.mnuFileChangePass = New System.Windows.Forms.MenuItem
        Me.mnuFileSysAdmin = New System.Windows.Forms.MenuItem
        Me.mnuFileSep2 = New System.Windows.Forms.MenuItem
        Me.mnuFilePrintSetup = New System.Windows.Forms.MenuItem
        Me.mnuFilePrintReports = New System.Windows.Forms.MenuItem
        Me.mnuFileSep3 = New System.Windows.Forms.MenuItem
        Me.mnuFileExit = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuView = New System.Windows.Forms.MenuItem
        Me.mnuViewToolbar = New System.Windows.Forms.MenuItem
        Me.mnuViewDynamicContent = New System.Windows.Forms.MenuItem
        Me.mnuViewShowStatusBar = New System.Windows.Forms.MenuItem
        Me.mnuOptions = New System.Windows.Forms.MenuItem
        Me.mnuReports = New System.Windows.Forms.MenuItem
        Me.mnuWindow = New System.Windows.Forms.MenuItem
        Me.mnuWinTileH = New System.Windows.Forms.MenuItem
        Me.mnuWinTileV = New System.Windows.Forms.MenuItem
        Me.mnuWinCascade = New System.Windows.Forms.MenuItem
        Me.mnuWinSep1 = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.mnuHelpHelp = New System.Windows.Forms.MenuItem
        Me.mnuHelpAbout = New System.Windows.Forms.MenuItem
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.ToolbarPanel1 = New System.Windows.Forms.Panel
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.tlbtnNew = New System.Windows.Forms.ToolBarButton
        Me.tlbtnOpen = New System.Windows.Forms.ToolBarButton
        Me.tlbtnSave = New System.Windows.Forms.ToolBarButton
        Me.tlbtlDivider1 = New System.Windows.Forms.ToolBarButton
        Me.tlbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.tlbtnPrintPreview = New System.Windows.Forms.ToolBarButton
        Me.tlbtlDivider2 = New System.Windows.Forms.ToolBarButton
        Me.tlbtnCut = New System.Windows.Forms.ToolBarButton
        Me.tlbtnCopy = New System.Windows.Forms.ToolBarButton
        Me.tlbtnPaste = New System.Windows.Forms.ToolBarButton
        Me.tlbtnDivider3 = New System.Windows.Forms.ToolBarButton
        Me.tlbtnAnimal = New System.Windows.Forms.ToolBarButton
        Me.tlbtnClient = New System.Windows.Forms.ToolBarButton
        Me.tlbtnViewRecord = New System.Windows.Forms.ToolBarButton
        Me.cmnuView = New System.Windows.Forms.ContextMenu
        Me.cmnuViewAnimal = New System.Windows.Forms.MenuItem
        Me.cmnuViewClient = New System.Windows.Forms.MenuItem
        Me.cmnuViewMember = New System.Windows.Forms.MenuItem
        Me.cmnuViewVolunteer = New System.Windows.Forms.MenuItem
        Me.tlbtnDeleteRecord = New System.Windows.Forms.ToolBarButton
        Me.cmnuDelete = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.tlbtnDivider4 = New System.Windows.Forms.ToolBarButton
        Me.tlbtnHelp = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmnuAdd = New System.Windows.Forms.ContextMenu
        Me.cmnuAddAnimal = New System.Windows.Forms.MenuItem
        Me.cmnuAddClient = New System.Windows.Forms.MenuItem
        Me.cmnuAddMember = New System.Windows.Forms.MenuItem
        Me.cmnuAddVolunteer = New System.Windows.Forms.MenuItem
        Me.cmnuModify = New System.Windows.Forms.ContextMenu
        Me.cmnuModifyAnimal = New System.Windows.Forms.MenuItem
        Me.cmnuModifyClient = New System.Windows.Forms.MenuItem
        Me.cmnuModifyMember = New System.Windows.Forms.MenuItem
        Me.cmnuModifVolunteer = New System.Windows.Forms.MenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.contentpanel = New System.Windows.Forms.Panel
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolbarPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuEdit, Me.mnuView, Me.mnuOptions, Me.mnuReports, Me.mnuWindow, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileOpen, Me.mnuFileLogout, Me.mnuFileSep1, Me.mnuFileChangePass, Me.mnuFileSysAdmin, Me.mnuFileSep2, Me.mnuFilePrintSetup, Me.mnuFilePrintReports, Me.mnuFileSep3, Me.mnuFileExit})
        Me.mnuFile.Text = "File"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Index = 0
        Me.mnuFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.mnuFileOpen.Text = "Login To Database"
        '
        'mnuFileLogout
        '
        Me.mnuFileLogout.Enabled = False
        Me.mnuFileLogout.Index = 1
        Me.mnuFileLogout.Text = "Logout"
        '
        'mnuFileSep1
        '
        Me.mnuFileSep1.Index = 2
        Me.mnuFileSep1.Text = "-"
        '
        'mnuFileChangePass
        '
        Me.mnuFileChangePass.Enabled = False
        Me.mnuFileChangePass.Index = 3
        Me.mnuFileChangePass.Text = "Change User Password"
        '
        'mnuFileSysAdmin
        '
        Me.mnuFileSysAdmin.Enabled = False
        Me.mnuFileSysAdmin.Index = 4
        Me.mnuFileSysAdmin.Text = "System Administration"
        '
        'mnuFileSep2
        '
        Me.mnuFileSep2.Index = 5
        Me.mnuFileSep2.Text = "-"
        '
        'mnuFilePrintSetup
        '
        Me.mnuFilePrintSetup.Enabled = False
        Me.mnuFilePrintSetup.Index = 6
        Me.mnuFilePrintSetup.Text = "Printer Setup"
        '
        'mnuFilePrintReports
        '
        Me.mnuFilePrintReports.Enabled = False
        Me.mnuFilePrintReports.Index = 7
        Me.mnuFilePrintReports.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.mnuFilePrintReports.Text = "Print Reports"
        '
        'mnuFileSep3
        '
        Me.mnuFileSep3.Index = 8
        Me.mnuFileSep3.Text = "-"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Index = 9
        Me.mnuFileExit.Shortcut = System.Windows.Forms.Shortcut.AltF4
        Me.mnuFileExit.Text = "Exit C.A.M.O."
        '
        'mnuEdit
        '
        Me.mnuEdit.Enabled = False
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "Edit"
        Me.mnuEdit.Visible = False
        '
        'mnuView
        '
        Me.mnuView.Index = 2
        Me.mnuView.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuViewToolbar, Me.mnuViewDynamicContent, Me.mnuViewShowStatusBar})
        Me.mnuView.Text = "View"
        '
        'mnuViewToolbar
        '
        Me.mnuViewToolbar.Checked = True
        Me.mnuViewToolbar.Index = 0
        Me.mnuViewToolbar.Text = "Show Toolbar"
        '
        'mnuViewDynamicContent
        '
        Me.mnuViewDynamicContent.Index = 1
        Me.mnuViewDynamicContent.Text = "Show Dynamic Content Panel"
        Me.mnuViewDynamicContent.Visible = False
        '
        'mnuViewShowStatusBar
        '
        Me.mnuViewShowStatusBar.Checked = True
        Me.mnuViewShowStatusBar.Index = 2
        Me.mnuViewShowStatusBar.Text = "Show Statusbar"
        '
        'mnuOptions
        '
        Me.mnuOptions.Enabled = False
        Me.mnuOptions.Index = 3
        Me.mnuOptions.Text = "Options"
        Me.mnuOptions.Visible = False
        '
        'mnuReports
        '
        Me.mnuReports.Enabled = False
        Me.mnuReports.Index = 4
        Me.mnuReports.Text = "Reports"
        Me.mnuReports.Visible = False
        '
        'mnuWindow
        '
        Me.mnuWindow.Index = 5
        Me.mnuWindow.MdiList = True
        Me.mnuWindow.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuWinTileH, Me.mnuWinTileV, Me.mnuWinCascade, Me.mnuWinSep1})
        Me.mnuWindow.Text = "Window"
        '
        'mnuWinTileH
        '
        Me.mnuWinTileH.Index = 0
        Me.mnuWinTileH.Text = "Tile Windows Horizontally"
        '
        'mnuWinTileV
        '
        Me.mnuWinTileV.Index = 1
        Me.mnuWinTileV.Text = "Tile Windows Vertically"
        '
        'mnuWinCascade
        '
        Me.mnuWinCascade.Index = 2
        Me.mnuWinCascade.Text = "Cascade Open Windows"
        '
        'mnuWinSep1
        '
        Me.mnuWinSep1.Index = 3
        Me.mnuWinSep1.Text = "-"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 6
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHelpHelp, Me.mnuHelpAbout})
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpHelp
        '
        Me.mnuHelpHelp.Index = 0
        Me.mnuHelpHelp.Text = "Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Index = 1
        Me.mnuHelpAbout.Text = "About C.A.M.O."
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 663)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(958, 24)
        Me.StatusBar1.TabIndex = 5
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel1.Text = "C.A.M.O. - Countryside Animal and Membership Organizer"
        Me.StatusBarPanel1.Width = 942
        '
        'ToolbarPanel1
        '
        Me.ToolbarPanel1.Controls.Add(Me.ToolBar1)
        Me.ToolbarPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ToolbarPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ToolbarPanel1.Name = "ToolbarPanel1"
        Me.ToolbarPanel1.Size = New System.Drawing.Size(958, 54)
        Me.ToolbarPanel1.TabIndex = 9
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tlbtnNew, Me.tlbtnOpen, Me.tlbtnSave, Me.tlbtlDivider1, Me.tlbtnPrint, Me.tlbtnPrintPreview, Me.tlbtlDivider2, Me.tlbtnCut, Me.tlbtnCopy, Me.tlbtnPaste, Me.tlbtnDivider3, Me.tlbtnAnimal, Me.tlbtnClient, Me.tlbtnViewRecord, Me.tlbtnDeleteRecord, Me.tlbtnDivider4, Me.tlbtnHelp})
        Me.ToolBar1.Divider = False
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(10, 4)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(732, 40)
        Me.ToolBar1.TabIndex = 2
        Me.ToolBar1.Wrappable = False
        '
        'tlbtnNew
        '
        Me.tlbtnNew.ImageIndex = 0
        Me.tlbtnNew.Text = "New"
        Me.tlbtnNew.ToolTipText = "New"
        Me.tlbtnNew.Visible = False
        '
        'tlbtnOpen
        '
        Me.tlbtnOpen.ImageIndex = 1
        Me.tlbtnOpen.Text = "Login"
        Me.tlbtnOpen.ToolTipText = "Login to CAMO"
        '
        'tlbtnSave
        '
        Me.tlbtnSave.Enabled = False
        Me.tlbtnSave.ImageIndex = 2
        Me.tlbtnSave.Text = "Save"
        Me.tlbtnSave.ToolTipText = "Save"
        Me.tlbtnSave.Visible = False
        '
        'tlbtlDivider1
        '
        Me.tlbtlDivider1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tlbtnPrint
        '
        Me.tlbtnPrint.Enabled = False
        Me.tlbtnPrint.ImageIndex = 8
        Me.tlbtnPrint.Text = "Print"
        Me.tlbtnPrint.ToolTipText = "Print"
        '
        'tlbtnPrintPreview
        '
        Me.tlbtnPrintPreview.Enabled = False
        Me.tlbtnPrintPreview.ImageIndex = 10
        Me.tlbtnPrintPreview.Text = "Print Preview"
        Me.tlbtnPrintPreview.ToolTipText = "Print Preview"
        '
        'tlbtlDivider2
        '
        Me.tlbtlDivider2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tlbtnCut
        '
        Me.tlbtnCut.Enabled = False
        Me.tlbtnCut.ImageIndex = 3
        Me.tlbtnCut.Text = "Cut"
        Me.tlbtnCut.ToolTipText = "Cut"
        Me.tlbtnCut.Visible = False
        '
        'tlbtnCopy
        '
        Me.tlbtnCopy.Enabled = False
        Me.tlbtnCopy.ImageIndex = 4
        Me.tlbtnCopy.Text = "Copy"
        Me.tlbtnCopy.ToolTipText = "Copy"
        Me.tlbtnCopy.Visible = False
        '
        'tlbtnPaste
        '
        Me.tlbtnPaste.Enabled = False
        Me.tlbtnPaste.ImageIndex = 5
        Me.tlbtnPaste.Text = "Paste"
        Me.tlbtnPaste.ToolTipText = "Paste"
        Me.tlbtnPaste.Visible = False
        '
        'tlbtnDivider3
        '
        Me.tlbtnDivider3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        Me.tlbtnDivider3.Visible = False
        '
        'tlbtnAnimal
        '
        Me.tlbtnAnimal.Enabled = False
        Me.tlbtnAnimal.ImageIndex = 16
        Me.tlbtnAnimal.Text = "Animals"
        Me.tlbtnAnimal.ToolTipText = "Open Animal Form"
        '
        'tlbtnClient
        '
        Me.tlbtnClient.Enabled = False
        Me.tlbtnClient.ImageIndex = 16
        Me.tlbtnClient.Text = "Clients"
        Me.tlbtnClient.ToolTipText = "Open Client Form"
        '
        'tlbtnViewRecord
        '
        Me.tlbtnViewRecord.DropDownMenu = Me.cmnuView
        Me.tlbtnViewRecord.ImageIndex = 16
        Me.tlbtnViewRecord.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
        Me.tlbtnViewRecord.Text = "View Entry"
        Me.tlbtnViewRecord.ToolTipText = "View Entry"
        Me.tlbtnViewRecord.Visible = False
        '
        'cmnuView
        '
        Me.cmnuView.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmnuViewAnimal, Me.cmnuViewClient, Me.cmnuViewMember, Me.cmnuViewVolunteer})
        '
        'cmnuViewAnimal
        '
        Me.cmnuViewAnimal.Index = 0
        Me.cmnuViewAnimal.Text = "View Animal Record"
        '
        'cmnuViewClient
        '
        Me.cmnuViewClient.Index = 1
        Me.cmnuViewClient.Text = "View Client Record"
        '
        'cmnuViewMember
        '
        Me.cmnuViewMember.Index = 2
        Me.cmnuViewMember.Text = "View Member Record"
        '
        'cmnuViewVolunteer
        '
        Me.cmnuViewVolunteer.Index = 3
        Me.cmnuViewVolunteer.Text = "View Volunteer Record"
        '
        'tlbtnDeleteRecord
        '
        Me.tlbtnDeleteRecord.DropDownMenu = Me.cmnuDelete
        Me.tlbtnDeleteRecord.ImageIndex = 14
        Me.tlbtnDeleteRecord.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
        Me.tlbtnDeleteRecord.Text = "Delete Entry"
        Me.tlbtnDeleteRecord.ToolTipText = "Delete Entry"
        Me.tlbtnDeleteRecord.Visible = False
        '
        'cmnuDelete
        '
        Me.cmnuDelete.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Delete Animal"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Delete Client"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Delete Member"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Delete Volunteer"
        '
        'tlbtnDivider4
        '
        Me.tlbtnDivider4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tlbtnHelp
        '
        Me.tlbtnHelp.ImageIndex = 12
        Me.tlbtnHelp.Text = "Help"
        Me.tlbtnHelp.ToolTipText = "Help"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth4Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Silver
        '
        'cmnuAdd
        '
        Me.cmnuAdd.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmnuAddAnimal, Me.cmnuAddClient, Me.cmnuAddMember, Me.cmnuAddVolunteer})
        '
        'cmnuAddAnimal
        '
        Me.cmnuAddAnimal.Index = 0
        Me.cmnuAddAnimal.Text = "Add Animal"
        '
        'cmnuAddClient
        '
        Me.cmnuAddClient.Index = 1
        Me.cmnuAddClient.Text = "Add Client"
        '
        'cmnuAddMember
        '
        Me.cmnuAddMember.Index = 2
        Me.cmnuAddMember.Text = "Add Member"
        '
        'cmnuAddVolunteer
        '
        Me.cmnuAddVolunteer.Index = 3
        Me.cmnuAddVolunteer.Text = "Add Volunteer"
        '
        'cmnuModify
        '
        Me.cmnuModify.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmnuModifyAnimal, Me.cmnuModifyClient, Me.cmnuModifyMember, Me.cmnuModifVolunteer})
        '
        'cmnuModifyAnimal
        '
        Me.cmnuModifyAnimal.Index = 0
        Me.cmnuModifyAnimal.Text = "Modify Animal"
        '
        'cmnuModifyClient
        '
        Me.cmnuModifyClient.Index = 1
        Me.cmnuModifyClient.Text = "Modify Client"
        '
        'cmnuModifyMember
        '
        Me.cmnuModifyMember.Index = 2
        Me.cmnuModifyMember.Text = "Modify Member"
        '
        'cmnuModifVolunteer
        '
        Me.cmnuModifVolunteer.Index = 3
        Me.cmnuModifVolunteer.Text = "Modify Volunteer"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(3, 54)
        Me.Splitter1.MinExtra = 300
        Me.Splitter1.MinSize = 300
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(5, 609)
        Me.Splitter1.TabIndex = 29
        Me.Splitter1.TabStop = False
        Me.Splitter1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.contentpanel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(3, 609)
        Me.Panel1.TabIndex = 28
        Me.Panel1.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(5, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dynamic Content Panel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'contentpanel
        '
        Me.contentpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.contentpanel.Location = New System.Drawing.Point(4, 24)
        Me.contentpanel.Name = "contentpanel"
        Me.contentpanel.Size = New System.Drawing.Size(196, 488)
        Me.contentpanel.TabIndex = 0
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth4Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Silver
        '
        'frmMainMDI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(958, 687)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolbarPanel1)
        Me.Controls.Add(Me.StatusBar1)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMainMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C.A.M.O. Database"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolbarPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub mnuViewToolbar1Text_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewToolbar.Click

        If Me.mnuViewToolbar.Checked = True Then
            Me.ToolbarPanel1.Visible = False
            Me.mnuViewToolbar.Checked = False
        Else
            Me.ToolbarPanel1.Visible = True
            Me.mnuViewToolbar.Checked = True
        End If
        frmMainMDI_Resize(Me, e)
    End Sub

    Private Sub ToolBar1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolBar1.SizeChanged
        Me.contentpanel.Width = (Me.Panel1.Width - 2 * Me.contentpanel.Left + Me.Splitter1.Width - 1)
        Me.ToolbarPanel1.Height = Me.ToolBar1.Height + Me.ToolBar1.Top + 2

    End Sub

    Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        Dim About As New frmAbout
        About.ShowDialog(Me)

    End Sub

    Private Sub Panel1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.contentpanel.Width = (Me.Panel1.Width - 2 * Me.contentpanel.Left + Me.Splitter1.Width)
        Me.contentpanel.Height = (Me.Panel1.Height - Me.contentpanel.Top)
        Me.ToolbarPanel1.Height = Me.ToolBar1.Height + Me.ToolBar1.Top
        Me.ToolBar1.Width = Me.ToolbarPanel1.Width - Me.ToolBar1.Left
        Me.Label1.Width = Me.Panel1.Width

    End Sub

    Private Sub mnuViewDynamicContent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewDynamicContent.Click
        If Me.Panel1.Visible = True Then
            Me.Panel1.Visible = False
            Me.Splitter1.Visible = False
            Me.mnuViewDynamicContent.Checked = False
        Else
            Me.Panel1.Visible = True
            Me.Splitter1.Visible = True
            Me.mnuViewDynamicContent.Checked = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub frmMainMDI_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize


        graphics = Me.ToolbarPanel1.CreateGraphics
        Dim lightPen As New System.Drawing.Pen(SystemColors.ControlLightLight, 1)
        Dim darkPen As New System.Drawing.Pen(SystemColors.ControlDark, 1)

        Dim bxLeft = Me.ToolBar1.Top
        Dim bxTop = Me.ToolBar1.Top
        Dim bxHeight = Me.ToolBar1.ButtonSize.Height - 1
        Dim bxWidth = 2
        ' Draw Box Right
        graphics.DrawLine(darkPen, bxLeft + bxWidth, bxTop, bxLeft + bxWidth, bxTop + bxHeight)
        ' Draw Box Left
        graphics.DrawLine(lightPen, bxLeft, bxTop, bxLeft, bxTop + bxHeight)
        ' Draw Box Top
        graphics.DrawLine(lightPen, bxLeft, bxTop, bxLeft + bxWidth, bxTop)
        ' Draw Box Bottom
        graphics.DrawLine(darkPen, bxLeft, bxTop + bxHeight, bxLeft + bxWidth, bxTop + bxHeight)

        graphics.DrawLine(lightPen, 0, Me.ToolbarPanel1.Height - 1, Me.ToolbarPanel1.Width - 1, Me.ToolbarPanel1.Height - 1)
        graphics.DrawLine(darkPen, 0, Me.ToolbarPanel1.Height - 2, Me.ToolbarPanel1.Width - 1, Me.ToolbarPanel1.Height - 2)

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSysAdmin.Click
        Dim userList As New frmUserList
        userList.ShowDialog(Me)

    End Sub

    Private Sub frmMainMDI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        Me.mnuFileOpen_Click(Me, e)
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileChangePass.Click
        Dim changePassword As New frmChangePassword
        changePassword.user = currentUser
        changePassword.ShowDialog(Me)

    End Sub

    Private Sub mnuFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click
        Dim loginScreen As New frmLogin
        currentUser = loginScreen.getUser(Me)
        If currentUser.EmployeeID <> "" Then
            MsgBox("User '" + currentUser.LoginName.ToUpper + "' Logged In!" _
                                                  , MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Login Complete")
            Me.mnuFileLogout.Enabled = True
            Me.mnuFileOpen.Enabled = False
            Me.mnuFileChangePass.Enabled = True
            Me.ToolBar1.Buttons(11).Enabled = True
            Me.ToolBar1.Buttons(12).Enabled = True
            If currentUser.canAddModifyUsers = True Then Me.mnuFileSysAdmin.Enabled = True Else Me.mnuFileSysAdmin.Enabled = False

        End If

    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFilePrintReports.Click
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.ShowDialog(Me)
    End Sub

    Private Sub mnuViewShowStatusBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewShowStatusBar.Click
        If Me.mnuViewShowStatusBar.Checked = True Then
            Me.StatusBar1.Visible = False
            Me.mnuViewShowStatusBar.Checked = False
        Else
            Me.StatusBar1.Visible = True
            Me.mnuViewShowStatusBar.Checked = True
        End If

        frmMainMDI_Resize(Me, e)

    End Sub

    Private Sub mnuHelpHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpHelp.Click
        ' path to default webbrowser in registry...
        Dim browserKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("htmlfile\shell\open\command", False)
        ' get the actual path from between the " "
        Dim defaultBrowser As String = DirectCast(browserKey.GetValue(Nothing, Nothing), String).Split(Chr(34))(1)
        ' open the default browser, with the specified path...
        Try
            Process.Start(defaultBrowser, Application.StartupPath + "/manual.html")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mnuFileLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileLogout.Click

        With Me
            .mnuFileSysAdmin.Enabled = False
            .mnuFileLogout.Enabled = False
            .mnuFileChangePass.Enabled = False
            .mnuFileOpen.Enabled = True
            .ToolBar1.Buttons(11).Enabled = False
            .ToolBar1.Buttons(12).Enabled = False
        End With

        MsgBox("User '" + currentUser.LoginName.ToUpper + "' Has Sucessfully Logged Out!", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Logout Complete")
        currentUser = New UserObject

        Me.mnuFileOpen_Click(Me, e)
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        End
    End Sub

    Private Sub frmMainMDI_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        frmMainMDI_Resize(Me, e)
    End Sub

    Private Sub ToolbarPanel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ToolbarPanel1.Paint
        frmMainMDI_Resize(Me, e)

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case e.Button.Text.Trim().ToUpper()
            Case "ANIMALS"
                Dim animalForm As New frmAnimal
                animalForm.MdiParent = Me
                animalForm.Show()
            Case "CLIENTS"
                Dim clientForm As New frmClient
                clientForm.MdiParent = Me
                clientForm.Show()
            Case "LOGIN"
                Dim loginScreen As New frmLogin
                currentUser = loginScreen.getUser(Me)
                If currentUser.EmployeeID <> "" Then
                    MsgBox("User '" + currentUser.LoginName.ToUpper + "' Logged In!" _
                                                          , MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Login Complete")
                    Me.mnuFileLogout.Enabled = True
                    Me.mnuFileOpen.Enabled = False
                    Me.mnuFileChangePass.Enabled = True
                    Me.ToolBar1.Buttons(11).Enabled = True
                    Me.ToolBar1.Buttons(12).Enabled = True
                    If currentUser.canAddModifyUsers = True Then Me.mnuFileSysAdmin.Enabled = True Else Me.mnuFileSysAdmin.Enabled = False
                End If
        End Select
    End Sub
End Class