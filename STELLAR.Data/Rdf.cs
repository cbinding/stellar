/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Data.Rdf
Summary	: Stats and merging for Rdf files
License : http://creativecommons.org/licenses/by/3.0/
================================================================================
History :

12/01/2011  CFB Created classes
================================================================================
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemWeb;
/*
* Get statistics about any RDF file (count statements/subjects/predicates/objects/literals/classes)
 * usage: Console.Write(RDFStats.getStats(fileName)); or Console.Write(RDFStats.getStats(URL));
*/
namespace STELLAR.Data
{
    public class Rdf
    {
        //Reads RDF/XML format, or N3/Turtle/Ntriples format (if filename end in ".n3"/".nt"/".ntriples")
        //doesn't cater for NQuads yet.. would have to write a reader for SemWeb.. maybe port NxParser??
        public static String getStats(String fileName)
        {
            //Tidy up input parameter(s)
            fileName = fileName.Trim();

            //Fail if fileName not passed in
            if (fileName == String.Empty)
                throw new ArgumentException("file name required", "fileName");
            
            RdfReader file;
            if (fileName.EndsWith(".n3", StringComparison.OrdinalIgnoreCase) ||
                fileName.EndsWith(".nt", StringComparison.OrdinalIgnoreCase) ||
                fileName.EndsWith(".ntriples", StringComparison.OrdinalIgnoreCase)) 
                file = new N3Reader(fileName);                 
            else
                file = new RdfXmlReader(fileName);
            return getStats(file);            
        }

        //Reads from RDF file located at URI, may be N3 or RDF/XML
        public static String getStats(System.Uri uri)
        {
            RdfReader file = RdfReader.LoadFromUri(uri);
            return getStats(file);
        }

        public static String getStats(RdfReader file)
        {
            StatementProcessor p = new StatementProcessor();
            file.Select(p);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------");
            sb.AppendLine("Statistics");
            sb.AppendLine("----------");
            sb.AppendFormat("{0} unique subject URIs\n", p.rdfSubjects.Count);
            sb.AppendFormat("{0} unique object URIs\n", p.rdfObjects.Count);
            sb.AppendFormat("{0} unique literals using {1} languages\n", p.rdfLiterals.Count, p.rdfLanguages.Count == 0 ? 1 : p.rdfLanguages.Count);
            sb.AppendFormat("{0} unique class URIs:\n", p.rdfClasses.Count);
            foreach (KeyValuePair<String, long> kvp in p.rdfClasses)
            {
                sb.AppendFormat("   {0} [{1}]\n", kvp.Key.ToString(), kvp.Value.ToString());
            }

            sb.AppendFormat("{0} statements, using {1} predicate URIs:\n", p.statementCount, p.rdfPredicates.Count);
            foreach (KeyValuePair<String, long> kvp in p.rdfPredicates)
            {
                sb.AppendFormat("   {0} [{1}]\n", kvp.Key.ToString(), kvp.Value.ToString());
            }
            return sb.ToString();
        }
        //used by getStats
        private class StatementProcessor : StatementSink {
            public long statementCount = 0;
            public System.Collections.Generic.Dictionary<String, long> rdfClasses = new System.Collections.Generic.Dictionary<String, long>();
            public System.Collections.Generic.Dictionary<String, long> rdfSubjects = new System.Collections.Generic.Dictionary<String, long>();
            public System.Collections.Generic.Dictionary<String, long> rdfPredicates = new System.Collections.Generic.Dictionary<String, long>();
            public System.Collections.Generic.Dictionary<String, long> rdfObjects = new System.Collections.Generic.Dictionary<String, long>();
            public System.Collections.Generic.Dictionary<String, long> rdfLiterals = new System.Collections.Generic.Dictionary<String, long>();
            public System.Collections.Generic.Dictionary<String, long> rdfLanguages = new System.Collections.Generic.Dictionary<String, long>();
            
