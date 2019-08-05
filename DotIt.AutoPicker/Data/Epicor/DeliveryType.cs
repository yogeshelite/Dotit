using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class DeliveryType
    {
        public string Company { get; set; }
        public string DeliveryType1 { get; set; }
        public string Description { get; set; }
        public bool GlobalDeliveryType { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
