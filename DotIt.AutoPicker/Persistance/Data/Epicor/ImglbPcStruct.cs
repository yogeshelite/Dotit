using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbPcStruct
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
        public string ConfLabel { get; set; }
        public string SubPartNum { get; set; }
        public string SubRevisionNum { get; set; }
        public int MtlSeq { get; set; }
        public string Comments { get; set; }
        public int OprSeq { get; set; }
        public string RuleTag { get; set; }
        public string AsmPartNum { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPartNum { get; set; }
        public string GlbRevisionNum { get; set; }
        public string TypeCode { get; set; }
        public int StructId { get; set; }
        public string RelatedTo { get; set; }
        public string RelatedToId { get; set; }
        public int DisplaySeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
