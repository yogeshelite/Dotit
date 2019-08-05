using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RptStylePrinters
    {
        public string Company { get; set; }
        public string ReportId { get; set; }
        public int StyleNum { get; set; }
        public string PrinterId { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
