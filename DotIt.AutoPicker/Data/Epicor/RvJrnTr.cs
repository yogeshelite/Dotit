using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RvJrnTr
    {
        public int RvJrnTrUid { get; set; }
        public int RvJrnUid { get; set; }
        public string BookId { get; set; }
        public bool IsValid { get; set; }
        public bool IsReverse { get; set; }
        public int TranNum { get; set; }
        public int LegalNum { get; set; }
        public string Description { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal DebitAmount { get; set; }
        public string JournalCode { get; set; }
        public string UserUid { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public string Coacode { get; set; }
        public decimal BookCreditAmount { get; set; }
        public decimal BookDebitAmount { get; set; }
        public string Company { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public DateTime? Jedate { get; set; }
        public DateTime? PostedDate { get; set; }
        public int ActrevisionUid { get; set; }
        public int ActtypeUid { get; set; }
        public string Abtuid { get; set; }
        public bool Simulation { get; set; }
        public string StatUomcode { get; set; }
        public decimal DebitStatAmt { get; set; }
        public decimal CreditStatAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
