using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.Data
{
    public class Csv
    {
        public static String getStats(String csvFileName)
        {
            return getStats(csvFileName, false);
        }
        public static String getStats(String csvFileName, bool hasHeader)
        {
            //Tidy up input parameter(s)
            csvFileName = csvFileName.Trim();

            //Fail if cscFileName not passed in
            if (csvFileName == String.Empty)
                throw new ArgumentException("CSV file name required", "csvFileName");

            //get data about the file
            System.IO.FileInfo f = new System.IO.FileInfo(csvFileName);
            System.Data.DataTable dt = API.Delimited2DT(csvFileName, hasHeader);
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------");
            sb.AppendLine("Statistics");
            sb.AppendLine("----------");
            sb.AppendFormat("File name: {0}\n", f.FullName);
            sb.AppendFormat("File size: {0} bytes\n", f.Length);
            sb.AppendFormat("Created: {0}\n", f.CreationTime.ToLongDateString());
            sb.AppendFormat("{0} lines\n", dt.Rows.Count);
            sb.AppendFormat("{0} columns:\n", dt.Columns.Count);
            foreach (System.Data.DataColumn dc in dt.Columns)
            {
                sb.AppendLine(dc.ColumnName);
            }
            return sb.ToString();            
        }
    }
}
