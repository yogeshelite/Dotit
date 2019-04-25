using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbTaxAuthorityCd
    {
        public string Company { get; set; }
        public bool Inactive { get; set; }
        public string TaxAuthorityCode { get; set; }
        public string TaxAuthorityDescription { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTaxAuthorityCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalTaxAuthorityCd { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
