Imports System.IO

Public Module Subroutines

    'Define signal variables for continue scanning and continue deleting
    Public ContinueScanning As Boolean = False  'CONTINUE SCANNING THE SEARCH FOLDER WHILE THE VALUE IS TRUE
    Public ContinueProcessing As Boolean = False  'CONTINUE DELETING THE SELECTED FILES WHILE THE VALUE IS TRUE

    Public ScanPath As String   'STORE THE PATH TO FOLDER TO BE SCANNED

    Public searchEtab, searchSAP, searchSAFE, searchBridge, searchSTAAD As Boolean 'SPECIFIES THE SOFTWARE FOR WHICH THE 
    '                                                   THE RUN FILES ARE TO SEARCHED 

    Public _SortOrder As Integer = 0    'STORES THE CURRENT SORT STATE OF THE LIST VIEW CONTROL
    '                                   VALUES ARE: 0 = NOT SORTED, 1 = SORTED IN ASCENDING ORDER,
    '                                               2 = SORTED IN DESCENDING ORDER

    Public totalLengthOfFiles As Long, totalNumberOfFiles As Long


    Sub RemoveFiles()

        'Build the list of files to be deleted
        Dim item As ListViewItem
        Dim i As Integer
        Dim filesToDelete(frmMain.ListView1.CheckedItems.Count - 1) As String
        Dim filesToDeleteIndex(frmMain.ListView1.CheckedItems.Count - 1) As Long
        Dim totalFilesToDelete As Long = filesToDelete.Length
        Dim filesActuallyDeleted As Long = 0

        frmMain.txtStatus.Text = "Building list of files to be deleted..."

        For i = 0 To frmMain.ListView1.CheckedItems.Count - 1

            Application.DoEvents()

            If ContinueProcessing = False Then
                frmMain.txtStatus.Text = "Ready..."
                frmMain.statusProgBar.Value = 0
                Exit Sub
            End If


            item = frmMain.ListView1.CheckedItems(i)

            filesToDelete(i) = item.SubItems(2).Text
            filesToDeleteIndex(i) = item.Index

            frmMain.statusProgBar.Value = CInt(i / totalFilesToDelete * 100)

        Next

        Dim _file As String
        For Each _file In filesToDelete

            Application.DoEvents()

            If ContinueProcessing = False Then
                frmMain.txtStatus.Text = "Ready..."
                frmMain.statusProgBar.Value = 0
                Exit For
            End If

            'Try
            frmMain.txtStatus.Text = "Deleting file: " & _file

            My.Computer.FileSystem.DeleteFile(_file, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)

            filesActuallyDeleted += 1

            frmMain.statusProgBar.Value = CInt(filesActuallyDeleted / totalFilesToDelete * 100)

            'Catch ex As Exception
            'MsgBox("An exception occured while deleting " & _file & vbCrLf & ex.Message)

            'End Try
        Next

        frmMain.txtStatus.Text = "Ready..."
        frmMain.statusProgBar.Value = 0

        For i = CInt(filesActuallyDeleted - 1) To 0 Step -1
            frmMain.ListView1.Items.RemoveAt(CInt(filesToDeleteIndex(i)))
        Next

        Application.DoEvents()


    End Sub

    Sub RemoveArchiveAttribute()

        'Build the list of files
        Dim item As ListViewItem
        Dim i As Integer
        Dim filesToProcess(frmMain.ListView1.CheckedItems.Count - 1) As String
        Dim filesToProcessIndex(frmMain.ListView1.CheckedItems.Count - 1) As Long
        Dim totalFilesToProcess As Long = filestoProcess.Length
        Dim filesActuallyProcessed As Long = 0

        frmMain.txtStatus.Text = "Building list of files..."
        ' -----------------------------------------------------
        For i = 0 To frmMain.ListView1.CheckedItems.Count - 1

            Application.DoEvents()

            If ContinueProcessing = False Then
                frmMain.txtStatus.Text = "Ready..."
                frmMain.statusProgBar.Value = 0
                Exit Sub
            End If


            item = frmMain.ListView1.CheckedItems(i)

            filestoProcess(i) = item.SubItems(2).Text
            filesToProcessIndex(i) = item.Index

            frmMain.statusProgBar.Value = CInt(i / totalFilesToProcess * 100)

        Next
        ' ----------------------------------------------

        '--------------- S T A R T ---------------------------------
        Dim _file As String
        For Each _file In filestoProcess

            Application.DoEvents()

            If ContinueProcessing = False Then
                frmMain.txtStatus.Text = "Ready..."
                frmMain.statusProgBar.Value = 0
                Exit For
            End If

            'Try
            frmMain.txtStatus.Text = "Remove Archive Attribute from file " & _file

            Dim attributes As FileAttributes
            attributes = File.GetAttributes(_file)

            attributes = RemoveAttribute(attributes, FileAttributes.Archive)
            File.SetAttributes(_file, attributes)

            'My.Computer.FileSystem.DeleteFile(_file, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)

            filesActuallyProcessed += 1

            frmMain.statusProgBar.Value = CInt(filesActuallyProcessed / totalFilesToProcess* 100)

            'Catch ex As Exception
            'MsgBox("An exception occured while deleting " & _file & vbCrLf & ex.Message)

            'End Try
        Next
        '----------------- E N D ---------------------------------------


        frmMain.txtStatus.Text = "Ready..."
        frmMain.statusProgBar.Value = 0

        Application.DoEvents()


    End Sub

    Public Function RemoveAttribute(ByVal attributes As FileAttributes, ByVal attributesToRemove As FileAttributes) As FileAttributes
        Return attributes And (Not attributesToRemove)
    End Function

    Public Sub ScanForStructuresSoftware(ByVal ScanPath As String)
        'THIS PROCEDURES HANDLES THE SEARCHING OF SPECIFIED SEARCH PATH

        Try

            'PROVIDE FEEDBACK THROUGH STATUS BAR
            frmMain.txtStatus.Text = "Scanning..." & Right(ScanPath, 60)

            'CHECK IF USER WANT TO CONTINUE OR NOT
            If ContinueScanning = False Then Exit Sub

            'CHECK WHETHER SCAN FOLDER EXIST OR NOT
            If Directory.Exists(ScanPath) = False Then
                Exit Sub
            End If

            'SET THE SEARCH PATTERN
            Dim searchPatterns() As String
            Dim i As Integer = 0
            If searchEtab Then
                ReDim Preserve searchPatterns(i + 1)
                searchPatterns(i) = "*.edb"
                searchPatterns(i + 1) = "*.$et"
                i += 2
            End If
            If searchSAP Then
                ReDim Preserve searchPatterns(i + 1)
                searchPatterns(i) = "*.sdb"
                searchPatterns(i + 1) = "*.$2k"
                i += 2
            End If
            If searchSAFE Then
                ReDim Preserve searchPatterns(i + 1)
                searchPatterns(i) = "*.fdb"
                searchPatterns(i + 1) = "*.$sf"
                i += 2
            End If
            If searchBridge Then
                ReDim Preserve searchPatterns(i + 1)
                searchPatterns(i) = "*.bdb"
                searchPatterns(i + 1) = "*.$br"
                i += 2
            End If
            If searchSTAAD Then
                ReDim Preserve searchPatterns(i + 1)
                searchPatterns(i) = "*.std"
                searchPatterns(i + 1) = "*.sbk"
                i += 2
            End If

            'EXIT IF ALL SOFTWARE ARE UNCHECKED
            If i = 0 Then Exit Sub

            Dim nModelFiles As Long = 0
            Dim searchModelFiles() As String
            Dim modelFile As String
            Dim ModelFiles() As String
            Dim FileInfo As FileInfo

            Dim RunFiles() As String
            Dim runFile As String
            Dim runFileInfo As FileInfo
            Dim runFileLength As Long

            'BUILD AN ARRAY CONTAINING FILE NAMES OF MODEL FILES IN THE CURRENT FOLDER
            Dim searchPattern As String = ""
            For Each searchPattern In searchPatterns
                searchModelFiles = Directory.GetFiles(ScanPath, searchPattern)
                If searchModelFiles.Length > 0 Then
                    If ModelFiles Is Nothing Then
                        ReDim Preserve ModelFiles(searchModelFiles.Length - 1)
                    Else
                        ReDim Preserve ModelFiles(ModelFiles.Length + searchModelFiles.Length - 1)
                    End If
                End If
                Dim _File As String
                For Each _File In searchModelFiles
                    FileInfo = New FileInfo(_File)
                    ModelFiles(CInt(nModelFiles)) = Left(FileInfo.Name, FileInfo.Name.Length - 4)
                    nModelFiles += 1
                Next
            Next

            'IF NO MODEL FILE IS FOUND THEN GO TO SUBFOLDERS DIRECTLY
            If nModelFiles = 0 Then GoTo ProcessSubFolders

            'REMOVE DUPLICATES FROM THE MODELFILES ARRAY
            Dim x, y As Integer
            For x = ModelFiles.Length - 1 To 0 Step -1
                For y = x - 1 To 0 Step -1
                    If ModelFiles(x).ToUpper = ModelFiles(y).ToUpper Then
                        Dim temp As String
                        temp = ModelFiles(ModelFiles.Length - 1)
                        ModelFiles(ModelFiles.Length - 1) = ModelFiles(x)
                        ModelFiles(x) = temp
                        ReDim Preserve ModelFiles(ModelFiles.Length - 2)
                        GoTo _Next_x
                    End If
                Next
