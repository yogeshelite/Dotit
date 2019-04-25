using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BpActionQueue
    {
        public string Company { get; set; }
        public int QueueNum { get; set; }
        public string ActionType { get; set; }
        public string SessionId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int AttemptCounter { get; set; }
    }
}
