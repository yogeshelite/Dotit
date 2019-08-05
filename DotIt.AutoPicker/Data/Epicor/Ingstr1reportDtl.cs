using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Ingstr1reportDtl
    {
        public string Company { get; set; }
        public string ReportId { get; set; }
        public int InvoiceNum { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual Ingstr1report Ingstr1report { get; set; }
    }
}
