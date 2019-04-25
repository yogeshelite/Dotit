using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ExtSysChunkDef
    {
        public ExtSysChunkDef()
        {
            ExtSysChunk = new HashSet<ExtSysChunk>();
        }

        public string Company { get; set; }
        public int ChunkId { get; set; }
        public string ExtSystemId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string UpdateSource { get; set; }
        public string UpdateAction { get; set; }

        public virtual ICollection<ExtSysChunk> ExtSysChunk { get; set; }
    }
}
