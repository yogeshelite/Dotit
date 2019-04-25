using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class WhtpaymentSubmit
    {
        public string Company { get; set; }
        public string SubmitReportId { get; set; }
        public string Description { get; set; }
        public string Module { get; set; }
        public DateTime? ReportDate { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string Quarter { get; set; }
        public string RptCatCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime? SubmittedOn { get; set; }
        public int ReportStatus { get; set; }
        public string Notes { get; set; }
        public int ReportSequence { get; set; }
        public int EftheadUid { get; set; }
        public string OutputFile { get; set; }
        public bool TestMode { get; set; }
        public string TokenForPreviousQuarter { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int Period { get; set; }
        public string DateSelection { get; set; }
    }
}
