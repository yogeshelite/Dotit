using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class HxpbschWrk
    {
        public int Revision { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public DateTime? EstComplDte { get; set; }
        public DateTime? PlanCmplDte { get; set; }
        public string ProjectId { get; set; }
        public string SchWrkId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