            public bool Add(Statement assertion) 
            {
                String s = assertion.Subject.ToString();
                String p = assertion.Predicate.ToString();
                String o = assertion.Object.ToString();                
                
                if (!rdfSubjects.ContainsKey(s))
                    rdfSubjects.Add(s, 1);
                else
                    rdfSubjects[s] += 1;

                if (!rdfPredicates.ContainsKey(p))
                    rdfPredicates.Add(p, 1);
                else
                    rdfPredicates[p] += 1;

                if (assertion.Object is Literal)
                {
                    if (!rdfLiterals.ContainsKey(o))
                        rdfLiterals.Add(o, 1);
                    else
                        rdfLiterals[o] += 1;
                    String language = ((Literal)assertion.Object).Language == null ? "en":((Literal)assertion.Object).Language;
                    if (!rdfLanguages.ContainsKey(language))
                        rdfLanguages.Add(language, 1);
                    else
                        rdfLanguages[language] += 1;                    
                }
                else
                {
                    if (!rdfObjects.ContainsKey(o))
                        rdfObjects.Add(o, 1);
                    else
                        rdfObjects[o] += 1;
                }                

                if (p == "<http://www.w3.org/1999/02/22-rdf-syntax-ns#type>") //rdf:type
                {
                    if (!rdfClasses.ContainsKey(o))
                        rdfClasses.Add(o, 1);
                    else
                        rdfClasses[o] += 1;
                }
                
                statementCount++;
                return true;
            }
        }   
 
        //New 14/01/11 - RDF manipulation functions
        //Merge multiple RDF files to one, removing duplicate triples in the process
        //return overall number of triples in resultant file
        public static int merge(String[] rdfFileNames, String outFileName)
        {
            UniqueStatementProcessor usp = new UniqueStatementProcessor();
            NamespaceManager nm = new NamespaceManager();

            foreach (String fileName in rdfFileNames)
            {
                RdfReader input;                
                         
                if (fileName.EndsWith(".n3", StringComparison.OrdinalIgnoreCase) ||
                    fileName.EndsWith(".nt", StringComparison.OrdinalIgnoreCase) ||
                    fileName.EndsWith(".ntriples", StringComparison.OrdinalIgnoreCase))
                    input = new N3Reader(fileName);
                else
                    input = new RdfXmlReader(fileName);

                nm.AddFrom(input.Namespaces);
                input.ReuseEntities = true;                
                input.Select(usp);                 
            }

            RdfWriter output;
            if (outFileName.EndsWith(".n3", StringComparison.OrdinalIgnoreCase) ||
                outFileName.EndsWith(".nt", StringComparison.OrdinalIgnoreCase) ||
                outFileName.EndsWith(".ntriples", StringComparison.OrdinalIgnoreCase))
                output = new N3Writer(outFileName);
            else
                output = new RdfXmlWriter(outFileName);

            output.Namespaces.AddFrom(nm);
            output.BaseUri = "http://stellar/";            
            
            output.Write(usp.store);
            output.Close();
            return usp.store.StatementCount; 
        }

        //used by merge to ensure uniqueness of statements
        private class UniqueStatementProcessor : StatementSink
        {
            public SemWeb.MemoryStore store = new MemoryStore();
            //public SemWeb.Store store = Store.Create("sqlite:rdf:Uri=file:tmp1.sqlite;version=3");
            
            System.Collections.Generic.IEqualityComparer<Statement> comp = (System.Collections.Generic.IEqualityComparer<Statement>)new StatementComparer();
            
            public bool Add(Statement assertion)
            {
                //if (store.Contains(assertion))
                if(store.Contains<Statement>(assertion, comp))                
                    return false;
                  
                store.Add(assertion);
                return true;                               
            }            
        }

        //TODO: Split single RDF file to multiples based on unique Entity URI
        //(for static linked data purposes)
        private static String split(String rdfFileName)
        {
            //Tidy up input parameter(s)
            rdfFileName = rdfFileName.Trim();

            //Fail if fileName not passed in
            if (rdfFileName == String.Empty)
                throw new ArgumentException("file name required", "rdfFileName");

            return ""; //temp
        }

        /// <summary>IEqualityComparer to enable equality comparison of statements</summary>
        private class StatementComparer : IEqualityComparer<Statement>
        {
            public bool Equals(Statement x, Statement y)
            {
                //return (x.Object.Uri != null &&
                    //x.Subject.Uri == y.Subject.Uri && 
                    //x.Predicate.Uri == y.Predicate.Uri && 
                    //x.Object.Uri == y.Object.Uri);
                return (x.Matches(y));
            }
            public int GetHashCode(Statement obj) { return obj.GetHashCode(); }
        }
    }
}
