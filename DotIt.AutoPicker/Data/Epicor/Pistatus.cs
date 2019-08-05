using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Pistatus
    {
        public string Company { get; set; }
        public string Pistatus1 { get; set; }
        public string StatusDesc { get; set; }
        public int Piscope { get; set; }
        public string Pistage { get; set; }
        public string BankCode { get; set; }
        public bool PostToGl { get; set; }
        public bool GlobalPistatus { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
