using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class IdnumCnfgSeq
    {
        public string Company { get; set; }
        public string FormatId { get; set; }
        public string DefaultPrefix { get; set; }
        public int TransYear { get; set; }
        public int StartSequence { get; set; }
        public int EndSequence { get; set; }
        public bool Active { get; set; }
        public int NumberSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual IdnumCnfg IdnumCnfg { get; set; }
    }
}
