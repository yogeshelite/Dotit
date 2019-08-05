using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpcStructRules
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string SubPartNum { get; set; }
        public string SubRevisionNum { get; set; }
        public int MtlSeq { get; set; }
        public int OprSeq { get; set; }
        public string RuleTag { get; set; }
        public int RuleSeq { get; set; }
        public string RuleString { get; set; }
        public string RuleType { get; set; }
        public string RuleExpr { get; set; }
        public string CalcName { get; set; }
        public string CalcDataType { get; set; }
        public int RuleId { get; set; }
        public string SourceDbrecid { get; set; }
        public string Comments { get; set; }
        public string AsmPartNum { get; set; }
        public int ProcessSeq { get; set; }
        public int StructId { get; set; }
        public string RelatedTo { get; set; }
        public string RelatedToId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
