using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QuoteCnt
    {
        public string Company { get; set; }
        public int QuoteNum { get; set; }
        public int CustNum { get; set; }
        public string ShipToNum { get; set; }
        public int ConNum { get; set; }
        public string Name { get; set; }
        public bool PrimeContact { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int PerConId { get; set; }
    }
}
