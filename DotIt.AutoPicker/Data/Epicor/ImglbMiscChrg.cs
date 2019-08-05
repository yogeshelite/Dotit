﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbMiscChrg
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string FreqCode { get; set; }
        public string IncomeTaxCode { get; set; }
        public string Ischarge { get; set; }
        public decimal MiscAmt { get; set; }
        public string MiscCode { get; set; }
        public decimal Percentage { get; set; }
        public bool SalesAnalysis { get; set; }
        public bool ShippingAccess { get; set; }
        public string TaxCatId { get; set; }
        public string Type { get; set; }
        public string GlbCompany { get; set; }
        public string GlbMiscCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalMiscChrg { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool IncludeDiscount { get; set; }
        public string MxprodServCode { get; set; }
        public bool SendToFsa { get; set; }
        public string PechargeDiscountCode { get; set; }
    }
}
