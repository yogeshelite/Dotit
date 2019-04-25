using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PwlocHis
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public string PartNum { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public int MtlSeq { get; set; }
        public string WareHouseCode { get; set; }
        public string LotNum { get; set; }
        public string DimCode { get; set; }
        public string BinNum { get; set; }
        public string TrackType { get; set; }
        public string ResourceGrpId { get; set; }
        public string OpCode { get; set; }
        public string RevisionNum { get; set; }
        public string Um { get; set; }
        public bool FinalOp { get; set; }
        public string Dum { get; set; }
        public decimal DimConvFactor { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int CreatedTime { get; set; }
        public int DateTimeControl { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
