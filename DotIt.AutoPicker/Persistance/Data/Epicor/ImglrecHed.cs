using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglrecHed
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int RecurNum { get; set; }
        public string Description { get; set; }
        public decimal TotDebit { get; set; }
        public decimal TotCredit { get; set; }
        public bool Reverse { get; set; }
        public bool ActiveEntry { get; set; }
        public string SelectedPeriodList { get; set; }
        public string JournalCode { get; set; }
        public string BookMode { get; set; }
        public string CurrencyCode { get; set; }
        public string RateGrpCode { get; set; }
        public string Coacode { get; set; }
        public string GroupPrefix { get; set; }
        public string BookId { get; set; }
        public string StatUomcode { get; set; }
        public string FiscalCalendarId { get; set; }
        public decimal DebitStatAmt { get; set; }
        public DateTime? ReverseDate { get; set; }
        public decimal CreditStatAmt { get; set; }
        public bool CorrAccounting { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
