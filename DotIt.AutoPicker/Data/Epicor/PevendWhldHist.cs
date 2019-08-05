using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PevendWhldHist
    {
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public int RecordSeq { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UserId { get; set; }
        public string IdentityDocType { get; set; }
        public bool GoodContributor { get; set; }
        public bool WithholdingAgent { get; set; }
        public bool CollectionAgent { get; set; }
        public bool NotFound { get; set; }
        public bool NoAddress { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
