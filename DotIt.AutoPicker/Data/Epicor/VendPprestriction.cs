using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class VendPprestriction
    {
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public string RestrictionTypeId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
