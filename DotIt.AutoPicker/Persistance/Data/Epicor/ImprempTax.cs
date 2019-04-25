using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImprempTax
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string EmpLink { get; set; }
        public string TaxTblId { get; set; }
        public int PerExempt { get; set; }
        public int DepExempt { get; set; }
        public string FileStatus { get; set; }
        public decimal AddlWithholding { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal FixedEx { get; set; }
        public bool Exempt { get; set; }
        public bool InActive { get; set; }
        public string ClassId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
