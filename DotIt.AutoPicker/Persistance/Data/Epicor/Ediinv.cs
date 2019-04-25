using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Ediinv
    {
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
