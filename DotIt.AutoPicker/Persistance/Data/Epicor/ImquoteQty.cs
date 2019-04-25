using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImquoteQty
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public int QtyNum { get; set; }
        public decimal OurQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DocUnitPrice { get; set; }
        public string PricePerCode { get; set; }
        public decimal MtlBurMarkUp { get; set; }
        public decimal MaterialMarkUp { get; set; }
        public decimal SubcontractMarkUp { get; set; }
        public decimal LaborMarkUp { get; set; }
        public decimal BurdenMarkUp { get; set; }
        public string MiscCostDesc { get; set; }
        public decimal MiscCost { get; set; }
        public decimal MiscCostMarkUp { get; set; }
        public decimal CommissionPct { get; set; }
        public string PercentType { get; set; }
        public string Ium { get; set; }
        public string SalesUm { get; set; }
        public decimal SellingFactor { get; set; }
        public decimal SellingQuantity { get; set; }
        public string SellingFactorDirection { get; set; }
        public string MarkUpId { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public decimal Rpt1UnitPrice { get; set; }
        public decimal Rpt2UnitPrice { get; set; }
        public decimal Rpt3UnitPrice { get; set; }
        public decimal InUnitPrice { get; set; }
        public decimal DocInUnitPrice { get; set; }
        public decimal Rpt1InUnitPrice { get; set; }
        public decimal Rpt2InUnitPrice { get; set; }
        public decimal Rpt3InUnitPrice { get; set; }
        public string PriceSource { get; set; }
        public decimal PricePerAdl1000 { get; set; }
        public decimal TotalSellPrice { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal DocPricePerAdl1000 { get; set; }
        public decimal DocTotalSellPrice { get; set; }
        public bool UserChangedUnitPrice { get; set; }
    }
}
