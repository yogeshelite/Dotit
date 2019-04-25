using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imgltracker
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public decimal DebitAmt { get; set; }
        public decimal CreditAmt { get; set; }
        public decimal Cybalance { get; set; }
        public decimal Cpbudget { get; set; }
        public decimal Cybudget { get; set; }
        public decimal CpbudgetPct { get; set; }
        public decimal CybudgetPct { get; set; }
        public decimal Pycpamt { get; set; }
        public decimal Pybalance { get; set; }
        public decimal Pycppct { get; set; }
        public decimal Pypct { get; set; }
        public string BookId { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public int Statistical { get; set; }
        public string StatUomcode { get; set; }
        public decimal DebitStatAmt { get; set; }
        public decimal CreditStatAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal CpstatBudget { get; set; }
        public decimal CystatBudget { get; set; }
        public decimal CpstatBudgetPct { get; set; }
        public decimal CystatBudgetPct { get; set; }
    }
}
