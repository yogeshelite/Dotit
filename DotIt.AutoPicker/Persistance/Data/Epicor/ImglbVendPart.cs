using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbVendPart
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string OpCode { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int VendorNum { get; set; }
        public string Pum { get; set; }
        public int LeadTime { get; set; }
        public decimal PurchasingFactor { get; set; }
        public decimal BaseUnitPrice { get; set; }
        public string VenPartNum { get; set; }
        public string PriceFormat { get; set; }
        public string PricePerCode { get; set; }
        public decimal MinimumPrice { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Reference { get; set; }
        public decimal MiscAmt { get; set; }
        public string MiscCode { get; set; }
        public string CommentText { get; set; }
        public decimal DiscountPercent { get; set; }
        public string PartDescription { get; set; }
        public int Rfqnum { get; set; }
        public int Rfqline { get; set; }
        public string CurrencyCode { get; set; }
        public string MfgPartNum { get; set; }
        public decimal OnhandQty { get; set; }
        public DateTime? OnHandDate { get; set; }
        public int OnHandTime { get; set; }
        public int ConNum { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPartNum { get; set; }
        public int GlbVendorNum { get; set; }
        public string GlbOpCode { get; set; }
        public DateTime? GlbEffectiveDate { get; set; }
        public string PartCompany { get; set; }
        public string OldCompany { get; set; }
        public string OldPartNum { get; set; }
        public int OldVendorNum { get; set; }
        public string OldOpCode { get; set; }
        public DateTime? OldEffectiveDate { get; set; }
        public string PurchasingFactorDirection { get; set; }
        public bool SupplierResponseReady { get; set; }
        public int MfgNum { get; set; }
        public string VendPartNum { get; set; }
        public bool DefaultPum { get; set; }
        public decimal ConvFactor { get; set; }
        public string ConvOperator { get; set; }
        public bool ConvOverRide { get; set; }
        public string GlbPum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
