using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbAlert
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int Alertnum { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool Memo { get; set; }
        public bool AlertFlag { get; set; }
        public string AlertText { get; set; }
        public string EmailAddr { get; set; }
        public string EmailCc { get; set; }
        public string EmailFromAddr { get; set; }
        public string EmailFromLabel { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
