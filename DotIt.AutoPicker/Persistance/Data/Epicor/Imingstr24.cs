using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imingstr24
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
        public string Gstid { get; set; }
        public string InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal InvoiceAmt { get; set; }
        public string PlaceSupply { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Hsnsac { get; set; }
        public decimal TaxableAmt { get; set; }
        public decimal Igstrate { get; set; }
        public decimal IgsttaxAmt { get; set; }
        public decimal Cgstrate { get; set; }
        public decimal CgsttaxAmt { get; set; }
        public decimal Sgstrate { get; set; }
        public decimal SgsttaxAmt { get; set; }
        public string Itceligibility { get; set; }
        public decimal Itcigstamt { get; set; }
        public decimal Itccgstamt { get; set; }
        public decimal Itcsgstamt { get; set; }
        public decimal ItcclaimIgstamt { get; set; }
        public decimal ItcclaimCgstamt { get; set; }
        public decimal ItcclaimSgstamt { get; set; }
        public int ApvendorNum { get; set; }
        public string ApinvoiceNum { get; set; }
        public DateTime? ApinvoiceDate { get; set; }
        public decimal ApinvoiceAmt { get; set; }
        public int ApinvoiceLine { get; set; }
        public string AplineCommodityCode { get; set; }
        public decimal AplineTaxableAmt { get; set; }
        public decimal AplineIgstrate { get; set; }
        public decimal AplineIgsttaxAmt { get; set; }
        public decimal AplineCgstrate { get; set; }
        public decimal AplineCgsttaxAmt { get; set; }
        public decimal AplineSgstrate { get; set; }
        public decimal AplineSgsttaxAmt { get; set; }
        public decimal AplineItcigstamt { get; set; }
        public decimal AplineItccgstamt { get; set; }
        public decimal AplineItcsgstamt { get; set; }
        public decimal AplineItcclaimIgstamt { get; set; }
        public decimal AplineItcclaimCgstamt { get; set; }
        public decimal AplineItcclaimSgstamt { get; set; }
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
