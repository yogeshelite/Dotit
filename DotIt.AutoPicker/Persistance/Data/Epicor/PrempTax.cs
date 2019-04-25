using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PrempTax
    {
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
