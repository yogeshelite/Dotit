using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class IoTdeviceEventQueue
    {
        public string Company { get; set; }
        public long QueueSeq { get; set; }
        public string RuleId { get; set; }
        public string DeviceId { get; set; }
        public string EventData { get; set; }
        public string RuleResultData { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
