using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbPcRuleSet
    {
        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string AltMethod { get; set; }
        public int RuleSetId { get; set; }
        public Guid BomelementSysRowId { get; set; }
        public string BomelementTableName { get; set; }
        public string BomelementType { get; set; }
        public string RuleTag { get; set; }
        public int MtlSeq { get; set; }
        public int OprSeq { get; set; }
        public int OpDtlSeq { get; set; }
        public bool UseKeepWhen { get; set; }
        public string KeepWhenExpr { get; set; }
        public string KeepWhenLvalue { get; set; }
        public string KeepWhenCompareOpr { get; set; }
        public string KeepWhenRvalue { get; set; }
        public string KeepWhenRvalueType { get; set; }
        public string KeepWhenType { get; set; }
        public string ExtCompanyList { get; set; }
        public string Comments { get; set; }
        public string Expression { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPartNum { get; set; }
        public string GlbRevisionNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
