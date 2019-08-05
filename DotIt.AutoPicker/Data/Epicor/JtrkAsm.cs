using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class JtrkAsm
    {
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public string ResourceGrpId { get; set; }
        public string OpCode { get; set; }
        public DateTime? LastDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
