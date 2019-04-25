using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TaxCat
    {
        public string Company { get; set; }
        public string TaxCatId { get; set; }
        public string Description { get; set; }
        public bool InternalUseTax { get; set; }
        public bool SysDefault { get; set; }
        public bool ExcIntrastats { get; set; }
        public bool GlobalTaxCat { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool AguseGoodDefaultMark { get; set; }
        public string AgrelatedTaxCatId { get; set; }
        public string MyindustryCode { get; set; }
        public string IntaxCategoryType { get; set; }
    }
}
