using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbGlsyst
    {
        public string Company { get; set; }
        public string ExtCompanyId { get; set; }
        public int CurrentFiscalYear { get; set; }
        public int CurrentFiscalPeriod { get; set; }
        public int NumberOfPeriods { get; set; }
        public decimal GlwidgetSize { get; set; }
        public string SalesCategory { get; set; }
        public bool Arinterfaced { get; set; }
        public bool Apinterfaced { get; set; }
        public bool Printerfaced { get; set; }
        public bool PostInvtyWipCos { get; set; }
        public string GjjournalCode { get; set; }
        public bool ArvoucherInvoices { get; set; }
        public bool ApvoucherInvoices { get; set; }
        public bool AllowUnBalancedEntries { get; set; }
        public bool AllowManualGjentries { get; set; }
        public bool ExtGl { get; set; }
        public string GlagingStyle { get; set; }
        public bool BatchGlbalances { get; set; }
        public bool BatchGldailyBal { get; set; }
        public string MasterCoa { get; set; }
        public string MatchDateOption { get; set; }
        public bool MatchUsingCurrentDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
