using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class IntMap
    {
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