_next_x:
            Next


            'FOR EACH FILE IN MODEL FILES, SEARCH ALL THE RUN FILES AND DISPLAY THEM

            For Each modelFile In ModelFiles

                RunFiles = Directory.GetFiles(ScanPath, modelFile & ".*")

                For Each runFile In RunFiles

                    If ContinueScanning = False Then Exit Sub
                    runFileInfo = New FileInfo(runFile)

                    Select Case runFileInfo.Extension.ToLower
                        Case ".edb", ".$et", ".sdb", ".$2k", ".fdb", ".$sf", ".bdb", "$br", ".std", ".sbk"
                            'DO NOTHING
                        Case Else

                            Dim LI As New ListViewItem

                            LI.Text = (runFileInfo.Name)
                            LI.SubItems.Add(runFileInfo.Extension)
                            LI.SubItems.Add(runFileInfo.FullName)

                            totalNumberOfFiles += 1
                            runFileLength = runFileInfo.Length

                            LI.SubItems.Add(Format(runFileLength / 1024, "0.00"))

                            totalLengthOfFiles += runFileLength

                            frmMain.ListView1.Items.Add(LI)
                            frmMain.ListView1.TopItem = LI
                            LI = Nothing

                            Application.DoEvents()
                    End Select

                Next
            Next

