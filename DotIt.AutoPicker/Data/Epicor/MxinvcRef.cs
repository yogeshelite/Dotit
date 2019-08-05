using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class MxinvcRef
    {
        public string Company { get; set; }
        public int InvoiceNum { get; set; }
        public int RefInvoiceNum { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual InvcHead InvcHead { get; set; }
    }
}
