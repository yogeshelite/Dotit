using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RebateTrans
    {
        public string Company { get; set; }
        public string RebateId { get; set; }
        public int LineNum { get; set; }
        public int CustNum { get; set; }
        public int TranNum { get; set; }
        public int InvoiceNum { get; set; }
        public DateTime? TranDate { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal Quantity { get; set; }
        public string QuantityUom { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DocUnitPrice { get; set; }
        public decimal ExtPrice { get; set; }
        public decimal DocExtPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal DocDiscount { get; set; }
        public decimal TotalMiscChrg { get; set; }
        public decimal DocTotalMiscChrg { get; set; }
        public decimal RebateAmount { get; set; }
        public decimal DocRebateAmount { get; set; }
        public decimal Adjustments { get; set; }
        public decimal DocAdjustments { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool Void { get; set; }
        public bool Applied { get; set; }
        public int InvoiceLine { get; set; }
        public string SalesDept { get; set; }
        public string SalesDiv { get; set; }
        public string ApinvoiceNum { get; set; }
        public int ArinvoiceNum { get; set; }
        public string PartNum { get; set; }
        public string ProdCode { get; set; }
        public int ApinvoiceLine { get; set; }
        public int ArinvoiceLine { get; set; }
        public decimal Rpt1Adjustments { get; set; }
        public decimal Rpt2Adjustments { get; set; }
        public decimal Rpt3Adjustments { get; set; }
        public decimal Rpt1Discount { get; set; }
        public decimal Rpt2Discount { get; set; }
        public decimal Rpt3Discount { get; set; }
        public decimal Rpt1ExtPrice { get; set; }
        public decimal Rpt2ExtPrice { get; set; }
        public decimal Rpt3ExtPrice { get; set; }
        public decimal Rpt1RebateAmount { get; set; }
        public decimal Rpt2RebateAmount { get; set; }
        public decimal Rpt3RebateAmount { get; set; }
        public decimal Rpt1TotalMiscChrg { get; set; }
        public decimal Rpt2TotalMiscChrg { get; set; }
        public decimal Rpt3TotalMiscChrg { get; set; }
        public decimal Rpt1UnitPrice { get; set; }
        public decimal Rpt2UnitPrice { get; set; }
        public decimal Rpt3UnitPrice { get; set; }
        public string RateGrpCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
