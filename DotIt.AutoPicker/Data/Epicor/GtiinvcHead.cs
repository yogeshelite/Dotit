using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GtiinvcHead
    {
        public string Company { get; set; }
        public int GroupNum { get; set; }
        public int GroupSuffix { get; set; }
        public int InvoiceNum { get; set; }
        public string Action { get; set; }
        public string Status1 { get; set; }
        public bool Status2 { get; set; }
        public bool IsSplitMerge { get; set; }
        public string GtiinvoiceNum { get; set; }
        public int GtiinvoiceType { get; set; }
        public DateTime? GtiinvoiceDate { get; set; }
        public decimal GtiinvoiceAmt { get; set; }
        public decimal GtitaxAmnt { get; set; }
        public int CustNum { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string CurrencyCode { get; set; }
        public string TaxPeriod { get; set; }
        public string TaxRegionCode { get; set; }
        public string Comments { get; set; }
        public string Notes { get; set; }
        public string ShipToNum { get; set; }
        public DateTime? ExportDate { get; set; }
        public DateTime? ImportDate { get; set; }
        public string ExportedBy { get; set; }
        public string ImportedBy { get; set; }
        public bool IsWaitForExport { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
