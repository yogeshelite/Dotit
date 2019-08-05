using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbPcRulesExpr
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int RuleSeq { get; set; }
        public int OprSeq { get; set; }
        public int MtlSeq { get; set; }
        public string ParPartNum { get; set; }
        public string AsmPartNum { get; set; }
        public string AltMethod { get; set; }
        public int OpDtlSeq { get; set; }
        public int SeqNum { get; set; }
        public string Expression { get; set; }
        public string TypeCode { get; set; }
        public string ConfigId { get; set; }
        public int ProcessOrder { get; set; }
        public int RuleSetId { get; set; }
        public string ExprType { get; set; }
        public string Lvalue { get; set; }
        public string CompareOpr { get; set; }
        public string Rvalue { get; set; }
        public string RvalueType { get; set; }
        public string ExprXmlitem { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPartNum { get; set; }
        public string GlbRevisionNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
