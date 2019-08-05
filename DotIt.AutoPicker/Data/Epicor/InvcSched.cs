using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class InvcSched
    {
        public string Company { get; set; }
        public int InvoiceNum { get; set; }
        public int PaySeq { get; set; }
        public int PayDays { get; set; }
        public decimal PayPercent { get; set; }
        public decimal PayAmount { get; set; }
        public DateTime? PayDueDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal DocPayAmount { get; set; }
        public decimal Rpt1PayAmount { get; set; }
        public decimal Rpt2PayAmount { get; set; }
        public decimal Rpt3PayAmount { get; set; }

        public virtual InvcHead InvcHead { get; set; }
    }
}
