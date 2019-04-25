using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BankTran
    {
        public string Company { get; set; }
        public string BankAcctId { get; set; }
        public int TranNum { get; set; }
        public DateTime? TranDate { get; set; }
        public decimal TranAmt { get; set; }
        public string TranRef { get; set; }
        public bool Glposted { get; set; }
        public string EntryPerson { get; set; }
        public DateTime? EntryDate { get; set; }
        public string EntryTime { get; set; }
        public bool TranCleared { get; set; }
        public bool TranClearPending { get; set; }
        public decimal TranClearedAmt { get; set; }
        public string TranClearedPerson { get; set; }
        public DateTime? TranClearedDate { get; set; }
        public string TranClearedTime { get; set; }
        public string BankSlip { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public int JournalNum { get; set; }
        public string JournalCode { get; set; }
        public decimal DocTranAmt { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal DocTranClearedAmt { get; set; }
        public string GroupId { get; set; }
        public decimal CashBookNum { get; set; }
        public int CashbookLine { get; set; }
        public string GlrefType { get; set; }
        public string GlrefCode { get; set; }
        public string GlrefCodeDesc { get; set; }
        public decimal Rpt1TranAmt { get; set; }
        public decimal Rpt2TranAmt { get; set; }
        public decimal Rpt3TranAmt { get; set; }
        public decimal Rpt1TranClearedAmt { get; set; }
        public decimal Rpt2TranClearedAmt { get; set; }
        public decimal Rpt3TranClearedAmt { get; set; }
        public string RateGrpCode { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public string BankFeeId { get; set; }
        public decimal BankFeeAmt { get; set; }
        public decimal BankFeeTaxAmt { get; set; }
        public decimal DocBankFeeAmt { get; set; }
        public decimal DocBankFeeTaxAmt { get; set; }
        public decimal Rpt1BankFeeAmt { get; set; }
        public decimal Rpt2BankFeeAmt { get; set; }
        public decimal Rpt3BankFeeAmt { get; set; }
        public decimal Rpt1BankFeeTaxAmt { get; set; }
        public decimal Rpt2BankFeeTaxAmt { get; set; }
        public decimal Rpt3BankFeeTaxAmt { get; set; }
        public string SourceModule { get; set; }
        public int HeadNum { get; set; }
        public bool Voided { get; set; }
        public string PcashDeskId { get; set; }
        public string GainLossType { get; set; }
        public int PcashRefNum { get; set; }
        public bool ReverseGl { get; set; }
        public DateTime? RevalueDate { get; set; }
        public decimal RevalueBal { get; set; }
        public decimal DocRevalueBal { get; set; }
        public decimal Rpt1RevalueBal { get; set; }
        public decimal Rpt2RevalueBal { get; set; }
        public decimal Rpt3RevalueBal { get; set; }
        public string LegalNumber { get; set; }
        public string TranDocTypeId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Cncficode { get; set; }
        public string CntoCficode { get; set; }
        public decimal BankRecGainLoss { get; set; }
        public decimal Rpt1BankRecGainLoss { get; set; }
        public decimal Rpt2BankRecGainLoss { get; set; }
        public decimal Rpt3BankRecGainLoss { get; set; }
        public int BalanceUpdated { get; set; }
        public decimal DocBankRecGainLoss { get; set; }
        public DateTime? MxrecDate { get; set; }
        public bool BankBatchExcluded { get; set; }
        public Guid BankBatchSysRowId { get; set; }
        public string Abtuid { get; set; }
    }
}
