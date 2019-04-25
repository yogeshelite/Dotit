using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImpecompWhldHist
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
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
