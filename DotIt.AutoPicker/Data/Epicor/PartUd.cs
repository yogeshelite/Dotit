using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PartUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public string CasePartNumberC { get; set; }
        public string CustomerGroupC { get; set; }
        public bool RequiresApprovalC { get; set; }
        public bool NeedPermissionReOrderC { get; set; }
        public bool OnlyComponentC { get; set; }
        public DateTime? CreateDateC { get; set; }
        public bool MagentoVisibleC { get; set; }
        public decimal CaseHeightC { get; set; }
        public decimal CaseLengthC { get; set; }
        public decimal CaseWidthC { get; set; }
        public bool DownloadableC { get; set; }
        public bool NonShippingC { get; set; }
        public string ShipCommentsC { get; set; }

        public virtual Part ForeignSysRow { get; set; }
    }
}
