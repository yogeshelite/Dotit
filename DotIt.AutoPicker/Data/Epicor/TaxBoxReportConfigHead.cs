using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TaxBoxReportConfigHead
    {
        public TaxBoxReportConfigHead()
        {
            TaxBoxReportConfigDtl = new HashSet<TaxBoxReportConfigDtl>();
        }

        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string Description { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public bool Active { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<TaxBoxReportConfigDtl> TaxBoxReportConfigDtl { get; set; }
    }
}
