using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class VendPart
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string OpCode { get; set; }
        public string Pum { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int VendorNum { get; set; }
        public int LeadTime { get; set; }
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
        public decimal OnhandQty { get; set; }
        public DateTime? OnHandDate { get; set; }
        public int OnHandTime { get; set; }
        public int ConNum { get; set; }
        public bool SupplierResponseReady { get; set; }
        public bool DefaultPum { get; set; }
        public string ConvOperator { get; set; }
        public decimal ConvFactor { get; set; }
        public bool ConvOverRide { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
