using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Prcheck
    {
        public string Company { get; set; }
        public bool Posted { get; set; }
        public string GroupId { get; set; }
        public int HeadNum { get; set; }
        public string EmpLink { get; set; }
        public string BankAcctId { get; set; }
        public int CheckNum { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? Psdate { get; set; }
        public DateTime? Pedate { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public bool Voided { get; set; }
        public decimal TotalBasePay { get; set; }
        public decimal TotalPremiumPay { get; set; }
        public decimal TotalShiftPay { get; set; }
        public decimal TotalTaxes { get; set; }
        public decimal TotalDeductions { get; set; }
        public decimal TotalBaseHours { get; set; }
        public decimal TotalPremiumHours { get; set; }
        public decimal CheckAmt { get; set; }
        public bool StartupCheck { get; set; }
        public string EntryPerson { get; set; }
        public string WorkCompCode { get; set; }
        public string ClassId { get; set; }
        public string Note { get; set; }
        public string PayFrequency { get; set; }
        public bool ClearedCheck { get; set; }
        public bool ClearedPending { get; set; }
        public decimal ClearedAmt { get; set; }
        public string ClearedPerson { get; set; }
        public DateTime? ClearedDate { get; set; }
        public string ClearedTime { get; set; }
        public DateTime? ClearedStmtEndDate { get; set; }
        public string BankSlip { get; set; }
        public decimal CashBookNum { get; set; }
        public int CashbookLine { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public string PaymentNumber { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ActiveToPrint { get; set; }
        public DateTime? MxrecDate { get; set; }
        public DateTime? VoidedDate { get; set; }
    }
}
