using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class LegalNumSeq
    {
        public string Company { get; set; }
        public int TransYear { get; set; }
        public string TransYearSuffix { get; set; }
        public string Prefix { get; set; }
        public int TransPeriod { get; set; }
        public int NumberSeq { get; set; }
        public int AvailFolios { get; set; }
        public int UsedFolios { get; set; }
        public int StartSequence { get; set; }
        public int EndSequence { get; set; }
        public string PeriodPrefix { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string AgtableName { get; set; }
        public int AginvoiceNum { get; set; }
        public int MxapprovalNum { get; set; }
        public int MxapprovalYear { get; set; }
    }
}
