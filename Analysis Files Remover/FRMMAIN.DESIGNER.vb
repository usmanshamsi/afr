<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchFolder = New System.Windows.Forms.TextBox()
        Me.bttnBrowse = New System.Windows.Forms.Button()
        Me.bttnStartSearch = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txtStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusProgBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenContainingFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.bttnDelete = New System.Windows.Forms.Button()
        Me.bttnStopSearch = New System.Windows.Forms.Button()
        Me.bttnStop = New System.Windows.Forms.Button()
        Me.chkSAP = New System.Windows.Forms.CheckBox()
        Me.chkSAFE = New System.Windows.Forms.CheckBox()
        Me.chkEtabs = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbResults = New System.Windows.Forms.GroupBox()
        Me.lblDiskUsage = New System.Windows.Forms.Label()
        Me.lblFilesFound = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bttnSelectAll = New System.Windows.Forms.Button()
        Me.bttnDeselectAll = New System.Windows.Forms.Button()
        Me.chkCSIFiles = New System.Windows.Forms.RadioButton()
        Me.chkAutoCADFiles = New System.Windows.Forms.RadioButton()
        Me.bttnInvertSelection = New System.Windows.Forms.Button()
        Me.bttnExcludeSelected = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisclaimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bttn_removeArchiveAttrib = New System.Windows.Forms.Button()
        Me.chkBridge = New System.Windows.Forms.CheckBox()
        Me.chkSTAAD = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbResults.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Location = New System.Drawing.Point(10, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search &Folder"
        '
        'txtSearchFolder
        '
        Me.txtSearchFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchFolder.Location = New System.Drawing.Point(92, 34)
        Me.txtSearchFolder.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSearchFolder.Name = "txtSearchFolder"
        Me.txtSearchFolder.Size = New System.Drawing.Size(567, 21)
        Me.txtSearchFolder.TabIndex = 1
        '
        'bttnBrowse
        '
        Me.bttnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnBrowse.Location = New System.Drawing.Point(663, 33)
        Me.bttnBrowse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bttnBrowse.Name = "bttnBrowse"
        Me.bttnBrowse.Size = New System.Drawing.Size(67, 22)
        Me.bttnBrowse.TabIndex = 2
        Me.bttnBrowse.Text = "Browse"
        Me.bttnBrowse.UseVisualStyleBackColor = True
        '
        'bttnStartSearch
        '
        Me.bttnStartSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnStartSearch.Location = New System.Drawing.Point(618, 59)
        Me.bttnStartSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bttnStartSearch.Name = "bttnStartSearch"
        Me.bttnStartSearch.Size = New System.Drawing.Size(112, 22)
        Me.bttnStartSearch.TabIndex = 4
        Me.bttnStartSearch.Text = "Start Search"
        Me.bttnStartSearch.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtStatus, Me.statusProgBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 570)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 11, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(740, 25)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.Stretch = False
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtStatus
        '
        Me.txtStatus.AutoSize = False
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStatus.Size = New System.Drawing.Size(566, 20)
        Me.txtStatus.Spring = True
        Me.txtStatus.Text = "Ready..."
        Me.txtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'statusProgBar
        '
        Me.statusProgBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.statusProgBar.Name = "statusProgBar"
        Me.statusProgBar.Size = New System.Drawing.Size(160, 19)
        Me.statusProgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 134)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(719, 345)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File Name"
        Me.ColumnHeader1.Width = 178
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Extension"
        Me.ColumnHeader2.Width = 74
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Full Address"
        Me.ColumnHeader3.Width = 306
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "File Size (KB)"
        Me.ColumnHeader4.Width = 95
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenContainingFolderToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(202, 26)
        '
        'OpenContainingFolderToolStripMenuItem
        '
        Me.OpenContainingFolderToolStripMenuItem.Name = "OpenContainingFolderToolStripMenuItem"
        Me.OpenContainingFolderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.OpenContainingFolderToolStripMenuItem.Text = "Open Containing Folder"
        '
        'bttnDelete
        '
        Me.bttnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnDelete.Location = New System.Drawing.Point(618, 490)
        Me.bttnDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bttnDelete.Name = "bttnDelete"
        Me.bttnDelete.Size = New System.Drawing.Size(112, 48)
        Me.bttnDelete.TabIndex = 8
        Me.bttnDelete.Text = "Delete Selected Files"
        Me.bttnDelete.UseVisualStyleBackColor = True
        '
        'bttnStopSearch
        '
        Me.bttnStopSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnStopSearch.Enabled = False
        Me.bttnStopSearch.Location = New System.Drawing.Point(618, 86)
        Me.bttnStopSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bttnStopSearch.Name = "bttnStopSearch"
        Me.bttnStopSearch.Size = New System.Drawing.Size(112, 22)
        Me.bttnStopSearch.TabIndex = 9
        Me.bttnStopSearch.Text = "Stop Search"
        Me.bttnStopSearch.UseVisualStyleBackColor = True
        '
        'bttnStop
        '
        Me.bttnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnStop.Enabled = False
        Me.bttnStop.Location = New System.Drawing.Point(618, 543)
        Me.bttnStop.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bttnStop.Name = "bttnStop"
        Me.bttnStop.Size = New System.Drawing.Size(112, 22)
        Me.bttnStop.TabIndex = 10
        Me.bttnStop.Text = "Stop"
        Me.bttnStop.UseVisualStyleBackColor = True
        '
        'chkSAP
        '
        Me.chkSAP.AutoSize = True
        Me.chkSAP.Checked = True
        Me.chkSAP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSAP.Location = New System.Drawing.Point(72, 10)
        Me.chkSAP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkSAP.Name = "chkSAP"
        Me.chkSAP.Size = New System.Drawing.Size(68, 17)
        Me.chkSAP.TabIndex = 14
        Me.chkSAP.Text = "SAP2000"
        Me.chkSAP.UseVisualStyleBackColor = True
        '
        'chkSAFE
        '
        Me.chkSAFE.AutoSize = True
        Me.chkSAFE.Checked = True
        Me.chkSAFE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSAFE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSAFE.Location = New System.Drawing.Point(146, 10)
        Me.chkSAFE.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkSAFE.Name = "chkSAFE"
        Me.chkSAFE.Size = New System.Drawing.Size(50, 17)
        Me.chkSAFE.TabIndex = 13
        Me.chkSAFE.Text = "SAFE"
        Me.chkSAFE.UseVisualStyleBackColor = True
        '
        'chkEtabs
        '
        Me.chkEtabs.AutoSize = True
        Me.chkEtabs.Checked = True
        Me.chkEtabs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEtabs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkEtabs.Location = New System.Drawing.Point(8, 10)
        Me.chkEtabs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkEtabs.Name = "chkEtabs"
        Me.chkEtabs.Size = New System.Drawing.Size(50, 17)
        Me.chkEtabs.TabIndex = 12
        Me.chkEtabs.Text = "Etabs"
        Me.chkEtabs.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkSTAAD)
        Me.GroupBox1.Controls.Add(Me.chkBridge)
        Me.GroupBox1.Controls.Add(Me.chkEtabs)
        Me.GroupBox1.Controls.Add(Me.chkSAFE)
        Me.GroupBox1.Controls.Add(Me.chkSAP)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 77)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(384, 30)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'gbResults
        '
        Me.gbResults.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbResults.Controls.Add(Me.lblDiskUsage)
        Me.gbResults.Controls.Add(Me.lblFilesFound)
        Me.gbResults.Controls.Add(Me.Label3)
        Me.gbResults.Controls.Add(Me.Label2)
        Me.gbResults.Location = New System.Drawing.Point(12, 517)
        Me.gbResults.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbResults.Name = "gbResults"
        Me.gbResults.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbResults.Size = New System.Drawing.Size(196, 51)
        Me.gbResults.TabIndex = 17
        Me.gbResults.TabStop = False
        Me.gbResults.Text = "Search Results"
        '
        'lblDiskUsage
        '
        Me.lblDiskUsage.AutoSize = True
        Me.lblDiskUsage.Location = New System.Drawing.Point(74, 34)
        Me.lblDiskUsage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDiskUsage.Name = "lblDiskUsage"
        Me.lblDiskUsage.Size = New System.Drawing.Size(0, 13)
        Me.lblDiskUsage.TabIndex = 3
        '
        'lblFilesFound
        '
        Me.lblFilesFound.AutoSize = True
        Me.lblFilesFound.Location = New System.Drawing.Point(103, 16)
        Me.lblFilesFound.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFilesFound.Name = "lblFilesFound"
        Me.lblFilesFound.Size = New System.Drawing.Size(0, 13)
        Me.lblFilesFound.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Disk Usage:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Files Found:"
        '
        'bttnSelectAll
        '
        Me.bttnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnSelectAll.Location = New System.Drawing.Point(367, 490)
        Me.bttnSelectAll.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bttnSelectAll.Name = "bttnSelectAll"
        Me.bttnSelectAll.Size = New System.Drawing.Size(112, 22)
        Me.bttnSelectAll.TabIndex = 18
        Me.bttnSelectAll.Text = "Select All"
        Me.bttnSelectAll.UseVisualStyleBackColor = True
        '
        'bttnDeselectAll
        '
        Me.bttnDeselectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnDeselectAll.Location = New System.Drawing.Point(367, 517)
        Me.bttnDeselectAll.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bttnDeselectAll.Name = "bttnDeselectAll"
        Me.bttnDeselectAll.Size = New System.Drawing.Size(112, 22)
        Me.bttnDeselectAll.TabIndex = 19
        Me.bttnDeselectAll.Text = "Deselect All"
        Me.bttnDeselectAll.UseVisualStyleBackColor = True
        '
        'chkCSIFiles
        '
        Me.chkCSIFiles.AutoSize = True
        Me.chkCSIFiles.Checked = True
        Me.chkCSIFiles.Location = New System.Drawing.Point(12, 64)
        Me.chkCSIFiles.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkCSIFiles.Name = "chkCSIFiles"
        Me.chkCSIFiles.Size = New System.Drawing.Size(216, 17)
        Me.chkCSIFiles.TabIndex = 20
        Me.chkCSIFiles.TabStop = True
        Me.chkCSIFiles.Text = "Search Run Files For Following Software"
        Me.chkCSIFiles.UseVisualStyleBackColor = True
        '
        'chkAutoCADFiles
        '
        Me.chkAutoCADFiles.AutoSize = True
        Me.chkAutoCADFiles.Location = New System.Drawing.Point(13, 112)
        Me.chkAutoCADFiles.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkAutoCADFiles.Name = "chkAutoCADFiles"
        Me.chkAutoCADFiles.Size = New System.Drawing.Size(188, 17)
        Me.chkAutoCADFiles.TabIndex = 21
        Me.chkAutoCADFiles.TabStop = True
        Me.chkAutoCADFiles.Text = "Search For AutoCAD Backup Files"
        Me.chkAutoCADFiles.UseVisualStyleBackColor = True
        '
        'bttnInvertSelection
        '
        Me.bttnInvertSelection.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnInvertSelection.Location = New System.Drawing.Point(367, 542)
        Me.bttnInvertSelection.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bttnInvertSelection.Name = "bttnInvertSelection"
        Me.bttnInvertSelection.Size = New System.Drawing.Size(112, 22)
        Me.bttnInvertSelection.TabIndex = 22
        Me.bttnInvertSelection.Text = "Invert Selection"
        Me.bttnInvertSelection.UseVisualStyleBackColor = True
        '
        'bttnExcludeSelected
        '
        Me.bttnExcludeSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnExcludeSelected.Location = New System.Drawing.Point(484, 543)
        Me.bttnExcludeSelected.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bttnExcludeSelected.Name = "bttnExcludeSelected"
        Me.bttnExcludeSelected.Size = New System.Drawing.Size(130, 22)
        Me.bttnExcludeSelected.TabIndex = 23
        Me.bttnExcludeSelected.Text = "Exclude Selected Files"
        Me.bttnExcludeSelected.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(740, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.DisclaimerToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'DisclaimerToolStripMenuItem
        '
        Me.DisclaimerToolStripMenuItem.Name = "DisclaimerToolStripMenuItem"
        Me.DisclaimerToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.DisclaimerToolStripMenuItem.Text = "&Disclaimer..."
        '
        'bttn_removeArchiveAttrib
        '
        Me.bttn_removeArchiveAttrib.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttn_removeArchiveAttrib.Location = New System.Drawing.Point(484, 490)
        Me.bttn_removeArchiveAttrib.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bttn_removeArchiveAttrib.Name = "bttn_removeArchiveAttrib"
        Me.bttn_removeArchiveAttrib.Size = New System.Drawing.Size(130, 48)
        Me.bttn_removeArchiveAttrib.TabIndex = 25
        Me.bttn_removeArchiveAttrib.Text = "Remove Archive Attribute from Selected Files"
        Me.bttn_removeArchiveAttrib.UseVisualStyleBackColor = True
        '
        'chkBridge
        '
        Me.chkBridge.AutoSize = True
        Me.chkBridge.Checked = True
        Me.chkBridge.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBridge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBridge.Location = New System.Drawing.Point(200, 10)
        Me.chkBridge.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBridge.Name = "chkBridge"
        Me.chkBridge.Size = New System.Drawing.Size(73, 17)
        Me.chkBridge.TabIndex = 15
        Me.chkBridge.Text = "CSI Bridge"
        Me.chkBridge.UseVisualStyleBackColor = True
        '
        'chkSTAAD
        '
        Me.chkSTAAD.AutoSize = True
        Me.chkSTAAD.Checked = True
        Me.chkSTAAD.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSTAAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSTAAD.Location = New System.Drawing.Point(276, 10)
        Me.chkSTAAD.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSTAAD.Name = "chkSTAAD"
        Me.chkSTAAD.Size = New System.Drawing.Size(78, 17)
        Me.chkSTAAD.TabIndex = 16
        Me.chkSTAAD.Text = "STAAD.Pro"
        Me.chkSTAAD.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(740, 595)
        Me.Controls.Add(Me.bttn_removeArchiveAttrib)
        Me.Controls.Add(Me.bttnExcludeSelected)
        Me.Controls.Add(Me.bttnInvertSelection)
        Me.Controls.Add(Me.chkAutoCADFiles)
        Me.Controls.Add(Me.bttnDeselectAll)
        Me.Controls.Add(Me.chkCSIFiles)
        Me.Controls.Add(Me.bttnSelectAll)
        Me.Controls.Add(Me.gbResults)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bttnStop)
        Me.Controls.Add(Me.bttnStopSearch)
        Me.Controls.Add(Me.bttnDelete)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.bttnStartSearch)
        Me.Controls.Add(Me.bttnBrowse)
        Me.Controls.Add(Me.txtSearchFolder)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(603, 328)
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analysis Files Remover"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbResults.ResumeLayout(False)
        Me.gbResults.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearchFolder As System.Windows.Forms.TextBox
    Friend WithEvents bttnBrowse As System.Windows.Forms.Button
    Friend WithEvents bttnStartSearch As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents txtStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents bttnDelete As System.Windows.Forms.Button
    Friend WithEvents bttnStopSearch As System.Windows.Forms.Button
    Friend WithEvents bttnStop As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkSAP As System.Windows.Forms.CheckBox
    Friend WithEvents chkSAFE As System.Windows.Forms.CheckBox
    Friend WithEvents chkEtabs As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbResults As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDiskUsage As System.Windows.Forms.Label
    Friend WithEvents lblFilesFound As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bttnSelectAll As System.Windows.Forms.Button
    Friend WithEvents bttnDeselectAll As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenContainingFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkCSIFiles As System.Windows.Forms.RadioButton
    Friend WithEvents chkAutoCADFiles As System.Windows.Forms.RadioButton
    Friend WithEvents bttnInvertSelection As System.Windows.Forms.Button
    Friend WithEvents bttnExcludeSelected As System.Windows.Forms.Button
    Friend WithEvents statusProgBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisclaimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bttn_removeArchiveAttrib As System.Windows.Forms.Button
    Friend WithEvents chkSTAAD As System.Windows.Forms.CheckBox
    Friend WithEvents chkBridge As System.Windows.Forms.CheckBox

End Class
