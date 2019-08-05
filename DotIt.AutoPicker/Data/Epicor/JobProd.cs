using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class JobProd
    {
        public string Company { get; set; }
        public string JobNum { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public decimal ProdQty { get; set; }
        public string WarehouseCode { get; set; }
        public string TargetJobNum { get; set; }
        public int TargetAssemblySeq { get; set; }
        public int TargetMtlSeq { get; set; }
        public decimal ShippedQty { get; set; }
        public decimal ReceivedQty { get; set; }
        public decimal Wipqty { get; set; }
        public int CallNum { get; set; }
        public int CallLine { get; set; }
        public string TflineNum { get; set; }
        public string PartNum { get; set; }
        public string Plant { get; set; }
        public int DemandContractNum { get; set; }
        public int DemandHeadSeq { get; set; }
        public int DemandDtlSeq { get; set; }
        public int DemandScheduleSeq { get; set; }
        public string PlanUserId { get; set; }
        public string PlanId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool WiptoMiscShipment { get; set; }
        public int Rmanum { get; set; }
        public int Rmaline { get; set; }
        public int Rmareceipt { get; set; }
        public int Rmadisp { get; set; }
        public int Dmrnum { get; set; }
        public int DmractionNum { get; set; }
    }
}
