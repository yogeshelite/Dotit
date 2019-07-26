using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class IoTdevice
    {
        public IoTdevice()
        {
            IoTdeviceEvent = new HashSet<IoTdeviceEvent>();
            IoTdeviceRuleState = new HashSet<IoTdeviceRuleState>();
        }

        public string Company { get; set; }
        public string DeviceId { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public string GroupId { get; set; }
        public string RelatedToSchemaName { get; set; }
        public string RelatedToTableName { get; set; }
        public Guid RelatedToSysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<IoTdeviceEvent> IoTdeviceEvent { get; set; }
        public virtual ICollection<IoTdeviceRuleState> IoTdeviceRuleState { get; set; }
    }
}
