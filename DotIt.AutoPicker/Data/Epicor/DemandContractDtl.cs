using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class DemandContractDtl
    {
        public string Company { get; set; }
        public int DemandContractNum { get; set; }
        public int DemandContractLine { get; set; }
        public string PartNum { get; set; }
        public string XpartNum { get; set; }
        public bool TestRecord { get; set; }
        public decimal SellingTotalContractQty { get; set; }
        public decimal TotalContractQty { get; set; }
        public string LineDesc { get; set; }
        public string Ium { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal UnitPrice { get; set; }
        public string PricePerCode { get; set; }
        public string ProjectId { get; set; }
        public string PriceGroupCode { get; set; }
        public string SalesUm { get; set; }
        public decimal SellingFactor { get; set; }
        public string SellingFactorDirection { get; set; }
        public string DetailComments { get; set; }
        public bool UsePriceList { get; set; }
        public string Plant { get; set; }
        public decimal TotalInvoiceAmt { get; set; }
        public decimal TotalOrderAmt { get; set; }
        public decimal TotalOrderedQty { get; set; }
        public decimal TotalShippedQty { get; set; }
        public decimal TotalInvoicedQty { get; set; }
        public bool DeleteCurrentReleases { get; set; }
        public string MktgCampaignId { get; set; }
        public int MktgEvntSeq { get; set; }
        public decimal MinCallOffQty { get; set; }
        public string RevisionNum { get; set; }
        public string XrevisionNum { get; set; }
        public string DemandPricing { get; set; }
        public decimal DocUnitPrice { get; set; }
        public decimal Rpt1UnitPrice { get; set; }
        public decimal Rpt2UnitPrice { get; set; }
        public decimal Rpt3UnitPrice { get; set; }
        public bool OtsmartString { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal DocTotalInvoiceAmt { get; set; }
        public decimal Rpt1TotalInvoiceAmt { get; set; }
        public decimal Rpt2TotalInvoiceAmt { get; set; }
        public decimal Rpt3TotalInvoiceAmt { get; set; }
        public decimal DocTotalOrderAmt { get; set; }
        public decimal Rpt1TotalOrderAmt { get; set; }
        public decimal Rpt2TotalOrderAmt { get; set; }
        public decimal Rpt3TotalOrderAmt { get; set; }
        public decimal PriceTolerance { get; set; }
        public decimal DocPriceTolerance { get; set; }
        public decimal Rpt1PriceTolerance { get; set; }
        public decimal Rpt2PriceTolerance { get; set; }
        public decimal Rpt3PriceTolerance { get; set; }
    }
}
