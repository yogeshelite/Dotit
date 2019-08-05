using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Rfqpart
    {
        public string Company { get; set; }
        public int Rfqnum { get; set; }
        public int Rfqline { get; set; }
        public int MfgNum { get; set; }
        public string MfgPartNum { get; set; }
        public bool Rfqinclude { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
