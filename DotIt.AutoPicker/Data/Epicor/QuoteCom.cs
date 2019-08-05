using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QuoteCom
    {
        public string Company { get; set; }
        public int QuoteNum { get; set; }
        public int CompNum { get; set; }
        public string Name { get; set; }
        public bool PrimeComp { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
