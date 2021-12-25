
Public Class ListFileNameSorter_A
    Implements IComparer

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim item1, item2 As ListViewItem
        item1 = CType(x, ListViewItem)
        item2 = CType(y, ListViewItem)
        If item1.Text.ToUpper > item2.Text.ToUpper Then
            Return 1
        ElseIf item1.Text.ToUpper < item2.Text.ToUpper Then
            Return -1
        Else
            Return 0
        End If
    End Function
End Class

Public Class ListFileNameSorter_D
    Implements IComparer

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim item1, item2 As ListViewItem
        item1 = CType(x, ListViewItem)
        item2 = CType(y, ListViewItem)
        If item1.Text.ToUpper > item2.Text.ToUpper Then
            Return -1
        ElseIf item1.Text.ToUpper < item2.Text.ToUpper Then
            Return 1
        Else
            Return 0
        End If
    End Function
End Class



Public Class ListExtensionSorter_A
    Implements IComparer

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim item1, item2 As ListViewItem
        item1 = CType(x, ListViewItem)
        item2 = CType(y, ListViewItem)
        If item1.SubItems(1).Text.ToUpper > item2.SubItems(1).Text.ToUpper Then
            Return 1
        ElseIf item1.SubItems(1).Text.ToUpper < item2.SubItems(1).Text.ToUpper Then
            Return -1
        Else
            Return 0
        End If
    End Function
End Class

Public Class ListExtensionSorter_D
    Implements IComparer

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim item1, item2 As ListViewItem
        item1 = CType(x, ListViewItem)
        item2 = CType(y, ListViewItem)
        If item1.SubItems(1).Text.ToUpper > item2.SubItems(1).Text.ToUpper Then
            Return -1
        ElseIf item1.SubItems(1).Text.ToUpper < item2.SubItems(1).Text.ToUpper Then
            Return 1
        Else
            Return 0
        End If
    End Function
End Class



Public Class ListPathSorter_A
    Implements IComparer

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim item1, item2 As ListViewItem
        item1 = CType(x, ListViewItem)
        item2 = CType(y, ListViewItem)
        If item1.SubItems(2).Text.ToUpper > item2.SubItems(2).Text.ToUpper Then
            Return 1
        ElseIf item1.SubItems(2).Text.ToUpper < item2.SubItems(2).Text.ToUpper Then
            Return -1
        Else
            Return 0
        End If
    End Function
End Class

Public Class ListPathSorter_D
    Implements IComparer

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim item1, item2 As ListViewItem
        item1 = CType(x, ListViewItem)
        item2 = CType(y, ListViewItem)
        If item1.SubItems(2).Text.ToUpper > item2.SubItems(2).Text.ToUpper Then
            Return -1
        ElseIf item1.SubItems(2).Text.ToUpper < item2.SubItems(2).Text.ToUpper Then
            Return 1
        Else
            Return 0
        End If
    End Function
End Class



Public Class ListSizeSorter_A
    Implements IComparer

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim item1, item2 As ListViewItem
        item1 = CType(x, ListViewItem)
        item2 = CType(y, ListViewItem)
        If CType(item1.SubItems(3).Text, Double) > CType(item2.SubItems(3).Text, Double) Then
            Return 1
        ElseIf CType(item1.SubItems(3).Text, Double) < CType(item2.SubItems(3).Text, Double) Then
            Return -1
        Else
            Return 0
        End If
    End Function
End Class

Public Class ListSizeSorter_D
    Implements IComparer

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim item1, item2 As ListViewItem
        item1 = CType(x, ListViewItem)
        item2 = CType(y, ListViewItem)
        If CType(item1.SubItems(3).Text, Double) > CType(item2.SubItems(3).Text, Double) Then
            Return -1
        ElseIf CType(item1.SubItems(3).Text, Double) < CType(item2.SubItems(3).Text, Double) Then
            Return 1
        Else
            Return 0
        End If
    End Function
End Class