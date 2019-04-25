using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImbankBalDeferred
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
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriod { get; set; }
        public string FiscalCalendarId { get; set; }
        public int DeferredSeq { get; set; }
        public decimal TranAmt { get; set; }
        public decimal DocTranAmt { get; set; }
        public decimal Rpt1TranAmt { get; set; }
        public decimal Rpt2TranAmt { get; set; }
        public decimal Rpt3TranAmt { get; set; }
        public decimal ExchangeRate { get; set; }
        public string SessionId { get; set; }
        public string SessionUserId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string BankBalanceType { get; set; }
        public DateTime? ReconciledRecalcDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
