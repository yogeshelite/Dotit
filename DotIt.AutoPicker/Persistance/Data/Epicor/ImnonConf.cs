using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImnonConf
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal Quantity { get; set; }
        public string ReasonCode { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public decimal ScrapLaborCost { get; set; }
        public decimal ScrapBurdenCost { get; set; }
        public decimal ScrapMaterialCost { get; set; }
        public decimal ScrapMaterialBurCost { get; set; }
        public string TrnTyp { get; set; }
        public string DimCode { get; set; }
        public int OprSeq { get; set; }
        public string ResourceId { get; set; }
        public string Description { get; set; }
        public string EntryPerson { get; set; }
        public string EmpId { get; set; }
        public bool InspectionPending { get; set; }
        public string ScrapUm { get; set; }
        public string InspectedBy { get; set; }
        public string InspectorId { get; set; }
        public decimal DimConvFactor { get; set; }
        public int LaborHedSeq { get; set; }
        public int LaborDtlSeq { get; set; }
        public decimal PassedQty { get; set; }
        public decimal FailedQty { get; set; }
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public string PsdCommentText { get; set; }
        public string FldCommentText { get; set; }
        public string PurPoint { get; set; }
        public int VendorNum { get; set; }
        public string LotNum { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public decimal ScrapSubCost { get; set; }
        public string QtyFrm { get; set; }
        public int TranId { get; set; }
        public int Dmrnum { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int PorelNum { get; set; }
        public string Plant { get; set; }
        public int Rmanum { get; set; }
        public int Rmaline { get; set; }
        public int Rmareceipt { get; set; }
        public int Rmadisp { get; set; }
        public string CommentText { get; set; }
        public decimal MaterialMtlCost { get; set; }
        public decimal MaterialLabCost { get; set; }
        public decimal MaterialSubCost { get; set; }
        public decimal MaterialBurCost { get; set; }
        public string OpCode { get; set; }
        public string ToWarehouseCode { get; set; }
        public string ToBinNum { get; set; }
        public string Aqmncmnum { get; set; }
        public bool RequestMove { get; set; }
        public bool MoveCostsToDmr { get; set; }
        public string TranDocTypeId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Pcid { get; set; }
    }
}
