using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpcLookupTblValues
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string LookupTblId { get; set; }
        public int RowNum { get; set; }
        public string ColName { get; set; }
        public string ColSetId { get; set; }
        public string RowSetId { get; set; }
        public string DataValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal DataValueDecimal { get; set; }
        public bool DataValueBool { get; set; }
        public DateTime? DataValueDate { get; set; }
        public string DataValueString { get; set; }
    }
}
