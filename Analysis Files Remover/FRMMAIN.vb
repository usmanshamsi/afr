
Public Class frmMain

    'Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    ContinueScanning = False
    '    ContinueDeleting = False
    'End Sub

    Private Sub bttnBrowse_Click(ByVal sender As System.Object,
                                 ByVal e As System.EventArgs) Handles bttnBrowse.Click

        'Read the value of current folder and set the browser dialogue to that folder
        'if any error occurs then set the folder to desktop folder
        Try
            FolderBrowserDialog1.SelectedPath = txtSearchFolder.Text

        Catch ex As Exception
            FolderBrowserDialog1.SelectedPath = Environment.SpecialFolder.Desktop.ToString

        End Try

        'DISPLAY DIALOG AND TAKE FOLDER INPUT
        Dim DialogReply As Windows.Forms.DialogResult = FolderBrowserDialog1.ShowDialog

        'if the user clicked ok button then change the folder location to selected folder
        'else do nothing
        If DialogReply = Windows.Forms.DialogResult.OK Then
            txtSearchFolder.Text = FolderBrowserDialog1.SelectedPath
        End If

    End Sub

    Private Sub bttnStartSearch_Click(ByVal sender As System.Object,
                                      ByVal e As System.EventArgs) Handles bttnStartSearch.Click

        'SET SCAN path variable to path currently displayed in folder text box
        ScanPath = txtSearchFolder.Text

        'SET SCAN OPTIONS i.e. the user selection to locate which software files are to be searched for
        searchEtab = chkEtabs.Checked
        searchSAP = chkSAP.Checked
        searchSAFE = chkSAFE.Checked
        searchBridge = chkBridge.Checked
        searchSTAAD = chkSTAAD.Checked

        'set the signal to continue scanning
        ContinueScanning = True

        'disable start search button and enable stop search button
        bttnStartSearch.Enabled = False
        bttnStopSearch.Enabled = True

        'clear the list view
        ListView1.Items.Clear()

        'initialize the summary variables
        totalLengthOfFiles = 0
        totalNumberOfFiles = 0

        'clear the text fields displaying summary
        lblDiskUsage.Text = ""
        lblFilesFound.Text = ""

        'disable the sorting of list view control
        ListView1.Sorting = SortOrder.None
        _SortOrder = 0
        Application.DoEvents()

        'Start Scanning of required software files
        If chkCSIFiles.Checked Then ScanForStructuresSoftware(ScanPath)
        If chkAutoCADFiles.Checked Then ScanForAutoCAD(ScanPath)

        'now the control will be passed to scanning routines defined in seperate files
        'and once the scanning is complete, the flow will return to this point again

        'AFTER SCAN IS COMPLETED

        'show that the software is ready for another scan if required
        txtStatus.Text = "Ready..."

        'set the signal to continue scanning to off
        ContinueScanning = False

        'enable start search button and disable stop button
        bttnStartSearch.Enabled = True
        bttnStopSearch.Enabled = False
        Application.DoEvents()

        'DISPLAY SUMMARY

        'Format the disk usage string
        Dim strDiskUsage As String
        If totalLengthOfFiles < 1024 Then
            strDiskUsage = totalLengthOfFiles & " Bytes"
        ElseIf totalLengthOfFiles < 1024 * 1024 Then
            strDiskUsage = Format(totalLengthOfFiles / 1024, "0.00") & " KB"
        ElseIf totalLengthOfFiles < 1024 * 1024 * 1024 Then
            strDiskUsage = Format(totalLengthOfFiles / 1024 / 1024, "0.00") & " MB"
        Else
            strDiskUsage = Format(totalLengthOfFiles / 1024 / 1024 / 1024, "0.00") & " GB"
        End If


        'display number of files
        lblFilesFound.Text = totalNumberOfFiles.ToString

        'display disk usage
        lblDiskUsage.Text = strDiskUsage

    End Sub

    Private Sub bttnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnDelete.Click

        'SET VARIABLES VALUES AND BUTTON STATES
        ContinueProcessing = True
        bttnDelete.Enabled = False
        bttnStop.Enabled = True
        Application.DoEvents()

        'START REMOVING FILES
        RemoveFiles()

        'AFTER REMOVAL, RETURN TO NORMAL STATE
        ContinueProcessing = False
        bttnDelete.Enabled = True
        bttnStop.Enabled = False
        lblDiskUsage.Text = ""
        lblFilesFound.Text = ""
        Application.DoEvents()
    End Sub

    Private Sub bttnStopSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnStopSearch.Click

        'USER WANTS TO STOP IMMEDIATELY, SET VARIABLE AND BUTTON STATE TO NORMAL MODE
        ContinueScanning = False

        Application.DoEvents()

    End Sub

    Private Sub bttnStopDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnStop.Click

        'SIGNAL THE REMOVE SUBROUTINE TO STOP IMMEDIATELY
        ContinueProcessing = False
        Application.DoEvents()

    End Sub

    Private Sub ListView1_ColumnClick(ByVal sender As Object, _
                        ByVal e As System.Windows.Forms.ColumnClickEventArgs) _
                        Handles ListView1.ColumnClick

        'SORT THE LIST ACCORDING TO USER REQUIREMENT

        If _SortOrder = 0 Or _SortOrder = 2 Then    'CURRENT IS NONE OR DESCENDING
            Select Case e.Column
                Case 0
                    'SORT AGAINST FILE NAME
                    ListView1.ListViewItemSorter = New ListFileNameSorter_A
                Case 1
                    'SORT AGAINST FILE EXTENSION
                    ListView1.ListViewItemSorter = New ListExtensionSorter_A
                Case 2
                    'SORT AGAINST FILE PATH
                    ListView1.ListViewItemSorter = New ListPathSorter_A
                Case 3
                    'SORT W.R.T. FILE SIZE
                    ListView1.ListViewItemSorter = New ListSizeSorter_A
            End Select
            ListView1.Sorting = SortOrder.Ascending
            _SortOrder = 1  'SET TO ASCENDING


        ElseIf _SortOrder = 1 Then  'CURRENT IS ASCENDING
            Select Case e.Column
                Case 0
                    'SORT AGAINST FILE NAME
                    ListView1.ListViewItemSorter = New ListFileNameSorter_D
                Case 1
                    'SORT AGAINST FILE EXTENSION
                    ListView1.ListViewItemSorter = New ListExtensionSorter_D
                Case 2
                    'SORT AGAINST FILE PATH
                    ListView1.ListViewItemSorter = New ListPathSorter_D
                Case 3
                    'SORT W.R.T. FILE SIZE
                    ListView1.ListViewItemSorter = New ListSizeSorter_D
            End Select
            ListView1.Sorting = SortOrder.Ascending
            _SortOrder = 2  'HAS BEEN SET TO DESCENDIND
        End If

    End Sub

    Private Sub chkCSIFiles_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCSIFiles.CheckedChanged
        GroupBox1.Enabled = chkCSIFiles.Checked
    End Sub

    Private Sub bttnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSelectAll.Click
        Dim item As ListViewItem
        For Each item In ListView1.Items
            item.Checked = True
        Next
    End Sub

    Private Sub bttnDeselectAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttnDeselectAll.Click
        Dim item As ListViewItem
        For Each item In ListView1.Items
            item.Checked = False
        Next
    End Sub

    Private Sub OpenContainingFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenContainingFolderToolStripMenuItem.Click

        If ListView1.SelectedItems.Count <= 0 Then Exit Sub

        Dim ProcStart As New ProcessStartInfo("explorer")
        Dim targetFile As String = ListView1.SelectedItems(0).SubItems(2).Text
        Dim targetFileInfo As New System.IO.FileInfo(targetFile)
        Dim targetDir As String = targetFileInfo.Directory.FullName

        ProcStart.Arguments = targetDir
        Process.Start(ProcStart)
    End Sub

    Private Sub OpenContainingFolderToolStripMenuItem_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles OpenContainingFolderToolStripMenuItem.Paint

        If ListView1.SelectedItems.Count <= 0 Then
            OpenContainingFolderToolStripMenuItem.Enabled = False
        Else
            OpenContainingFolderToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub bttnInvertSelection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnInvertSelection.Click
        Dim item As ListViewItem
        For Each item In ListView1.Items
            item.Checked = Not item.Checked
        Next
    End Sub

    Private Sub bttnExcludeSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnExcludeSelected.Click
        Dim item As ListViewItem
        For Each item In ListView1.Items
            If item.Checked Then
                ListView1.Items.Remove(item)
            End If
        Next
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim fa As Windows.Forms.Form
        fa = New frmAbout
        fa.ShowDialog()

    End Sub

    Private Sub DisclaimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisclaimerToolStripMenuItem.Click
        Dim fd As Windows.Forms.Form
        fd = New frm_disclaimer
        fd.ShowDialog()
    End Sub

    Private Sub bttn_removeArchiveAttrib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_removeArchiveAttrib.Click

        'SET VARIABLES VALUES AND BUTTON STATES
        ContinueProcessing = True
        bttn_removeArchiveAttrib.Enabled = False
        bttnStop.Enabled = True
        Application.DoEvents()

        'START REMOVING ARCHIVE ATTRIBUTE
        RemoveArchiveAttribute()

        'AFTER REMOVAL, RETURN TO NORMAL STATE
        ContinueProcessing = False
        bttn_removeArchiveAttrib.Enabled = True
        bttnStop.Enabled = False
        Application.DoEvents()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
