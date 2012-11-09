using System;
using System.Text;
using System.IO;
using System.Data;
using System.Runtime.Serialization;
using System.Collections;
using System.Xml;
using FileHelpers;

namespace STELLAR.APP
{
    [DataContract(Name = "Project", Namespace = "http://tempuri/stellar")]
    public class Project
    {
        //private variables
        private String _fileName = String.Empty;
        private String _label = String.Empty;
        private ArrayList _processes = new ArrayList();

        //Constructors
        public Project(){}
        public Project(String label) 
        {
            this.label = label;            
        }
        
        //Properties
        public String fileName {
            get { return _fileName; }
            set { _fileName = value.Trim(); }
        }

        [DataMember]
        public String label 
        {
            get { return _label; }
            set { _label = value.Trim(); }
        }

        //list of (XML) filenames, each contains a process
        [DataMember] 
        public String[] processes {
            get 
            { 
                return (String[])_processes.ToArray(typeof(String)); 
            } 
        }

        public void addProcess(String fileName)
        {
            if(!_processes.Contains(fileName))
                _processes.Add(fileName);
        }

        public void removeProcess(String fileName)
        {
            if (_processes.Contains(fileName))
                _processes.Remove(fileName);
        }

        public static Project loadFromFile(String fileName) 
        {            
            XmlTextReader reader = new XmlTextReader(fileName.Trim());
            DataContractSerializer ser = new DataContractSerializer(typeof(Project));
            // Deserialize the data and read it from the instance.
            Project project = (Project)ser.ReadObject(reader, true);
            reader.Close();
            project.fileName = fileName;
            return (project);
        }

        public static void saveToFile(Project project, String fileName) 
        {
            XmlTextWriter writer = new XmlTextWriter(fileName.Trim(), Encoding.UTF8); 
            DataContractSerializer ser = new DataContractSerializer(typeof(Project));
            ser.WriteObject(writer, project);
            writer.Close();
        }
    }

    public interface IDataSource
    {
        DataTable getData(int maxRows);
    }

    public interface IDataFile: IDataSource
    {
        String fileName { get; set; }
    }

    public abstract class DataFile: IDataFile
    {
        private String _fileName = "";

        public String fileName 
        { 
            get { return _fileName; } 
            set { _fileName = value.Trim(); } 
        }
        // override in derived classes. If maxRows == -1 return all data
        public abstract DataTable getData(int maxRows);        
    }
    
    public class DelimitedDataFile: DataFile
    {
        private String _delimiter = ",";
        private Boolean _hasHeaders = false;

