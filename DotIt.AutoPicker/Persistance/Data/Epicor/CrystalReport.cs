using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CrystalReport
    {
        public string Company { get; set; }
        public string ReportId { get; set; }
        public string RptDefId { get; set; }
        public bool SystemFlag { get; set; }
        public bool CustomFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
