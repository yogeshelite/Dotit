using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SugPoDtlUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public bool RequiresApprovalC { get; set; }
        public bool CreditHoldC { get; set; }

        public virtual SugPoDtl ForeignSysRow { get; set; }
    }
}
