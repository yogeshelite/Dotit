using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PbginvcPart
    {
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public int InvoiceNum { get; set; }
        public string PartNum { get; set; }
        public decimal MtlAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
