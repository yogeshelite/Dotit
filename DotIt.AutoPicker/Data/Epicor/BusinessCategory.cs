using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BusinessCategory
    {
        public BusinessCategory()
        {
            CustBusinessCategory = new HashSet<CustBusinessCategory>();
            VendBusinessCategory = new HashSet<VendBusinessCategory>();
        }

        public string Company { get; set; }
        public string BusinessCatId { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<CustBusinessCategory> CustBusinessCategory { get; set; }
        public virtual ICollection<VendBusinessCategory> VendBusinessCategory { get; set; }
    }
}
