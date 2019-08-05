using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Dcrmsubs
    {
        public string DeviceId { get; set; }
        public int SubscriptionSeq { get; set; }
        public string SubscriptionName { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
