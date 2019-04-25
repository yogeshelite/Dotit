using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbPistatus
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string BankCode { get; set; }
        public string Company { get; set; }
        public int Piscope { get; set; }
        public string Pistage { get; set; }
        public string Pistatus { get; set; }
        public bool PostToGl { get; set; }
        public string StatusDesc { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPistatus { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPistatus { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
