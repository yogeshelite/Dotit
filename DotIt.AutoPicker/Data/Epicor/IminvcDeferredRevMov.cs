using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class IminvcDeferredRevMov
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public int InvcDeferredRevMovId { get; set; }
        public bool Posted { get; set; }
        public decimal DeferredRevAmt { get; set; }
        public decimal DocDeferredRevAmt { get; set; }
        public decimal Rpt1DeferredRevAmt { get; set; }
        public decimal Rpt2DeferredRevAmt { get; set; }
        public decimal Rpt3DeferredRevAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
