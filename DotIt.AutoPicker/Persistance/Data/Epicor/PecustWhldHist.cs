using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PecustWhldHist
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public int RecordSeq { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UserId { get; set; }
        public bool GoodContributor { get; set; }
        public bool WithholdingAgent { get; set; }
        public bool CollectionAgent { get; set; }
        public bool NotFound { get; set; }
        public bool NoAddress { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
