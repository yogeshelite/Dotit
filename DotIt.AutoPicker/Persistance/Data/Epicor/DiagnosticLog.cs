using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class DiagnosticLog
    {
        public long DiagnosticLogId { get; set; }
        public long TransactionId { get; set; }
        public long TransactionSeqNum { get; set; }
        public DateTime OccurredWhenUtc { get; set; }
        public string RowData { get; set; }
        public string Context { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
