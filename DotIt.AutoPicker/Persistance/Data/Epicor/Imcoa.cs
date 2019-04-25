using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imcoa
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
