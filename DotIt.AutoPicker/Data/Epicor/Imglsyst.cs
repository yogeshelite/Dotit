using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imglsyst
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
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
        public string MasterCoa { get; set; }
        public bool BatchGlbalances { get; set; }
        public bool BatchGldailyBal { get; set; }
        public bool MatchUsingCurrentDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string DefaultBookMode { get; set; }
        public string GjjournalCodeOpen { get; set; }
        public string GjjournalCodeClose { get; set; }
        public string TaxEntryMode { get; set; }
        public string DefaultTaxLiability { get; set; }
        public string DefaultTaxType { get; set; }
        public bool KeepRevisionHistory { get; set; }
    }
}
