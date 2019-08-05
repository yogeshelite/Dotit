using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class IoTruleLink
    {
        public string Company { get; set; }
        public string RuleId { get; set; }
        public string RelatedToTableName { get; set; }
        public Guid RelatedToSysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual IoTrule IoTrule { get; set; }
    }
}
