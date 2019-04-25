using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GtiinvcDtl
    {
        public string Company { get; set; }
        public int GroupNum { get; set; }
        public int GroupSuffix { get; set; }
        public int InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public string PartNum { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountAmt { get; set; }
        public decimal DiscountTaxAmt { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal TotalAmt { get; set; }
        public string TaxCode { get; set; }
        public decimal TaxRate { get; set; }
        public string PartDescription { get; set; }
        public string Ium { get; set; }
        public string Specification { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Iumdescription { get; set; }
        public string CodeVersion { get; set; }
        public string TaxCategoryCode { get; set; }
        public bool HasPreferentialTreatment { get; set; }
        public string PreferentialTreatmentContent { get; set; }
        public string ZeroTaxRateMark { get; set; }
        public decimal DeductionAmount { get; set; }
    }
}
