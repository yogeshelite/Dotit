using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImtaxSvcMessages
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TaxSvcId { get; set; }
        public int Sequence { get; set; }
        public int OrderNum { get; set; }
        public int InvoiceNum { get; set; }
        public int LineNum { get; set; }
        public int DocLineNum { get; set; }
        public string Detail { get; set; }
        public string HelpLink { get; set; }
        public string Severity { get; set; }
        public string Summary { get; set; }
        public int DocId { get; set; }
        public string Name { get; set; }
        public string RefersTo { get; set; }
        public string Source { get; set; }
        public int QuoteNum { get; set; }
        public int OrderRelNum { get; set; }
        public string ApinvoiceNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
