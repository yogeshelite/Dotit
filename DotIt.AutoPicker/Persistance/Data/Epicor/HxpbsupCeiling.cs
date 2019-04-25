using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class HxpbsupCeiling
    {
        public int Revision { get; set; }
        public decimal Ceiling { get; set; }
        public string Company { get; set; }
        public decimal DocCeiling { get; set; }
        public decimal PrcMarkup { get; set; }
        public string ProjectId { get; set; }
        public decimal Rpt1Ceiling { get; set; }
        public decimal Rpt2Ceiling { get; set; }
        public decimal Rpt3Ceiling { get; set; }
        public int VendorNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
