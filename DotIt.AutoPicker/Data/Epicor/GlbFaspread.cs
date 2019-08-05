using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbFaspread
    {
        public string CalendarId { get; set; }
        public string Company { get; set; }
        public bool DepRecalcNeeded { get; set; }
        public string Description { get; set; }
        public string SpreadCode { get; set; }
        public string SpreadType { get; set; }
        public string GlbCompany { get; set; }
        public string GlbSpreadCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalFaspread { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