        public String delimiter 
        {
            get { return _delimiter; }
            set { _delimiter = value; } 
        }
        public Boolean hasHeaders 
        {
            get { return _hasHeaders; }
            set { _hasHeaders = value; } 
        }
        public override DataTable getData(int maxRows)
        {            
            DelimitedFileEngine<DelimitedRow> engine = new FileHelpers.DelimitedFileEngine<DelimitedRow>();
            engine.Options.Delimiter = this.delimiter;
            engine.Options.IgnoreEmptyLines = true;
            //engine.Options.IgnoreCommentedLines = true; 
            DataTable dt = new DataTable();
            long recordCount = 0;
            DelimitedRow[] rows;

            if (!System.IO.File.Exists(this.fileName))
            {
                throw new Exception(string.Format("Problem finding file {0}?", this.fileName));
            }            
            try
            {
                rows = engine.ReadFile(this.fileName, maxRows);
            }
            catch (System.Exception ex)
            {
                throw new Exception(string.Format("Problem reading file {0}?", this.fileName), ex);
            }

            foreach (DelimitedRow row in rows)
            {
                //First row?
                if (recordCount == 0)
                {
                    if (this.hasHeaders)
                    {
                        // First row contains column names    
                        foreach (String s in row.fieldValues)
                        {
                            if (s != null && s.Trim().Length > 0 && !dt.Columns.Contains(s))
                                dt.Columns.Add(s, typeof(String));
                            else
                                dt.Columns.Add(GetNextColumnHeader(dt), typeof(String));
                        }
                    }
                    else
                    {
                        // First row just contains values                            
                        foreach (String s in row.fieldValues)
                        {
                            dt.Columns.Add(GetNextColumnHeader(dt), typeof(String));
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
        // used by DelimitedFile2DataTable
        private static String GetNextColumnHeader(DataTable table)
        {
            int c = 1;
            while (true)
            {
                String h = "Column" + c++;
                if (!table.Columns.Contains(h))
                    return h;
            }
        }
    }    

    public class FileProcess
    {
        private IDataSource _dataSource;        
        private String _processLabel = String.Empty;
        private String _outputFileName = String.Empty;
        private Modifiers.IModifier<String>[] fieldModifiers;
        //private IFieldMapping[] fieldMappings;
        private Boolean _enabled = true;
        private ProcessStatusEnum _status = ProcessStatusEnum.Stopped;
        private DateTime _lastRun = DateTime.MinValue;

        public String processLabel
        {
            get { return _processLabel; }
            set { _processLabel = value.Trim(); }
        }

        public String outputFileName
        {
            get { return _outputFileName; }
            set { _outputFileName = value.Trim(); } 
        }

        public Boolean enabled 
        {
            get { return _enabled; }
            set { _enabled = value; } 
        }

        public ProcessStatusEnum status {
            get { return _status; }
            set { _status = value; } 
        }

        public IDataSource dataSource
        {
            get { return _dataSource; }
            set { _dataSource = value; }
        }

        public DateTime lastRun { 
            get { return _lastRun; } 
        }

        public void run() 
        {
            //Do nothing if disabled
            if(!enabled)
                return;
            //Do nothing if no data source
            if (_dataSource == null)
                return;

            //Update process status
            _status = ProcessStatusEnum.Running;

            //Get the rows from the data source
            DataTable dt = _dataSource.getData(-1);
            foreach (DataRow row in dt.Rows)
            {
                //Apply modifiers
                //apply templates
            }

            //Open/create output file
            FileStream fs = File.Open(_outputFileName, FileMode.Create, FileAccess.Write);
            
            //Write output file

            //close output file
            fs.Close();

            //Update process status
            _status = ProcessStatusEnum.Completed;

            //Update lastRun date
            _lastRun = DateTime.Now;
        }
    }

    [DataContract(Name = "DataProcess", Namespace = "http://tempuri/stellar")]
    public class DataProcess 
    {
        //Private members
        private String _label = "";
        private String _schemaFileName = "";
        private String _templateFileName = "";
        private String _templateName = "";

        //Notification Events
        public delegate void SchemaChangedEventHandler(object sender, String newValue);
        public event SchemaChangedEventHandler SchemaChanged;
        
        [DataMember]
        public String label 
        {
            get { return _label; }
            set { _label = value; }             
        }

        [DataMember]
        public String schemaFileName
        {
            get 
            { 
                return _schemaFileName; 
            }
            set 
            {
                if (_schemaFileName != value.Trim())
                {
                    _schemaFileName = value.Trim();
                    //Fire event notifying change
                    if (this.SchemaChanged != null)
                        this.SchemaChanged(this, _schemaFileName);
                }                               
            } 
        }

        [DataMember]
        public String templateFileName 
        {
            get { return _templateFileName; }
            set { _templateFileName = value; } 
        }

        [DataMember]
        public String templateName
        {
            get { return _templateName; }
            set { _templateName = value; }
        }

        public static DataProcess loadFromFile(String fileName) 
        {
            XmlTextReader reader = new XmlTextReader(fileName);
            DataContractSerializer ser = new DataContractSerializer(typeof(DataProcess));
            // Deserialize the data and read it from the instance.
            DataProcess process = (DataProcess)ser.ReadObject(reader, true);           
            reader.Close();
            return (process);
        }
        public static void saveToFile(DataProcess process, String fileName) 
        {
            XmlTextWriter writer = new XmlTextWriter(fileName,Encoding.UTF8); // MemoryStream();
            DataContractSerializer ser = new DataContractSerializer(typeof(DataProcess));
            ser.WriteObject(writer, process);
            writer.Close();
        }

        public void run(String inputFileName, String outputFileName) 
        { 
            //todo...
        }
    }

    public enum ProcessStatusEnum
    {
        Running,
        Paused,
        Completed,
        Error,
        Disabled,
        Waiting,
        Stopped
    }



}
