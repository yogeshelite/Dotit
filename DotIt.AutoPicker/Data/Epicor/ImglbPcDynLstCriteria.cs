using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbPcDynLstCriteria
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string InputName { get; set; }
        public int ListSeq { get; set; }
        public int CriteriaSeq { get; set; }
        public string ColumnName { get; set; }
        public string Condition { get; set; }
        public string ColumnValue { get; set; }
        public string Operator { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPartNum { get; set; }
        public string GlbRevisionNum { get; set; }
        public string ValueFrom { get; set; }
        public string ConfigId { get; set; }
        public string LeftP { get; set; }
        public string RightP { get; set; }
        public bool UseEmptyValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
