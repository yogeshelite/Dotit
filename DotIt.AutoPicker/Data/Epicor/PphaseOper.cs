using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PphaseOper
    {
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public string PhaseId { get; set; }
        public string OpCode { get; set; }
        public int Seq { get; set; }
        public decimal EstHours { get; set; }
        public string RoleCd { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
