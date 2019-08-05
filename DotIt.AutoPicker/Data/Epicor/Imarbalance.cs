using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imarbalance
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
        public int InvoiceNum { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriod { get; set; }
        public int CustNum { get; set; }
        public string CurrencyCode { get; set; }
        public string LegalNumber { get; set; }
        public string Coacode { get; set; }
        public string Glaccount { get; set; }
        public string FiscalCalendarId { get; set; }
        public decimal OpenBalance { get; set; }
        public decimal DocOpenBalance { get; set; }
        public decimal Rpt1OpenBalance { get; set; }
        public decimal Rpt2OpenBalance { get; set; }
        public decimal Rpt3OpenBalance { get; set; }
        public decimal MovementAmt { get; set; }
        public decimal DocMovementAmt { get; set; }
        public decimal Rpt1MovementAmt { get; set; }
        public decimal Rpt2MovementAmt { get; set; }
        public decimal Rpt3MovementAmt { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string Subledger { get; set; }
        public string RelatedToSchemaName { get; set; }
        public string RelatedToTable { get; set; }
        public Guid RelatedToSysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool Closed { get; set; }
    }
}
