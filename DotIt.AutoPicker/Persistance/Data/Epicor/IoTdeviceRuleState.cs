using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class IoTdeviceRuleState
    {
        public string Company { get; set; }
        public string DeviceId { get; set; }
        public string RuleId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual IoTdevice IoTdevice { get; set; }
        public virtual IoTrule IoTrule { get; set; }
    }
}
