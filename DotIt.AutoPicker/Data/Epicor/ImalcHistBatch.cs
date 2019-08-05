using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImalcHistBatch
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string BatchId { get; set; }
        public int RunNbr { get; set; }
        public DateTime? RunDate { get; set; }
        public int RunTime { get; set; }
        public int RunType { get; set; }
        public string DcdUserId { get; set; }
        public string BookId { get; set; }
        public bool Reverse { get; set; }
        public string JournalCode { get; set; }
        public int LastCycleNbr { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
