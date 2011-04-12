using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileHelpers;

namespace STELLAR
{
    // FileHelpers class to import delimited data as an array of strings
    // used for situation where we don't know the field names in advance
    [DelimitedRecord(",")]
    class DelimitedRow
    {
        [FieldNullValue(typeof(string), "")]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string[] fieldValues = {}; 
    }
}
