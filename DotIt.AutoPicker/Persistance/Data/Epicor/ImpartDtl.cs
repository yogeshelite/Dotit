using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImpartDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Type { get; set; }
        public string PartNum { get; set; }
        public DateTime? DueDate { get; set; }
        public bool RequirementFlag { get; set; }
        public decimal Quantity { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int JobSeq { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int PorelNum { get; set; }
        public string PartDescription { get; set; }
        public string Ium { get; set; }
        public string SourceFile { get; set; }
        public int CustNum { get; set; }
        public bool StockTrans { get; set; }
        public bool FirmRelease { get; set; }
        public string RevisionNum { get; set; }
        public int TargetOrderNum { get; set; }
        public int TargetOrderLine { get; set; }
        public int TargetOrderRelNum { get; set; }
        public string TargetWarehouseCode { get; set; }
        public string TargetJobNum { get; set; }
        public int TargetAssemblySeq { get; set; }
        public int TargetMtlSeq { get; set; }
        public string Plant { get; set; }
        public int InvLinkNum { get; set; }
        public int PlantTranNum { get; set; }
        public int TfordLine { get; set; }
        public string TfordNum { get; set; }
        public string TflineNum { get; set; }
        public string SourceDbrecid { get; set; }
        public bool NonPart { get; set; }
        public bool Bomchanged { get; set; }
        public decimal BaseQty { get; set; }
        public string BaseQtyUom { get; set; }
        public decimal InvtyQty { get; set; }
        public string InvtyQtyUom { get; set; }
        public bool JobFirm { get; set; }
        public int PartDtlSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ContractId { get; set; }
        public bool EpicorFsa { get; set; }
    }
}
