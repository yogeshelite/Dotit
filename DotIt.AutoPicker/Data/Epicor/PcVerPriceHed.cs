using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PcVerPriceHed
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int ConfigVersion { get; set; }
        public string ExtCompanyId { get; set; }
        public string CurrencyCode { get; set; }
        public string GeneralExpr { get; set; }
        public string SourceDbrecid { get; set; }
        public int PriceHedSeq { get; set; }
        public string QuotePcode { get; set; }
        public string OrderPcode { get; set; }
        public string PurchasePcode { get; set; }
        public string ConfigId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
