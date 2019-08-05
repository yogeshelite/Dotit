using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CaptureLog
    {
        public long CaptureLogId { get; set; }
        public long TransactionId { get; set; }
        public long TransactionSeqNum { get; set; }
        public DateTime OccurredWhenUtc { get; set; }
        public string RowData { get; set; }
    }
}
