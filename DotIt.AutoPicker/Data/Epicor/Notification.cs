using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Notification
    {
        public string Key { get; set; }
        public string Message { get; set; }
        public Guid SenderId { get; set; }
        public DateTime SentOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
