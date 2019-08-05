using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ReminderGroup
    {
        public string Company { get; set; }
        public string GroupCode { get; set; }
        public string Description { get; set; }
        public bool DateOffset { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
