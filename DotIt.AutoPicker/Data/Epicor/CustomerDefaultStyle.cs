using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CustomerDefaultStyle
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public string ReportId { get; set; }
        public int StyleNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
