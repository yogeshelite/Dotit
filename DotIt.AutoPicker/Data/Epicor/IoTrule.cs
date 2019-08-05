using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class IoTrule
    {
        public IoTrule()
        {
            IoTdeviceRuleState = new HashSet<IoTdeviceRuleState>();
            IoTruleLink = new HashSet<IoTruleLink>();
        }

        public string Company { get; set; }
        public string RuleId { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public string Condition { get; set; }
        public string Rule { get; set; }
        public bool Stateful { get; set; }
        public bool StoreEventData { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<IoTdeviceRuleState> IoTdeviceRuleState { get; set; }
        public virtual ICollection<IoTruleLink> IoTruleLink { get; set; }
    }
}
