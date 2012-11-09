using System;
using System.IO;
using System.Net;
using System.Diagnostics;

public class AutoUpdate
{
    // <File Name>;<Version>   [' comments    ]
    // <File Name>[;<Version>] [' comments    ]  
    // <File Name>[;?]         [' comments    ]
    // <File Name>[;delete]    [' comments    ]
    // ...
    // Blank lines and comments are ignored
    // The first line should be the current program/version
    // from the second line to the end the second parameter is optional
    // if the second parameter is not specified the file is updated.
    // if the version is specified the update checks the version
    // if the second parameter is an interrogation mark (?) the update checks if the 
    // file alredy exists and "don't" upgrade if exists.
    // if the second parameter is "delete" the system try to delete the file
    // "'" (chr(39)) start a line comment (like vb)

    //' Function Return Value
    //' True means that the program needs to exit because: the autoupdate did the update
    //' or there was an error during the update
    //' False - nothing was done

    public static bool doUpdate(string uri) 
    {
        bool Ret = false;
        string AssemblyName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
        WebClient wc = new WebClient();
        try
        {            
            //get the update file contents
            string contents = wc.DownloadString(uri);
            //Process the update file
            string[] fileList = contents.Split('\n');
            Contents = "";
            //Remove all comments and blank lines
            for(int i = 0; i < FileList.Length; i++)
            {
                if (FileList[i].Contains("'"))
                    FileList[i] = FileList[i].Substring(0, FileList[i].IndexOf("'") - 1);
                if (FileList[i].Trim() != "")
                {
                    if (Contents != "") 
                        Contents += '\r';
                    Contents += FileList[i].Trim();
                }
                
            }
            //rebuild the file list
            FileList = Split(Contents, Chr(Keys.Return))
            Dim Info() As String = Split(FileList(0), ";")
            ' if the name is correct and it is a new version
            If Application.StartupPath.ToLower & "\" & Info(0).ToLower = Application.ExecutablePath.ToLower AndAlso _
               GetVersion(Info(1)) > GetVersion(Application.ProductVersion) Then
                ' process files in the list
                For Each F As String In FileList
                    Info = Split(F, ";")
                    bool isToDelete = false;
                    bool isToUpgrade = false;
                    Dim TempFileName As String = Application.StartupPath & "\" & Now.TimeOfDay.TotalMilliseconds
                    Dim FileName As String = Application.StartupPath & "\" & Info(0).Trim
                    Dim FileExists As Boolean = File.Exists(FileName)
                    If Info.Length = 1 Then
                        ' Just the file as parameter always upgrade
                        isToUpgrade = True
                        isToDelete = FileExists
                    ElseIf Info(1).Trim = "delete" Then
                        ' second parameter is "delete"
                        isToDelete = FileExists
                    ElseIf Info(1).Trim = "?" Then
                        ' second parameter is "?" (check if file exists and don't upgrade if exists)
                        isToUpgrade = Not FileExists
                    ElseIf FileExists Then
                        ' verify the file version
                        Dim fv As FileVersionInfo = FileVersionInfo.GetVersionInfo(FileName)
                        isToUpgrade = (GetVersion(Info(1).Trim) > GetVersion(fv.FileMajorPart & "." & fv.FileMinorPart & "." & fv.FileBuildPart & "." & fv.FilePrivatePart))
                        isToDelete = isToUpgrade
                    Else
                        ' the second parameter exists as version number and the file doesn't exists
                        isToUpgrade = True
                    End If
                    Debug.Print(TempFileName)
                    ' download the new file
                    If isToUpgrade Then MyWebClient.DownloadFile(RemoteUri & Info(0), TempFileName)
                    ' rename the existent file to be deleted in the future
                    If isToDelete Then File.Move(FileName, TempFileName & ToDeleteExtension)
                    ' rename the downloaded file to the real name
                    If isToUpgrade Then File.Move(TempFileName, FileName)
                    ' try to delete the file
                Next
                ' call the new version
                System.Diagnostics.Process.Start(Application.ExecutablePath, Microsoft.VisualBasic.Command())
                Ret = True
            End If
        Catch ex As Exception
            Ret = True
            MsgBox(m_ErrorMessage & vbCr & ex.Message & vbCr & "Assembly: " & AssemblyName, MsgBoxStyle.Critical, Application.ProductName)
        End Try
        Return Ret
    }}


    private static string getVersion(string version) 
    {
        string[] x = version.Split(".");
        return String.Format("{0:00000}{1:00000}{2:00000}{3:00000}",Convert.ToUInt16(x[0]), Convert.ToUInt16(x[1]), Convert.ToUInt16(x[2]), Convert.ToUInt16(x[3]));
    }

}