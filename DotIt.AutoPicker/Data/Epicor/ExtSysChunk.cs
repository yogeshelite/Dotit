using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ExtSysChunk
    {
        public string Company { get; set; }
        public int ChunkId { get; set; }
        public int SeqNum { get; set; }
        public string Chunk { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ExtSysChunkDef C { get; set; }
    }
}
