using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RebateCustDtl
    {
        public string Company { get; set; }
        public string RebateId { get; set; }
        public int LineNum { get; set; }
        public int CustNum { get; set; }
        public bool Void { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal AccruedAmount { get; set; }
        public decimal AccruedQty { get; set; }
        public string Uomcode { get; set; }
        public decimal AccruedTot { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
