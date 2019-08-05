using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AlcHistBatch
    {
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
