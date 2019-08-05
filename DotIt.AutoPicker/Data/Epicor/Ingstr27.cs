using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Ingstr27
    {
        public string Company { get; set; }
        public string ReportId { get; set; }
        public string Gstid { get; set; }
        public string Cdnum { get; set; }
        public string Type { get; set; }
        public string Recipient { get; set; }
        public string ChkSum { get; set; }
        public string NoteType { get; set; }
        public DateTime? Cddate { get; set; }
        public string Reason { get; set; }
        public decimal Cdamt { get; set; }
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
        public decimal Apigstrate { get; set; }
        public decimal ApigsttaxAmt { get; set; }
        public decimal Apcgstrate { get; set; }
        public decimal ApcgsttaxAmt { get; set; }
        public decimal Apitcigstamt { get; set; }
        public decimal Apitccgstamt { get; set; }
        public decimal Apitcsgstamt { get; set; }
        public decimal ApitcclaimIgstamt { get; set; }
        public decimal ApitcclaimCgstamt { get; set; }
        public decimal ApitcclaimSgstamt { get; set; }
        public string Message { get; set; }
        public string Notes { get; set; }
        public int LineStatus { get; set; }
        public bool Manual { get; set; }
        public int ImportCounter { get; set; }
        public decimal Apsgstrate { get; set; }
        public decimal ApsgsttaxAmt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
