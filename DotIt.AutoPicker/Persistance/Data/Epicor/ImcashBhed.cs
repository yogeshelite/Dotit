using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImcashBhed
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string BankAcctId { get; set; }
        public decimal CashBookNum { get; set; }
        public int Bankslip { get; set; }
        public string GroupId { get; set; }
        public bool Posted { get; set; }
        public string Description { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal DocOpeningBalance { get; set; }
        public DateTime? OpeningDate { get; set; }
        public decimal ClosingBalance { get; set; }
        public decimal DocClosingBalance { get; set; }
        public DateTime? ClosingDate { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal Rpt1ClosingBalance { get; set; }
        public decimal Rpt2ClosingBalance { get; set; }
        public decimal Rpt3ClosingBalance { get; set; }
        public decimal Rpt1OpeningBalance { get; set; }
        public decimal Rpt2OpeningBalance { get; set; }
        public decimal Rpt3OpeningBalance { get; set; }
        public string RateGrpCode { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public DateTime? ApplyDate { get; set; }
        public DateTime? FilterToDate { get; set; }
        public string FilterToDateToken { get; set; }
        public int RetrieveStatus { get; set; }
        public bool IncludePipastClose { get; set; }
        public bool Imported { get; set; }
        public string GrpCashReceipt { get; set; }
        public string GrpAppay { get; set; }
        public string GrpBankAdj { get; set; }
        public string GrpBankTrans { get; set; }
        public string RefNum { get; set; }
        public string Info { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool FilterByLineType { get; set; }
        public DateTime? StatementDate { get; set; }
        public bool UseClosingDateCutoff { get; set; }
        public string TranDocTypeId { get; set; }
        public string LegalNumber { get; set; }
        public bool UnconvertedStatement { get; set; }
        public int StatementVersion { get; set; }
        public string GrpArpi { get; set; }
        public string ProcessStatus { get; set; }
        public DateTime? ThresholdDate { get; set; }
        public DateTime? ClearDate { get; set; }
        public string Comments { get; set; }
    }
}
