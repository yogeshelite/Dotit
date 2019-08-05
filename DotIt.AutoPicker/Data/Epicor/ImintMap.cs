using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImintMap
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ExtSystemId { get; set; }
        public string TransferMethod { get; set; }
        public string VntgTable { get; set; }
        public string VntgField { get; set; }
        public string ToTableName { get; set; }
        public string ToFieldName { get; set; }
        public string ToFieldType { get; set; }
        public string ToFieldFormat { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
