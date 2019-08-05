using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BpActionQueueData
    {
        public Guid ForeignSysRowId { get; set; }
        public int ChunkOrder { get; set; }
        public string ActionData { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
