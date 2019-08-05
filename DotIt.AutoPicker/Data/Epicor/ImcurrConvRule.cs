using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImcurrConvRule
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string SourceCurrCode { get; set; }
        public string TargetCurrCode { get; set; }
        public string RateGrpCode { get; set; }
        public bool UseBaseRate { get; set; }
        public int RuleCode { get; set; }
        public bool FixedRate { get; set; }
        public int DisplayMode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
