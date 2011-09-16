/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: STELLAR
Classes	: STELLAR.Data.DelimitedRow
Summary	: FileHelpers class to import delimited data as an array of strings
          used for situation where we don't know the field names in advance
License : http://creativecommons.org/licenses/by/3.0/
================================================================================
History :

12/01/2011  CFB Created classes
================================================================================
*/
using System;
using FileHelpers;

namespace STELLAR.Data
{
    [DelimitedRecord(",")]
    class DelimitedRow
    {
        [FieldNullValue(typeof(string), "")]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string[] fieldValues = {}; 
    }
}
