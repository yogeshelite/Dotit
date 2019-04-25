using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Indirect
    {
        public string Company { get; set; }
        public string IndirectCode { get; set; }
        public string Description { get; set; }
        public string ExpenseCode { get; set; }
        public bool GlobalIndirect { get; set; }
        public bool GlobalLock { get; set; }
        public bool Inactive { get; set; }
        public bool DownTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ExternalMessyncRequired { get; set; }
        public DateTime? ExternalMeslastSync { get; set; }
    }
}
