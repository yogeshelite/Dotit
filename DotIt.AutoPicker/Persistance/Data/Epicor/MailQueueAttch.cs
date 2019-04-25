using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class MailQueueAttch
    {
        public long QueueNum { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
