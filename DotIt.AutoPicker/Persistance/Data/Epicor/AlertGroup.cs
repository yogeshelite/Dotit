using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AlertGroup
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string Description { get; set; }
        public string AlertList { get; set; }
        public string WarningList { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
