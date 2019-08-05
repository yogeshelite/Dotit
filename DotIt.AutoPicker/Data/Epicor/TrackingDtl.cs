using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TrackingDtl
    {
        public string Company { get; set; }
        public int PackNum { get; set; }
        public int OrderNum { get; set; }
        public decimal Weight { get; set; }
        public string CaseNum { get; set; }
        public string TrackingNumber { get; set; }
        public string ShipmentType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
