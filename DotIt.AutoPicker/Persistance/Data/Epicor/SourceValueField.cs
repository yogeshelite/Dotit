using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SourceValueField
    {
        public int SourceValueFieldUid { get; set; }
        public int MapUid { get; set; }
        public int SequenceNumber { get; set; }
        public string FieldName { get; set; }
        public string DetailedDescription { get; set; }
        public string Dbtable { get; set; }
        public string Dbfield { get; set; }
        public bool Validate { get; set; }
        public string Company { get; set; }
        public bool GlobalSourceValueField { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
