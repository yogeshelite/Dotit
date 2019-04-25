using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PcEccorderDtl
    {
        public string Company { get; set; }
        public string Eccbsvid { get; set; }
        public int CustNum { get; set; }
        public string PartNum { get; set; }
        public string BasePartNum { get; set; }
        public string BaseRevisionNum { get; set; }
        public string Plant { get; set; }
        public string LineDesc { get; set; }
        public string CurrencyCode { get; set; }
        public string BreakListCode { get; set; }
        public bool Commissionable { get; set; }
        public string DiscBreakListCode { get; set; }
        public decimal UnitPrice { get; set; }
        public bool LockPrice { get; set; }
        public bool LockQty { get; set; }
        public DateTime? NeedByDate { get; set; }
        public string OrderComment { get; set; }
        public bool OverrideDiscPriceList { get; set; }
        public bool OverridePriceList { get; set; }
        public string PickListComment { get; set; }
        public string Poline { get; set; }
        public string PricePerCode { get; set; }
        public string ProdCode { get; set; }
        public string ProjectId { get; set; }
        public string Reference { get; set; }
        public DateTime? RequestDate { get; set; }
        public bool Rework { get; set; }
        public int Rmaline { get; set; }
        public int Rmanum { get; set; }
        public string SalesCatId { get; set; }
        public string SalesUm { get; set; }
        public decimal SellingQuantity { get; set; }
        public string ShipComment { get; set; }
        public bool ShipLineComplete { get; set; }
        public string TaxCatId { get; set; }
        public bool Tmbilling { get; set; }
        public string XpartNum { get; set; }
        public string XrevisionNum { get; set; }
        public decimal DocUnitPrice { get; set; }
        public decimal ConfigBaseUnitPrice { get; set; }
        public decimal ConfigUnitPrice { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string EccquoteNum { get; set; }
        public string RevisionNum { get; set; }
        public string ShipToNum { get; set; }
        public int GroupSeq { get; set; }
        public DateTime? CreateDate { get; set; }
        public string AnalysisCode { get; set; }
        public int BestCsPct { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DocDiscount { get; set; }
        public bool Engineer { get; set; }
        public string JobComment { get; set; }
        public decimal KitQtyPer { get; set; }
        public string LeadTime { get; set; }
        public bool MultiRel { get; set; }
        public string PhaseId { get; set; }
        public string QuoteComment { get; set; }
        public DateTime? ReqShipDate { get; set; }
        public decimal SellingExpectedQty { get; set; }
        public string SellingExpectedUm { get; set; }
        public bool Template { get; set; }
        public int WorstCsPct { get; set; }
        public bool PclinkRemoved { get; set; }
        public decimal Msrp { get; set; }
        public decimal EndCustomerPrice { get; set; }
        public decimal PromotionalPrice { get; set; }
        public decimal DocPromotionalPrice { get; set; }
        public decimal DocEndCustomerPrice { get; set; }
        public decimal DocMsrp { get; set; }
    }
}
