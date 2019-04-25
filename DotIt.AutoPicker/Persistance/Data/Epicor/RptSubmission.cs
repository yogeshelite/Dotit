using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RptSubmission
    {
        public string Company { get; set; }
        public string RptSubmissionId { get; set; }
        public string ReportId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime? SubmittedOn { get; set; }
        public int RptGenerationCounter { get; set; }
        public string Comment { get; set; }
        public string UserCriteria { get; set; }
        public bool Submitted { get; set; }
        public bool SubmitActionUsed { get; set; }
        public int RptSubmissionCtr { get; set; }
        public string LastAction { get; set; }
        public DateTime? ReportDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
