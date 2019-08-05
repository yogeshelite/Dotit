using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ExtFinAnlsCd
    {
        public string Company { get; set; }
        public string InternalCode { get; set; }
        public string Description { get; set; }
        public string AnalysisCode { get; set; }
        public string AnalysisCode2 { get; set; }
        public string Xblrtag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
