using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class IoTdeviceEvent
    {
        public string Company { get; set; }
        public string DeviceId { get; set; }
        public long EventSeq { get; set; }
        public string RuleId { get; set; }
        public string EventData { get; set; }
        public string RuleResultData { get; set; }
        public DateTime? ProcessedOn { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual IoTdevice IoTdevice { get; set; }
    }
}
