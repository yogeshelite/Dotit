using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imtip
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string MfgSys { get; set; }
        public int TipNum { get; set; }
        public bool Active { get; set; }
        public string TipTitle { get; set; }
        public string TipText { get; set; }
        public int ShowNum { get; set; }
        public bool SystemFlag { get; set; }
        public int CompanyVisibility { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
