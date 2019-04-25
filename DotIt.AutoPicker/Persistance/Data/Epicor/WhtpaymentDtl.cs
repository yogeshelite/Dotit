using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class WhtpaymentDtl
    {
        public string Company { get; set; }
        public string ReportId { get; set; }
        public DateTime TranDate { get; set; }
        public int TranNum { get; set; }
        public bool IsPaid { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual TaxTran TaxTran { get; set; }
        public virtual WhtpaymentHead WhtpaymentHead { get; set; }
    }
}
