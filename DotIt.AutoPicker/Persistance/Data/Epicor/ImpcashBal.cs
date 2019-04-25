using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImpcashBal
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string CashDeskId { get; set; }
        public DateTime? Date { get; set; }
        public int CashIssueCount { get; set; }
        public int CashRcptCount { get; set; }
        public string CurrencyCode { get; set; }
        public bool DayIsClosed { get; set; }
        public decimal DocRcvCashAmt { get; set; }
        public decimal RcvCashAmt { get; set; }
        public decimal Rpt1RcvCashAmt { get; set; }
        public decimal Rpt2RcvCashAmt { get; set; }
        public decimal Rpt3RcvCashAmt { get; set; }
        public decimal DocRcvPayrollAmt { get; set; }
        public decimal RcvPayrollAmt { get; set; }
        public decimal Rpt1RcvPayrollAmt { get; set; }
        public decimal Rpt2RcvPayrollAmt { get; set; }
        public decimal Rpt3RcvPayrollAmt { get; set; }
        public decimal DocTotalRcvAmt { get; set; }
        public decimal RcvTotalAmt { get; set; }
        public decimal Rpt1RcvTotalAmt { get; set; }
        public decimal Rpt2RcvTotalAmt { get; set; }
        public decimal Rpt3RcvTotalAmt { get; set; }
        public decimal DocIssCashAmt { get; set; }
        public decimal IssCashAmt { get; set; }
        public decimal Rpt1IssCashAmt { get; set; }
        public decimal Rpt2IssCashAmt { get; set; }
        public decimal Rpt3IssCashAmt { get; set; }
        public decimal DocIssPayrollAmt { get; set; }
        public decimal IssPayrollAmt { get; set; }
        public decimal Rpt1IssPayrollAmt { get; set; }
        public decimal Rpt2IssPayrollAmt { get; set; }
        public decimal Rpt3IssPayrollAmt { get; set; }
        public decimal DocIssTotalAmt { get; set; }
        public decimal IssTotalAmt { get; set; }
        public decimal Rpt1IssTotalAmt { get; set; }
        public decimal Rpt2IssTotalAmt { get; set; }
        public decimal Rpt3IssTotalAmt { get; set; }
        public decimal DocDayBal { get; set; }
        public decimal DayBal { get; set; }
        public decimal Rpt1DayBal { get; set; }
        public decimal Rpt2DayBal { get; set; }
        public decimal Rpt3DayBal { get; set; }
        public decimal DocPayrollDayBal { get; set; }
        public decimal PayrollDayBal { get; set; }
        public decimal Rpt1PayrollDayBal { get; set; }
        public decimal Rpt2PayrollDayBal { get; set; }
        public decimal Rpt3PayrollDayBal { get; set; }
        public decimal DocDayBalWithDraft { get; set; }
        public decimal DayBalWithDraft { get; set; }
        public decimal Rpt1DayBalWithDraft { get; set; }
        public decimal Rpt2DayBalWithDraft { get; set; }
        public decimal Rpt3DayBalWithDraft { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal GainLossBal { get; set; }
        public decimal DocGainLossBal { get; set; }
        public decimal Rpt1GainLossBal { get; set; }
        public decimal Rpt2GainLossBal { get; set; }
        public decimal Rpt3GainLossBal { get; set; }
        public bool PrintedOfficial { get; set; }
    }
}
