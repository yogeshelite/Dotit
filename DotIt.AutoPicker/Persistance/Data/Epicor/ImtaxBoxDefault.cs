using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImtaxBoxDefault
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string BoxCode { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string Xmltag { get; set; }
        public string SourceModule { get; set; }
        public string AmountType { get; set; }
        public string BoxSign { get; set; }
        public int EcacquisitionSeq { get; set; }
        public bool GlobalTaxBoxDefault { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
