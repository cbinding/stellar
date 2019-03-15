<%@ Page Language="C#" AutoEventWireup="true" EnableViewState="true"  CodeFile="default.aspx.cs" Inherits="_Default" %>
<%@ Register TagPrefix="recaptcha" Namespace="Recaptcha" Assembly="Recaptcha" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">    
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the list of possible templates on first page load only
        if (!Page.IsPostBack)
        {
            String[] templates = STELLAR.Data.API.templateNames();  
            
            // add a temp extra one...currently names are coming from old Xslt versions
            // but we want a special one that uses STG...
            Array.Resize<String>(ref templates, templates.Length + 1);
            templates[templates.Length - 1] = "CRM_OBJECTS";   
             
            templateNames.DataSource = templates;
            templateNames.DataBind();
        }
    }
    
    void btnSubmit_Click(object sender, EventArgs e)   
    {
        String userDataPath = Request.PhysicalApplicationPath + "\\userdata\\";
        Page.Validate();
        CustomValidator1.IsValid = recaptcha.IsValid;
        if (Page.IsValid)  //recaptcha test was successful and upload file specified            
        {              
            try
            {
                //Upload the user data file to the server, generating (random) internal name for it
                //String csvFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                String fileName = System.IO.Path.GetFileNameWithoutExtension(System.IO.Path.GetRandomFileName());
                String csvFileName = fileName + ".csv";
                String rdfFileName = fileName + ".rdf";
                
                fileUpload.PostedFile.SaveAs(userDataPath + csvFileName);

                //Ensure valid namespace prefix             
                String namespaceURI = txtNamespace.Text.Trim();
                //If its empty use a default URI
                if (namespaceURI == String.Empty)
                    namespaceURI = "http://stellar/";
                //If it doesn't end with hash or slash, end with slash
                if (!namespaceURI.EndsWith("/") && !namespaceURI.EndsWith("#"))
                    namespaceURI += "/";

                //Do the conversion
                // 06/11/2013 CFB - use the user defined template if possible...(for M Charno workshop)
                if (templateNames.SelectedValue == "CRM_OBJECTS")
                {
                    STELLAR.Data.API.Delimited2STG(userDataPath + csvFileName, Request.PhysicalApplicationPath + "\\templates\\CRM_OBJECTS.stg", userDataPath + rdfFileName, ',');
                    STELLAR.Data.Rdf.merge(new string[] {userDataPath + rdfFileName}, userDataPath + rdfFileName);
                    String fileContents = System.IO.File.ReadAllText(userDataPath + rdfFileName);                      
                    fileContents = fileContents.Replace("http://StellarNamespacePrefix/", namespaceURI);
                    System.IO.File.WriteAllText(userDataPath + rdfFileName, fileContents);
                }
                else
                    STELLAR.Data.API.Delimited2RDF(userDataPath + csvFileName, templateNames.SelectedValue, userDataPath + rdfFileName, namespaceURI, true);
                                    
                //Display a link to download the converted data  
                lnkRdfData.NavigateUrl = "userdata/" + rdfFileName;
                lnkRdfData.Text = rdfFileName;
                lnkRdfData.Visible = true;
                lblExpiry.Visible = true;                               
                
                //Display stats on the converted data
                String[] stats = STELLAR.Data.Rdf.getStats(userDataPath + rdfFileName).Split('\n');
                lblMessage.Text = "";
                for (int i = 0; i < stats.Length; i++)
                {
                    lblMessage.Text += System.Web.HttpUtility.HtmlEncode(stats[i]) + "<br>";
                }
                lblMessage.Visible = true;               
                
            }
            catch (Exception ex) 
            {
                lblMessage.Text = ex.Message;
                lblMessage.Visible = true;
            } 
        }
        else //recaptcha test failed 
        {                  
            lnkRdfData.Visible = false;
            lblExpiry.Visible = false;
            //CustomValidator1.IsValid = false;
            lblMessage.Visible = false;                                 
        }
        try
        {
            //housekeeping: delete ANY previously generated userdata files more than 30 minutes old
            //(this could be implemented as a separate scheduled process, but keep it simple for now)
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(userDataPath);
            System.IO.FileInfo[] fi = di.GetFiles();
            foreach (System.IO.FileInfo file in fi)
            {
                if (DateTime.Now.Subtract(file.CreationTime).TotalMinutes > 30)
                    file.Delete();
            }
        }
        catch (Exception ex) 
        {
            //ignore errors here, its just a cleanup process
            System.Diagnostics.Debug.Write(ex.Message);            
        }      
    }
</script> 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>STELLAR.Web</title>
    <link rel="SHORTCUT ICON" href="http://reswin1.isd.glam.ac.uk/stellar/img/favicon.ico"/>	
    <style type="text/css">
        #Select1
        {
            height: 16px;
            width: 217px;
        }
        #fileUpload
        {
            width: 442px;
        }
        #templateNames
        {
            width: 180px;
        }
        #frmMain
        {
            width: 700px; 
            margin: 3px; 
            border: 1px solid #99CCFF; 
            width:700px; 
            padding: 10px; 
            background-color: #FFFFFF;           
        }
        #header
        {
        	margin-left:auto;
        	margin-right:auto;
        	text-align:center
        }
        #help
        {
        	margin: 3px; 
        	padding: 10px; 
        	border: 1px solid #99CCFF; 
        	width: 700px; 
        	color: #000000;
        }
    </style>
