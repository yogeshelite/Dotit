using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class VendBusinessCategory
    {
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string BusinessCatId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual BusinessCategory BusinessCategory { get; set; }
    }
}
