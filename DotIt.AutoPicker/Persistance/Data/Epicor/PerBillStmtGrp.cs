using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PerBillStmtGrp
    {
        public string Company { get; set; }
        public string PerBillStmtGrpId { get; set; }
        public DateTime? BillingDate { get; set; }
        public DateTime? SummarizationDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
