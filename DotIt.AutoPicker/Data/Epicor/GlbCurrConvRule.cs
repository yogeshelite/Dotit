using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbCurrConvRule
    {
        public string Company { get; set; }
        public string SourceCurrCode { get; set; }
        public string TargetCurrCode { get; set; }
        public string RateGrpCode { get; set; }
        public bool UseBaseRate { get; set; }
        public int RuleCode { get; set; }
        public bool FixedRate { get; set; }
        public string GlbRateGrpCode { get; set; }
        public string GlbSourceCurrCode { get; set; }
        public string GlbTargetCurrCode { get; set; }
        public string GlbCompany { get; set; }
        public int DisplayMode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
