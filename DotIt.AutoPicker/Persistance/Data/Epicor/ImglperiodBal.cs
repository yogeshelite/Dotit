using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglperiodBal
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string BookId { get; set; }
        public string BalanceAcct { get; set; }
        public string BalanceType { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public decimal CarryForwardBalance { get; set; }
        public decimal OpenBalance { get; set; }
        public decimal BalanceAmt { get; set; }
        public decimal DebitAmt { get; set; }
        public decimal CreditAmt { get; set; }
        public string SegValue1 { get; set; }
        public string SegValue2 { get; set; }
        public string SegValue3 { get; set; }
        public string SegValue4 { get; set; }
        public string SegValue5 { get; set; }
        public string SegValue6 { get; set; }
        public string SegValue7 { get; set; }
        public string SegValue8 { get; set; }
        public string SegValue9 { get; set; }
        public string SegValue10 { get; set; }
        public string SegValue11 { get; set; }
        public string SegValue12 { get; set; }
        public string SegValue13 { get; set; }
        public string SegValue14 { get; set; }
        public string SegValue15 { get; set; }
        public string SegValue16 { get; set; }
        public string SegValue17 { get; set; }
        public string SegValue18 { get; set; }
        public string SegValue19 { get; set; }
        public string SegValue20 { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal BalanceStatAmt { get; set; }
        public decimal DebitStatAmt { get; set; }
        public decimal CreditStatAmt { get; set; }
        public decimal OpenBalanceStatAmt { get; set; }
        public decimal CarryForwardBalanceStatAmt { get; set; }
    }
}
