using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ReqLog
    {
        public string Company { get; set; }
        public int ReqNum { get; set; }
        public string ReqActionId { get; set; }
        public string CurrDispatcherId { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public bool Approved { get; set; }
        public string OldActionId { get; set; }
        public string ReqLogType { get; set; }
        public bool CurrentAction { get; set; }
        public string StatusType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
