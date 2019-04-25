using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SysTaskLog
    {
        public long SysTaskNum { get; set; }
        public int EntryNum { get; set; }
        public DateTime? EnteredOn { get; set; }
        public bool IsError { get; set; }
        public string MsgText { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string MsgType { get; set; }

        public virtual SysTask SysTaskNumNavigation { get; set; }
    }
}
