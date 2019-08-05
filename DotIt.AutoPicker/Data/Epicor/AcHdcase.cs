using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcHdcase
    {
        public string Company { get; set; }
        public int HdcaseNum { get; set; }
        public bool CreatedInError { get; set; }
        public int CarePlanNum { get; set; }
        public string CarePlanType { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string InputName { get; set; }
        public string PcjobNum { get; set; }
        public DateTime? ProposedStrtDate { get; set; }
        public bool IsServiceCase { get; set; }
        public DateTime? CaseDate { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public string CaseCode { get; set; }
        public DateTime? NextReviewDate { get; set; }
        public string EvaluationStatus { get; set; }
        public string ChildCases { get; set; }
        public bool Inactive { get; set; }
    }
}
