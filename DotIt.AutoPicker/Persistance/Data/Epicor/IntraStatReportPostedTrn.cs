using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class IntraStatReportPostedTrn
    {
        public string Company { get; set; }
        public string ReportId { get; set; }
        public string InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public int VendorNum { get; set; }
        public int SeqNum { get; set; }
        public bool Posted { get; set; }
        public string SourceModule { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
