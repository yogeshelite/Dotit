using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imzrelation
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string SystemCode { get; set; }
        public string DataSetId { get; set; }
        public string RelationId { get; set; }
        public string ParentSystemCode { get; set; }
        public string ParentDataTableId { get; set; }
        public string ChildSystemCode { get; set; }
        public string ChildDataTableId { get; set; }
        public string KeyId { get; set; }
        public string Description { get; set; }
        public bool SystemFlag { get; set; }
        public int Type { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
