using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbAnalysisCd
    {
        public bool Active { get; set; }
        public string AnalysisCode { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public bool InActive { get; set; }
        public bool JobAsm { get; set; }
        public bool Material { get; set; }
        public bool Operation { get; set; }
        public string GlbCompany { get; set; }
        public string GlbAnalysisCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalAnalysisCd { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