ProcessSubFolders:

            Dim subScanFolders() As String = Directory.GetDirectories(ScanPath)

            Dim subscanfolder As String
            For Each subscanfolder In subScanFolders
                Call ScanForStructuresSoftware(subscanfolder)
            Next

            Application.DoEvents()

        Catch ex As Exception
            MsgBox("An exception occured while scanning " & ScanPath & _
            vbCrLf & ex.Message)
        End Try
    End Sub

    Public Sub ScanForAutoCAD(ByVal ScanPath As String)
        'THIS PROCEDURES HANDLES THE SEARCHING OF SPECIFIED SEARCH PATH FOR AUTOCAD FILES

        Try

            'PROVIDE FEEDBACK THROUGH STATUS BAR
            frmMain.txtStatus.Text = "Scanning..." & Right(ScanPath, 60)

            'CHECK IF USER WANT TO CONTINUE OR NOT
            If ContinueScanning = False Then Exit Sub

            'CHECK WHETHER SCAN FOLDER EXIST OR NOT
            If Directory.Exists(ScanPath) = False Then
                Exit Sub
            End If

            'SET THE SEARCH PATTERN
            Dim searchPattern As String = "*.dwg"

            Dim nCADFiles As Long = 0
            'Dim searchCADFiles() As String
            Dim CADFile As String
            Dim CADFiles() As String
            Dim FileInfo As FileInfo

            Dim BackupFiles() As String
            Dim backupFile As String
            Dim backupFileInfo As FileInfo
            Dim backupFileLength As Long

            'BUILD AN ARRAY CONTAINING FILE NAMES OF CAD FILES IN THE CURRENT FOLDER

            CADFiles = Directory.GetFiles(ScanPath, searchPattern)

            'IF NO CAD FILE IS FOUND THEN GO TO SUBFOLDERS DIRECTLY 
            If CADFiles.Length = 0 Then GoTo ProcessSubFolders

            'EXTRACT NAME WITHOU FILE EXTENSIONS
            Dim counter As Integer
            For counter = 0 To CADFiles.Length - 1
                FileInfo = New FileInfo(CADFiles(counter))
                CADFiles(counter) = Left(FileInfo.Name, FileInfo.Name.Length - 4)
            Next


            'FOR EACH FILE IN CAD FILES, SEARCH ALL THE BAC FILES AND DISPLAY THEM

            For Each CADFile In CADFiles

                BackupFiles = Directory.GetFiles(ScanPath, CADFile & ".*")

                For Each backupFile In BackupFiles

                    If ContinueScanning = False Then Exit Sub
                    backupFileInfo = New FileInfo(backupFile)

                    Select Case backupFileInfo.Extension.ToLower
                        Case ".dwg"
                            'DO NOTHING
                        Case Else

                            Dim LI As New ListViewItem

                            LI.Text = (backupFileInfo.Name)
                            LI.SubItems.Add(backupFileInfo.Extension)
                            LI.SubItems.Add(backupFileInfo.FullName)

                            totalNumberOfFiles += 1
                            backupFileLength = backupFileInfo.Length

                            LI.SubItems.Add(Format(backupFileLength / 1024, "0.00"))
                            totalLengthOfFiles += backupFileLength

                            frmMain.ListView1.Items.Add(LI)
                            LI = Nothing

                            Application.DoEvents()
                    End Select

                Next
            Next

ProcessSubFolders:

            Dim subScanFolders() As String = Directory.GetDirectories(ScanPath)

            Dim subscanfolder As String
            For Each subscanfolder In subScanFolders
                Call ScanForAutoCAD(subscanfolder)
            Next

            Application.DoEvents()

        Catch ex As Exception
            MsgBox("An exception occured while scanning " & ScanPath & _
             vbCrLf & ex.Message)
        End Try
    End Sub
End Module