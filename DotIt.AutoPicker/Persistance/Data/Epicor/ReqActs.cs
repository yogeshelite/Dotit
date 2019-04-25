using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ReqActs
    {
        public string Company { get; set; }
        public string ReqActionId { get; set; }
        public string ReqActionDesc { get; set; }
        public bool Mandatory { get; set; }
        public bool Notify { get; set; }
        public string UserList { get; set; }
        public bool SendToPm { get; set; }
        public string ReqActionMessage { get; set; }
        public bool GlobalReqActs { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
