using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imediinv
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
        public int OrderNum { get; set; }
        public int CustNum { get; set; }
        public DateTime? Date810Created { get; set; }
        public bool Exported { get; set; }
        public DateTime? DateExported { get; set; }
        public bool Send { get; set; }
        public DateTime? DateLastSent { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
