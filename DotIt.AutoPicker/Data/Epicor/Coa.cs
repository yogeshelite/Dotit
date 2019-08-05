using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Coa
    {
        public string Company { get; set; }
        public string Coacode { get; set; }
        public string Description { get; set; }
        public string SeparatorChar { get; set; }
        public string PerBalFmt { get; set; }
        public string TbbalFmt { get; set; }
        public DateTime? FmtChgDate { get; set; }
        public int FmtChgTime { get; set; }
        public string CtrlSegList { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool GlobalCoa { get; set; }
        public bool GlobalLock { get; set; }
        public bool RebuildGlaccts { get; set; }
        public string PesunatCoa { get; set; }
    }
}
