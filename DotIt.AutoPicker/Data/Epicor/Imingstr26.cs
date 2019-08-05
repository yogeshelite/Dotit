using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imingstr26
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ReportId { get; set; }
        public string InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal InvoiceAmt { get; set; }
        public string Hsnsac { get; set; }
        public decimal TaxableAmt { get; set; }
        public decimal Igstrate { get; set; }
        public decimal IgsttaxAmt { get; set; }
        public string Itceligibility { get; set; }
        public decimal TotalItcadmissible { get; set; }
        public decimal ItcadmissibleMonth { get; set; }
        public decimal Itcigstamt { get; set; }
        public decimal ItcclaimIgstamt { get; set; }
        public int ApvendorNum { get; set; }
        public string ApinvoiceNum { get; set; }
        public DateTime? ApinvoiceDate { get; set; }
        public decimal ApinvoiceAmt { get; set; }
        public int ApinvoiceLine { get; set; }
        public string AplineCommodityCode { get; set; }
        public decimal AplineTaxableAmt { get; set; }
        public decimal AplineIgstrate { get; set; }
        public decimal AplineIgsttaxAmt { get; set; }
        public decimal AplineTotalItcadmissible { get; set; }
        public decimal AplineItcadmissibleMonth { get; set; }
        public decimal AplineItcigstamt { get; set; }
        public decimal AplineItcclaimIgstamt { get; set; }
        public string Message { get; set; }
        public string Notes { get; set; }
        public int LineStatus { get; set; }
        public bool Manual { get; set; }
        public int ImportCounter { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
