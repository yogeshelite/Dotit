using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ReportDefaultStyle
    {
        public string ReportId { get; set; }
        public string Company { get; set; }
        public int StyleNum { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string DefaultSsrsrenderFormat { get; set; }

        public virtual Report Report { get; set; }
    }
}
