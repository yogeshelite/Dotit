using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CashBdtl
    {
        public string Company { get; set; }
        public string BankAcctId { get; set; }
        public decimal CashBookNum { get; set; }
        public int CashbookLine { get; set; }
        public int LineNum { get; set; }
        public string Description { get; set; }
        public string TranType { get; set; }
        public bool Posted { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public DateTime? TranDate { get; set; }
        public decimal TranAmt { get; set; }
        public decimal DocTranAmt { get; set; }
        public decimal Rpt1TranAmt { get; set; }
        public decimal Rpt2TranAmt { get; set; }
        public decimal Rpt3TranAmt { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public string LinkedTranType { get; set; }
        public int LinkedHeadNum { get; set; }
        public string BankTranId { get; set; }
        public DateTime? BankTransDate { get; set; }
        public string Partner { get; set; }
        public string PartnerName { get; set; }
        public int PartnerNum { get; set; }
        public int PartnerType { get; set; }
        public string DebitCreditMark { get; set; }
        public decimal ImportTranAmount { get; set; }
        public decimal ImportTranUnclearedAmount { get; set; }
        public decimal ImportUnclearedAmount { get; set; }
        public decimal ImportRpt1UnclearedAmount { get; set; }
        public decimal ImportRpt2UnclearedAmount { get; set; }
        public decimal ImportRpt3UnclearedAmount { get; set; }
        public string ImportTranCurrency { get; set; }
        public decimal ImportBankAmount { get; set; }
        public decimal ImportBankVariance { get; set; }
        public decimal ImportAmount { get; set; }
        public decimal ExchangeRate { get; set; }
        public int LineStatus { get; set; }
        public int LineType { get; set; }
        public string LineDescription { get; set; }
        public string DocumentList { get; set; }
        public bool OnAccount { get; set; }
        public string ImportError { get; set; }
        public bool FilterByPartner { get; set; }
        public decimal ImportBankGainLoss { get; set; }
        public decimal ImportGainLoss { get; set; }
        public decimal ImportRpt1GainLoss { get; set; }
        public decimal ImportRpt2GainLoss { get; set; }
        public decimal ImportRpt3GainLoss { get; set; }
        public string BankTranType { get; set; }
        public decimal ImportBankUnclearedAmount { get; set; }
        public string ImportTranType { get; set; }
        public string ImportTranCode { get; set; }
        public string TranRef { get; set; }
        public string PartnerBank { get; set; }
        public string PartnerBankAcct { get; set; }
        public bool ReverseFlag { get; set; }
        public decimal TotalChrgAmt { get; set; }
        public string ChrgCurrCode { get; set; }
        public string RawData { get; set; }
        public string MatchingInfo { get; set; }
        public string RemitData { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string BankFeeId { get; set; }
        public string TransferBankId { get; set; }
        public string PartnerId { get; set; }
        public int CreateMode { get; set; }
        public string UserComment { get; set; }
        public DateTime? MxrecDate { get; set; }
        public DateTime? ClearDate { get; set; }
    }
}
