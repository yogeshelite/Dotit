using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImquoteMsc
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public int QtyNum { get; set; }
        public int SeqNum { get; set; }
        public string MiscCode { get; set; }
        public string Description { get; set; }
        public decimal MiscAmt { get; set; }
        public decimal DocMiscAmt { get; set; }
        public string FreqCode { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public decimal Rpt1MiscAmt { get; set; }
        public decimal Rpt2MiscAmt { get; set; }
        public decimal Rpt3MiscAmt { get; set; }
        public decimal InMiscAmt { get; set; }
        public decimal DocInMiscAmt { get; set; }
        public decimal Rpt1InMiscAmt { get; set; }
        public decimal Rpt2InMiscAmt { get; set; }
        public decimal Rpt3InMiscAmt { get; set; }
        public decimal Percentage { get; set; }
        public string Type { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
