using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stellar.Win
{
    public class MRU
    {
        // The MRU list.
        IList<String> mruItems = new List<String>();
    
        // Load the MRU list.
        public IList<String> Load()
        {
            
            // Load the saved entries.
            List<String> mruItems = new List<String>();
            for(int i=1; i<=10; i++)
            {
                String fileName = Settings.Default["MRU" + i].Trim();
                if(fileName.Length > 0)
                    mruItems.Add(fileName);
            }
            //saving MRU items...
            //Settings.Default["MRU" + i] = "Some Value"; 
            //Settings.Default.Save(); // Saves settings in application configuration file 
            return mruItems;

        }
        
        // Display the MRU items.
        //Display();
    

    // Display the MRU list.
    public void Display()
    {
        Dim i As Integer

        // Load the used entries.
        For i = 1 To 4
            If i > MRUName.Count Then Exit For
            mnuMRU(i).Caption = "&" & _
                Format$(i) & " " & MRUTitle(i)
            mnuMRU(i).Visible = True
        Next i

        // Hide unneeded entries.
        For i = MRUName.Count + 1 To 4
            mnuMRU(i).Visible = False
        Next i

        // Show the separator if necessary.
        //mnuFileMRUSep.Visible = (MRUName.Count > 0)
    }

    // Save the file name and title. Update the MRU list.
    public void Update(ByVal fname As String, Byal ftitle As String)
    {
        Dim i As Integer

        FileTitle = ftitle
        FileName = fname

        // See if the file is already in the MRU list.
        For i = 1 To 4
            If i > MRUName.Count Then Exit For
            If LCase$(MRUName(i)) = LCase$(fname) Then
                // It is here. Remove it.
                MRUName.Remove(i)
                MRUTitle.Remove(i)
                Exit For
            End If
        Next i

        // Add the file at the top of the list.
        If MRUName.Count > 0 Then
            MRUName.Add(fname, , 1)
            MRUTitle.Add(ftitle, , 1)
        Else
            MRUName.Add(fname)
            MRUTitle.Add(ftitle)
        End If

        // If there are more than 4 files in the
        // collections, remove the last one.
        If MRUName.Count > 4 Then
            MRUName.Remove(5)
            MRUTitle.Remove(5)
        End If

        // Save the modified MRU list.
        For i = 1 To 4
            If i > MRUName.Count Then
                fname = ""
                ftitle = ""
            Else
                fname = MRUName(i)
                ftitle = MRUTitle(i)
            End If
            SaveSetting(App.Title, "MRUList", _
                "Name" & Format$(i), fname)
            SaveSetting(App.Title, "MRUList", _
                "Title" & Format$(i), ftitle)
        Next i
        // Redisplay the MRU items.
        Display()
        }
    }
}
