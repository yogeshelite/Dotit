using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Ingstr2report
    {
        public string Company { get; set; }
        public string ReportId { get; set; }
        public string FinancialPeriod { get; set; }
        public string Description { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public string ConfirmedBy { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public bool SkipInvoices { get; set; }
        public string ReportNotes { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
