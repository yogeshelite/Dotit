using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PeboestatChHist
    {
        public string Company { get; set; }
        public int InvoiceNum { get; set; }
        public int RecordSeq { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Status { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
