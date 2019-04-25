using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TaxSvcMessages
    {
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
