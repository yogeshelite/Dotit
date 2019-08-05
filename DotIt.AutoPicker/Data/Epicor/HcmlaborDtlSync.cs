using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class HcmlaborDtlSync
    {
        public string Company { get; set; }
        public Guid LaborDtlSysRowId { get; set; }
        public string Status { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
