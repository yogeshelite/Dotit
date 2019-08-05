using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbDeliveryType
    {
        public string Company { get; set; }
        public string DeliveryType { get; set; }
        public string Description { get; set; }
        public string GlbCompany { get; set; }
        public string GlbDeliveryType1 { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalDeliveryType { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
