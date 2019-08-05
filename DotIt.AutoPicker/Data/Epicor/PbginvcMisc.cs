using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PbginvcMisc
    {
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public int InvoiceNum { get; set; }
        public string MiscCode { get; set; }
        public decimal MiscAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
