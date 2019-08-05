using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class JobAsmblInsp
    {
        public string Company { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int PlanSeq { get; set; }
        public string InspPlanPartNum { get; set; }
        public string InspPlanRevNum { get; set; }
        public string SpecId { get; set; }
        public string SpecRevNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
