using System;
using System.Collections;
using System.Data;
using System.Text;
using System.IO;
using FileHelpers;

namespace STELLAR.APP
{
    //parser code from http://knab.ws/blog/index.php?/archives/10-CSV-file-parser-and-writer-in-C-Part-2.html
    public class CsvParser
    {
        public static DataTable Parse(string data, bool headers)
        {
            return Parse(new StringReader(data), headers);
        }
        public static DataTable Parse(string data)
        {
            return Parse(new StringReader(data));
        }
        public static DataTable Parse(TextReader stream)
        {
            return Parse(stream, false);
        }
        public static DataTable Parse(TextReader stream, bool headers)
        {
            long maxRows = -1;
            return Parse(stream, headers,',', maxRows);
        }
        public static DataTable Parse(TextReader stream, bool headers, char delimiter)
        {
            long maxRows = -1;
            return Parse(stream, headers, delimiter, maxRows);
        }
        public static DataTable Parse(TextReader stream, bool headers, char delimiter, long maxRows)
        {
            DataTable table = new DataTable();
            DelimitedStream csv = new DelimitedStream(stream, delimiter);
            string[] row = csv.GetNextRow();
            if (row == null)
                return null;
            if (headers)
            {
                foreach (string header in row)
                {
                    if (header != null && header.Length > 0 && !table.Columns.Contains(header))
                        table.Columns.Add(header, typeof(string));
                    else
                        table.Columns.Add(GetNextColumnHeader(table), typeof(string));
                }
                row = csv.GetNextRow();
            }
            long rowCount = 0;
            while (row != null && (maxRows == -1 || rowCount < maxRows))
            {
                while (row.Length > table.Columns.Count)
                    table.Columns.Add(GetNextColumnHeader(table), typeof(string));
                table.Rows.Add(row);
                row = csv.GetNextRow();
                rowCount++;
            }
            return table;
        }

        //CFB 21/07/2010 alternative parse using FileHelpers component for greater flexibility later..
        public static DataTable ParseUsingFileHelpers(String fileName, bool headers, String delimiter, int maxRows)
        {
            DelimitedFileEngine<DelimitedRow> engine = new FileHelpers.DelimitedFileEngine<DelimitedRow>();
            engine.Options.Delimiter = delimiter;
            engine.Options.IgnoreEmptyLines = true;            
            //engine.Options.IgnoreCommentedLines = true;
            DelimitedRow[] rows = engine.ReadFile(fileName, maxRows); 
             
            DataTable dt = new DataTable();
            fileName = fileName.Trim();
            //FileHelperAsyncEngine inputFile = new FileHelperAsyncEngine(typeof(DelimitedRow));
            //Alt syntax using generics..
            //FileHelperAsyncEngine<DelimitedRow> engine = new FileHelperAsyncEngine<DelimitedRow>();
            
            long recordCount = 0;

            if (!System.IO.File.Exists(fileName))
            {
                throw new Exception(string.Format("Problem finding file {0}?", fileName));
            }
            try
            {
                //engine.BeginReadFile(fileName);
            }
            catch (System.Exception ex)
            {
                throw new Exception(string.Format("Problem reading file {0}?", fileName), ex);
            }            

            foreach (DelimitedRow row in rows)
            {
                //First row?
                if (recordCount == 0)
                {
                    if(headers)
                    {
                        // First row contains column names    
                        foreach (String s in row.fieldValues) 
                        {                       
                            if (s != null && s.Trim().Length > 0 && !dt.Columns.Contains(s))
                                dt.Columns.Add(s, typeof(string));
                            else
                                dt.Columns.Add(GetNextColumnHeader(dt), typeof(string));
                        }
                    }
                    else
                    {
                        // First row just contains values                            
                        foreach (String s in row.fieldValues) 
                        {
                            dt.Columns.Add(GetNextColumnHeader(dt), typeof(string));
                        }
                        dt.Rows.Add(row.fieldValues);
                    }                    
                }
                else //not first row
                {
                    dt.Rows.Add(row.fieldValues);
                }
                recordCount++;
                if (recordCount >= maxRows)
                    break;

            }            
            return dt;
        }
        private static string GetNextColumnHeader(DataTable table)
        {
            int c = 1;
            while (true)
            {
                string h = "Column" + c++;
                if (!table.Columns.Contains(h))
                    return h;
            }
        }
        private class DelimitedStream
        {
            private TextReader stream;
            private char _delimiter = ',';

            public DelimitedStream(TextReader s, char delimiter)
            {
                stream = s;
                _delimiter = delimiter;
            }
            public string[] GetNextRow()
            {
                ArrayList row = new ArrayList();
                while (true)
                {
                    string item = GetNextItem();
                    if (item == null)
                        return row.Count == 0 ? null : (string[])row.ToArray(typeof(string));
                    row.Add(item);
                }
            }
            private bool EOS = false;
            private bool EOL = false;
            
            private string GetNextItem()
            {
                if (EOL)
                {
                    // previous item was last in line, start new line
                    EOL = false;
                    return null;
                }
                bool quoted = false;
                bool predata = true;
                bool postdata = false;
                StringBuilder item = new StringBuilder();
                
                while (true)
                {
                    char c = GetNextChar(true);
                    if (EOS)
                        return item.Length > 0 ? item.ToString() : null;
                    if ((postdata || !quoted) && c == _delimiter)
                        // end of item, return
                        return item.ToString();
                    if ((predata || postdata || !quoted) && (c == '\x0A' || c == '\x0D'))
                    {
                        // we are at the end of the line, eat newline characters and exit
                        EOL = true;
                        if (c == '\x0D' && GetNextChar(false) == '\x0A')
                            // new line sequence is 0D0A
                            GetNextChar(true);
                        return item.ToString();
                    }
                    if (predata && c == ' ')
                        // whitespace preceeding data, discard
                        continue;
                    if (predata && c == '"')
                    {
                        // quoted data is starting
                        quoted = true;
                        predata = false;
                        continue;
                    }
                    if (predata)
                    {
                        // data is starting without quotes
                        predata = false;
                        item.Append(c);
                        continue;
                    }
                    if (c == '"' && quoted)
                    {
                        if (GetNextChar(false) == '"')
                            // double quotes within quoted string means add a quote
                            item.Append(GetNextChar(true));
                        else
                            // end-quote reached
                            postdata = true;
                        continue;
                    }
                    // all cases covered, character must be data
                    item.Append(c);
                }
            }
            private char[] buffer = new char[4096];
            private int pos = 0;
            private int length = 0;
            
            private char GetNextChar(bool eat)
            {
                if (pos >= length)
                {
                    length = stream.ReadBlock(buffer, 0, buffer.Length);
                    if (length == 0)
                    {
                        EOS = true;
                        return '\0';
                    }
                    pos = 0;
                }
                if (eat)
                    return buffer[pos++];
                else
                    return buffer[pos];
            }
        }
    }
}
