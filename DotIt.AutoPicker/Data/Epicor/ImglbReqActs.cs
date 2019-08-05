using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbReqActs
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public bool Mandatory { get; set; }
        public bool Notify { get; set; }
        public string ReqActionDesc { get; set; }
        public string ReqActionId { get; set; }
        public string ReqActionMessage { get; set; }
        public bool SendToPm { get; set; }
        public string UserList { get; set; }
        public string GlbCompany { get; set; }
        public string GlbReqActionId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalReqActs { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
