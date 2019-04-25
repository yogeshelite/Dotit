using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbTargetValueField
    {
        public string Coacode { get; set; }
        public string Company { get; set; }
        public string DetailedDescription { get; set; }
        public string FieldName { get; set; }
        public int MapUid { get; set; }
        public int SegmentNbr { get; set; }
        public int SequenceNumber { get; set; }
        public int TargetValueFieldUid { get; set; }
        public bool Validate { get; set; }
        public string ValueType { get; set; }
        public string GlbCompany { get; set; }
        public int GlbMapUid { get; set; }
        public int GlbSequenceNumber { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalTargetValueField { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
