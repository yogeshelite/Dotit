using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PbginvcRole
    {
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public int InvoiceNum { get; set; }
        public string RoleCode { get; set; }
        public decimal LbrAmt { get; set; }
        public decimal ConLbrAmt { get; set; }
        public decimal SubAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
