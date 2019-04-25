using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class HxpphaseOper
    {
        public int Revision { get; set; }
        public string Company { get; set; }
        public decimal EstHours { get; set; }
        public string OpCode { get; set; }
        public string PhaseId { get; set; }
        public string ProjectId { get; set; }
        public string RoleCd { get; set; }
        public int Seq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