</head>
<body>
    <a id="top"></a>    
    <div>
    <form id="frmMain" runat="server" enctype="multipart/form-data">   
    <div id="header"><img src="img/cooltext470420858.png" alt="STELLAR.Web" /></div>
   
    <p>
    An application for converting delimited (CSV) format data to valid RDF data conforming to a chosen 'template'.
    </p>
    
    Delimited Data File <asp:HyperLink ID="HyperLink1" runat="server" 
        ImageUrl="~/img/help.png" NavigateUrl="#delimitedfile" ToolTip="What's this?"></asp:HyperLink>
    <br />
    <asp:FileUpload ID="fileUpload" runat="server" Width="100%" 
        BorderColor="#99CCFF" BorderStyle="Solid" BorderWidth="1px" />
    <asp:RequiredFieldValidator ID="requiredField1" runat="server" 
        ControlToValidate="fileUpload" ErrorMessage="Specify a file to be uploaded" />      
    <br />
    <br />   
     
    Template name
    <asp:HyperLink ID="HyperLink2" runat="server" ImageUrl="~/img/help.png" 
        NavigateUrl="#templatename" ToolTip="What's this?"></asp:HyperLink>
    <br />
    <asp:DropDownList ID="templateNames" runat="server" Height="22px" 
        Width="100%"/>
    <br />
    <br />   
    Namespace prefix
    <asp:HyperLink ID="HyperLink3" runat="server" ImageUrl="~/img/help.png" 
        NavigateUrl="#namespaceprefix" ToolTip="What's this?"></asp:HyperLink>
    <br />
    <asp:TextBox ID="txtNamespace" runat="server" Text="http://stellar/" 
        BorderColor="#99CCFF" BorderStyle="Solid" BorderWidth="1px" Width="100%" />
    <br />
    <br />
    Validator
    <asp:HyperLink ID="HyperLink4" runat="server" ImageUrl="~/img/help.png" 
        NavigateUrl="#validator" ToolTip="What's this?"></asp:HyperLink>
    <br />
            
    <recaptcha:RecaptchaControl     
        ID="recaptcha"    
        runat="server"     
        PublicKey="6Lc_n78SAAAAALZXC3bedlwIQ1ErTFkyFQ0HvNlh"     
        PrivateKey="6Lc_n78SAAAAADB1J0PaOPPEuSubM4DthU5QM4Ex" 
        BorderColor="#99CCFF" BorderStyle="Solid" Theme="white" />
        
    <asp:CustomValidator ID="CustomValidator1" runat="server" 
        ErrorMessage="Oops, please try again.."></asp:CustomValidator>        
    <br />
    <br />    
        
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
        OnClick="btnSubmit_Click" BorderColor="#99CCFF" BorderWidth="1px" Height="20px" 
        style="text-align: center" Width="74px" /> 
    <br />
    <h2>Results
        <asp:HyperLink ID="HyperLink5" runat="server" ImageUrl="~/img/help.png" 
            ToolTip="What's this?" NavigateUrl="#results"></asp:HyperLink>
    </h2>
    <asp:HyperLink ID="lnkRdfData" runat="server" Visible="false">(output file)</asp:HyperLink>
    <br />
    <asp:Label ID="lblExpiry" runat="server" Visible="False">(the download link 
    will remain available on the server for 30 minutes, after which it will be 
    automatically deleted)</asp:Label>
    <br />
    <asp:Label ID="lblMessage" runat="server" Visible="False">(message)</asp:Label>
    </form>
    </div>    
    
    <div id="help">
    <h2 style="color: #000000">Help</h2>
    <h3 style="color: #000000"><a id="delimitedfile">Delimited data file</a></h3>
    <p>The source data file to be uploaded, in comma delimited file format (CSV). The first row will contain 
        column names intended to be recognised by the chosen template. Source data files are deleted from the 
        server after processing. Your data will not be stored, used or disseminated.
            </p>
            <a href='#top'>[back to top]</a>
            <hr />
    <h3><a id="templatename">Template name</a></h3>
    <p>Choose a template to apply to the source data (see the documentation accompanying the 
    <a href="http://hypermedia.research.glam.ac.uk/resources/STELLAR-applications/">STELLAR.Console</a> application for further details)
    </p>
        <a href='#top'>[back to top]</a>
        <hr />
    <h3><a id="namespaceprefix">Namespace prefix</a></h3>
    <p>The namespace is a URI that will prefix all entity instance identifiers in the 
        resultant RDF file.</p>
        <a href='#top'>[back to top]</a>
        <hr />
    <h3><a id="validator">Validator</a></h3>
    <p>This validates that you are a human using the system and not a machine. It's not intended to limit your use of 
        STELLAR.Web, just to prevent possible abuse/misuse of the system by others. If you need to perform larger scale 
        or repetitive conversions of data you are welcome to download and use the <a href="http://hypermedia.research.glam.ac.uk/resources/STELLAR-applications/">STELLAR.Console</a> 
        application, which has the same (and additional) functionality.</p>
        <a href='#top'>[back to top]</a>
        <hr />
    <h3><a id="results">Results</a></h3>
    <p>The result of the STELLAR.Web conversion process is a link to a downloadable RDF 
        file. The download link will remain available for at least 30 minutes, after which time 
        the data file will be deleted from the server. Your data will not be stored, used or disseminated. Statistics
        for the downloadable RDF file are also displayed, these can help in assessing whether the data created matches 
        what was expected from the conversion process. </p>
        <a href='#top'>[back to top]</a>
</div>
    
    </body>
</html>
