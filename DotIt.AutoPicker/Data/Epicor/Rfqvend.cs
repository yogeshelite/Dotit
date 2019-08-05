using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Rfqvend
    {
        public string Company { get; set; }
        public bool OpenItem { get; set; }
        public string Response { get; set; }
        public int Rfqnum { get; set; }
        public int Rfqline { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public int ConNum { get; set; }
        public string RespondVia { get; set; }
        public DateTime? RespondDate { get; set; }
        public string ComplianceMsg { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
