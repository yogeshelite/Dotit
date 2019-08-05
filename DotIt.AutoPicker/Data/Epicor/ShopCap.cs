using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ShopCap
    {
        public string Company { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
        public DateTime? LoadDate { get; set; }
        public decimal Capacity { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int CapRevId { get; set; }
    }
}
