using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imdmrhead
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int Dmrnum { get; set; }
        public bool OpenDmr { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public int ConNum { get; set; }
        public string CommentText { get; set; }
        public decimal TotDiscrepantQty { get; set; }
        public decimal TotRejectedQty { get; set; }
        public decimal TotAcceptedQty { get; set; }
        public decimal AvgMtlUnitCost { get; set; }
        public decimal AvgLbrUnitCost { get; set; }
        public decimal AvgBurUnitCost { get; set; }
        public decimal AvgSubUnitCost { get; set; }
        public decimal AvgMtlBurUnitCost { get; set; }
        public string PartNum { get; set; }
        public string PartDescription { get; set; }
        public string DimCode { get; set; }
        public string LotNum { get; set; }
        public string Ium { get; set; }
        public bool CheckOff1 { get; set; }
        public bool CheckOff2 { get; set; }
        public bool CheckOff3 { get; set; }
        public bool CheckOff4 { get; set; }
        public bool CheckOff5 { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public int OprSeq { get; set; }
        public string ResourceId { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public string RevisionNum { get; set; }
        public decimal MaterialMtlCost { get; set; }
        public decimal MaterialLabCost { get; set; }
        public decimal MaterialSubCost { get; set; }
        public decimal MaterialBurCost { get; set; }
        public bool ReqDmr { get; set; }
        public string VendRmanum { get; set; }
        public string TranDocTypeId { get; set; }
        public string LegalNumber { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Plant { get; set; }
        public int Ponum { get; set; }
        public bool EpicorFsa { get; set; }
        public int Rmanum { get; set; }
        public int Rmaline { get; set; }
    }
}
