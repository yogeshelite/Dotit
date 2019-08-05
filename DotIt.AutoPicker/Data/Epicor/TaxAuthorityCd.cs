using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TaxAuthorityCd
    {
        public string Company { get; set; }
        public string TaxAuthorityCode { get; set; }
        public string TaxAuthorityDescription { get; set; }
        public bool Inactive { get; set; }
        public bool GlobalTaxAuthorityCd { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
