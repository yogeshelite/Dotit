using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class JpapperBillHead
    {
        public JpapperBillHead()
        {
            JpapperBillDtl = new HashSet<JpapperBillDtl>();
        }

        public string Company { get; set; }
        public int VendorNum { get; set; }
        public bool PerBillStatus { get; set; }
        public string DueDateCriteria { get; set; }
        public string DynCalId1 { get; set; }
        public string DynCalId2 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<JpapperBillDtl> JpapperBillDtl { get; set; }
    }
}
