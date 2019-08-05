using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class MasterPackDtl
    {
        public string Company { get; set; }
        public int PackNum { get; set; }
        public int DtlPackNum { get; set; }
        public int MpackLine { get; set; }
        public string ShipmentType { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
