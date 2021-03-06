VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clsMRU"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
' The MRU list.
Private MRUName As Collection
Private MRUTitle As Collection

' Load the MRU list.
Public Sub Load()
Dim i As Integer
Dim file_title As String
Dim file_name As String

    ' Load the saved entries.
    Set MRUName = New Collection
    Set MRUTitle = New Collection
    For i = 1 To 4
        file_name = GetSetting(App.Title, _
            "MRUList", "Name" & Format$(i), "")
        If Len(file_name) > 0 Then
            file_title = GetSetting(App.Title, _
                "MRUList", "Title" & Format$(i), "")
            MRUTitle.Add file_title
            MRUName.Add file_name
        End If
    Next i
    ' Display the MRU items.
    Display
End Sub

' Display the MRU list.
Public Sub Display()
Dim i As Integer

    ' Load the used entries.
    For i = 1 To 4
        If i > MRUName.Count Then Exit For
        mnuMRU(i).Caption = "&" & _
            Format$(i) & " " & MRUTitle(i)
        mnuMRU(i).Visible = True
    Next i

    ' Hide unneeded entries.
    For i = MRUName.Count + 1 To 4
        mnuMRU(i).Visible = False
    Next i

    ' Show the separator if necessary.
    'mnuFileMRUSep.Visible = (MRUName.Count > 0)
End Sub

' Save the file name and title. Update the MRU list.
Public Sub Update(ByVal fname As String, _
    ByVal ftitle As String)
Dim i As Integer

    FileTitle = ftitle
    FileName = fname

    ' See if the file is already in the MRU list.
    For i = 1 To 4
        If i > MRUName.Count Then Exit For
        If LCase$(MRUName(i)) = LCase$(fname) Then
            ' It is here. Remove it.
            MRUName.Remove i
            MRUTitle.Remove i
            Exit For
        End If
    Next i

    ' Add the file at the top of the list.
    If MRUName.Count > 0 Then
        MRUName.Add fname, , 1
        MRUTitle.Add ftitle, , 1
    Else
        MRUName.Add fname
        MRUTitle.Add ftitle
    End If

    ' If there are more than 4 files in the
    ' collections, remove the last one.
    If MRUName.Count > 4 Then
        MRUName.Remove 5
        MRUTitle.Remove 5
    End If

    ' Save the modified MRU list.
    For i = 1 To 4
        If i > MRUName.Count Then
            fname = ""
            ftitle = ""
        Else
            fname = MRUName(i)
            ftitle = MRUTitle(i)
        End If
        SaveSetting App.Title, "MRUList", _
            "Name" & Format$(i), fname
        SaveSetting App.Title, "MRUList", _
            "Title" & Format$(i), ftitle
    Next i
    ' Redisplay the MRU items.
    Display
End Sub






