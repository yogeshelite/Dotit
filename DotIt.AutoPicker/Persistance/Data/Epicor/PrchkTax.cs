using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PrchkTax
    {
        public string Company { get; set; }
        public int HeadNum { get; set; }
        public string TaxTblId { get; set; }
        public string TaxType { get; set; }
        public string ClassId { get; set; }
        public bool Posted { get; set; }
        public string EmpLink { get; set; }
        public DateTime? CheckDate { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal PriorTaxYtd { get; set; }
        public decimal TaxableHours { get; set; }
        public decimal SupTaxableAmt { get; set; }
        public decimal SupTaxableHours { get; set; }
        public decimal TaxableAmt { get; set; }
        public decimal PriorTaxableYtd { get; set; }
        public bool Active { get; set; }
        public bool ManualCalc { get; set; }
        public bool Voided { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int PrintHeadNum { get; set; }
    }
}
