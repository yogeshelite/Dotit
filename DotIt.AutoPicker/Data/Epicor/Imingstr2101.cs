using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imingstr2101
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
        public string DocumentNum { get; set; }
        public string ChkSum { get; set; }
        public DateTime? DocumentDate { get; set; }
        public decimal DocumentAmt { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal Tdsamt { get; set; }
        public decimal Igstrate { get; set; }
        public decimal IgsttaxAmt { get; set; }
        public decimal Cgstrate { get; set; }
        public decimal CgsttaxAmt { get; set; }
        public decimal Sgstrate { get; set; }
        public decimal SgsttaxAmt { get; set; }
        public int ApvendorNum { get; set; }
        public string ApinvoiceNum { get; set; }
        public DateTime? ApinvoiceDate { get; set; }
        public decimal ApinvoiceAmt { get; set; }
        public decimal Apigstrate { get; set; }
        public decimal ApigsttaxAmt { get; set; }
        public decimal Apcgstrate { get; set; }
        public decimal ApcgsttaxAmt { get; set; }
        public decimal Apsgstrate { get; set; }
        public decimal ApsgsttaxAmt { get; set; }
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
