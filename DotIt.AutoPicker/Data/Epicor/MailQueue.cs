using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class MailQueue
    {
        public long QueueNum { get; set; }
        public string Company { get; set; }
        public string UserId { get; set; }
        public Guid? SessionId { get; set; }
        public int AttemptCounter { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
