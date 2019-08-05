using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EventHubLease
    {
        public string Company { get; set; }
        public string EventHubName { get; set; }
        public string ConsumerGroupName { get; set; }
        public string PartitionId { get; set; }
        public string Offset { get; set; }
        public long Epoch { get; set; }
        public long SequenceNumber { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
