using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PcVerStructRulesExpr
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int ConfigVersion { get; set; }
        public string SubPartNum { get; set; }
        public string SubRevisionNum { get; set; }
        public int MtlSeq { get; set; }
        public int OprSeq { get; set; }
        public string RuleTag { get; set; }
        public int RuleSeq { get; set; }
        public string AsmPartNum { get; set; }
        public int SeqNum { get; set; }
        public string Expression { get; set; }
        public string TypeCode { get; set; }
        public string ConfigId { get; set; }
        public int StructId { get; set; }
        public string RelatedTo { get; set; }
        public string RelatedToId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
