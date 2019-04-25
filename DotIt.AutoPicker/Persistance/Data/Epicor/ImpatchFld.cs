using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImpatchFld
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string ForeignKey { get; set; }
        public string FieldDataType { get; set; }
        public string DataCharacter { get; set; }
        public DateTime? DataDate { get; set; }
        public bool DataLogical { get; set; }
        public int DataInteger { get; set; }
        public decimal DataDecimal { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
