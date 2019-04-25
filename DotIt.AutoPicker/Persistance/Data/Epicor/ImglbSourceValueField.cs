using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbSourceValueField
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Dbfield { get; set; }
        public string Dbtable { get; set; }
        public string DetailedDescription { get; set; }
        public string FieldName { get; set; }
        public int MapUid { get; set; }
        public int SequenceNumber { get; set; }
        public int SourceValueFieldUid { get; set; }
        public bool Validate { get; set; }
        public string GlbCompany { get; set; }
        public int GlbMapUid { get; set; }
        public int GlbSequenceNumber { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalSourceValueField { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
