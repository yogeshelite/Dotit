using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CustGrup
    {
        public string Company { get; set; }
        public string GroupCode { get; set; }
        public string GroupDesc { get; set; }
        public string SalesCatId { get; set; }
        public bool GlobalCustGrup { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual CustGrupUd CustGrupUd { get; set; }
    }
}
