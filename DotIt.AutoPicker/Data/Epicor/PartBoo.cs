using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PartBoo
    {
        public string EndPartNum { get; set; }
        public string EndRevision { get; set; }
        public int BomSequence { get; set; }
        public int BomLevel { get; set; }
        public string MtlPartNum { get; set; }
        public string MtlRevision { get; set; }
        public string PartDescription { get; set; }
        public decimal QtyPer { get; set; }
        public decimal QtyRequired { get; set; }
        public string Bomtype { get; set; }
        public bool Approved { get; set; }
        public int OprSeq { get; set; }
        public string OpCode { get; set; }
        public decimal EstSetHours { get; set; }
        public decimal EstProdHours { get; set; }
        public string IndMtlPartNum { get; set; }
        public string ResourceGrpId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
