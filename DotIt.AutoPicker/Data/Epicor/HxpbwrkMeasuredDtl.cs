using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class HxpbwrkMeasuredDtl
    {
        public int Revision { get; set; }
        public decimal ActAmount { get; set; }
        public string ActNotes { get; set; }
        public string ActStatus { get; set; }
        public decimal ApprovalAmt { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string Company { get; set; }
        public DateTime? CustApprovalDate { get; set; }
        public DateTime? DateonSite { get; set; }
        public string Description { get; set; }
        public decimal DocActAmount { get; set; }
        public decimal DocApprovalAmt { get; set; }
        public int DtlSeq { get; set; }
        public string IssueNotes { get; set; }
        public string MeasuredWorkId { get; set; }
        public int PbinvNum { get; set; }
        public string ProjectId { get; set; }
        public string QtySurveyor { get; set; }
        public decimal Rpt1ActAmount { get; set; }
        public decimal Rpt1ApprovalAmt { get; set; }
        public decimal Rpt2ActAmount { get; set; }
        public decimal Rpt2ApprovalAmt { get; set; }
        public decimal Rpt3ActAmount { get; set; }
        public decimal Rpt3ApprovalAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
