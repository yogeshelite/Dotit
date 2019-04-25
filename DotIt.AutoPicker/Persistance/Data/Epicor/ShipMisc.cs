using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ShipMisc
    {
        public string Company { get; set; }
        public int PackNum { get; set; }
        public int PackLine { get; set; }
        public int SeqNum { get; set; }
        public string MiscCode { get; set; }
        public string Description { get; set; }
        public decimal MiscAmt { get; set; }
        public string SourceDbrecid { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public decimal InMiscAmt { get; set; }
        public decimal Percentage { get; set; }
        public string Type { get; set; }
        public bool WiisAutoCreatedMisc { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal DocMiscAmt { get; set; }
    }
}
