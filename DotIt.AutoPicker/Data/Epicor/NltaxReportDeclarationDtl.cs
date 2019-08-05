using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class NltaxReportDeclarationDtl
    {
        public string Company { get; set; }
        public int DeclarationUid { get; set; }
        public string BoxCode { get; set; }
        public decimal BoxSysTaxableAmt { get; set; }
        public decimal BoxSysTaxAmt { get; set; }
        public decimal BoxTaxableAmt { get; set; }
        public decimal BoxTaxAmt { get; set; }
        public decimal DocBoxSysTaxableAmt { get; set; }
        public decimal DocBoxSysTaxAmt { get; set; }
        public decimal DocBoxTaxableAmt { get; set; }
        public decimal DocBoxTaxAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual NltaxReportDeclaration NltaxReportDeclaration { get; set; }
    }
}
