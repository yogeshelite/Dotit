using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImtfordDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TfordNum { get; set; }
        public int TfordLine { get; set; }
        public bool OpenLine { get; set; }
        public string PartNum { get; set; }
        public decimal OurStockQty { get; set; }
        public string WarehouseCode { get; set; }
        public decimal OurStockShippedQty { get; set; }
        public string Plant { get; set; }
        public string ToPlant { get; set; }
        public bool OrderFirm { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? NeedByDate { get; set; }
        public bool Shipped { get; set; }
        public bool ManualOrder { get; set; }
        public string SupplyJobNum { get; set; }
        public string DemandJobNum { get; set; }
        public string ShipViaCode { get; set; }
        public string TflineNum { get; set; }
        public decimal ReceivedQty { get; set; }
        public decimal AdditionalQty { get; set; }
        public DateTime? FirmDate { get; set; }
        public string FirmUser { get; set; }
        public int DemandAsmSeq { get; set; }
        public int DemandMtlSeq { get; set; }
        public int SupplyAsmSeq { get; set; }
        public int SupplyMtlSeq { get; set; }
        public bool StockTrans { get; set; }
        public string OurStockQtyUom { get; set; }
        public string SellingQtyUom { get; set; }
        public decimal SellingQty { get; set; }
        public decimal SellingShippedQty { get; set; }
        public bool SelectForPicking { get; set; }
        public string StagingWarehouseCode { get; set; }
        public string StagingBinNum { get; set; }
        public string PickError { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ContractId { get; set; }
        public bool LinkToContract { get; set; }
        public string TransferContractId { get; set; }
        public bool TransferLinkToContract { get; set; }
        public bool EpicorFsa { get; set; }
    }
}
