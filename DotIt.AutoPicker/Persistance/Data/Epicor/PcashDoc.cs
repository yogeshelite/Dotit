using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PcashDoc
    {
        public string Company { get; set; }
        public string CashDeskId { get; set; }
        public int ReferenceNum { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string AuthorizedBy { get; set; }
        public string Cashier { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int CreateTime { get; set; }
        public string CurrencyCode { get; set; }
        public int DaySeqNum { get; set; }
        public string Direction { get; set; }
        public bool Draft { get; set; }
        public string ExternalNum { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalPeriod { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string LegalNumber { get; set; }
        public string OprTypeCode { get; set; }
        public bool PayrollBalOpr { get; set; }
        public bool Posted { get; set; }
        public bool Printed { get; set; }
        public string ReasonCode { get; set; }
        public int RvJrnUid { get; set; }
        public string RecipientType { get; set; }
        public int CustNum { get; set; }
        public string CustShipTo { get; set; }
        public int CustConNum { get; set; }
        public int VendorNum { get; set; }
        public string VendPurPoint { get; set; }
        public int VendConNum { get; set; }
        public string EmployeeNum { get; set; }
        public string BankAcctId { get; set; }
        public string OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string PersonName { get; set; }
        public string PersonalData { get; set; }
        public decimal DocCashAmt { get; set; }
        public decimal CashAmt { get; set; }
        public decimal Rpt1CashAmt { get; set; }
        public decimal Rpt2CashAmt { get; set; }
        public decimal Rpt3CashAmt { get; set; }
        public decimal DocGrossAmt { get; set; }
        public decimal GrossAmt { get; set; }
        public decimal Rpt1GrossAmt { get; set; }
        public decimal Rpt2GrossAmt { get; set; }
        public decimal Rpt3GrossAmt { get; set; }
        public decimal DocDiscount { get; set; }
        public decimal Discount { get; set; }
        public decimal Rpt1Discount { get; set; }
        public decimal Rpt2Discount { get; set; }
        public decimal Rpt3Discount { get; set; }
        public decimal DocWithholdAmt { get; set; }
        public decimal WithholdAmt { get; set; }
        public decimal Rpt1WithholdAmt { get; set; }
        public decimal Rpt2WithholdAmt { get; set; }
        public decimal Rpt3WithholdAmt { get; set; }
        public decimal DocBankAmt { get; set; }
        public decimal BankAmt { get; set; }
        public decimal Rpt1BankAmt { get; set; }
        public decimal Rpt2BankAmt { get; set; }
        public decimal Rpt3BankAmt { get; set; }
        public decimal DocBankFeeAmt { get; set; }
        public decimal BankFeeAmt { get; set; }
        public decimal Rpt1BankFeeAmt { get; set; }
        public decimal Rpt2BankFeeAmt { get; set; }
        public decimal Rpt3BankFeeAmt { get; set; }
        public string RateGrpType { get; set; }
        public bool OnAccount { get; set; }
        public string OnAcctBankAcctId { get; set; }
        public decimal ReceiptAmt { get; set; }
        public string Reference { get; set; }
        public string Payee { get; set; }
        public string AccountNumber { get; set; }
        public string OtherDetails { get; set; }
        public int PayMethodPmuid { get; set; }
        public string PayMethodName { get; set; }
        public string PayMethodReference { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string CashDeskIdtransfer { get; set; }
        public DateTime? ExchangeRateDate { get; set; }
        public bool ExchRateDateUserDefined { get; set; }
        public int PrintPage { get; set; }
        public string PrintPageLegalNum { get; set; }
        public string Reason { get; set; }
    }
}
