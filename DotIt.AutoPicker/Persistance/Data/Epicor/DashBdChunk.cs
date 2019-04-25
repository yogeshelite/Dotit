using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class DashBdChunk
    {
        public string Company { get; set; }
        public string ProductId { get; set; }
        public string GlbCompany { get; set; }
        public string DefinitionId { get; set; }
        public int SeqNum { get; set; }
        public string Chunk { get; set; }
        public string Cgccode { get; set; }
        public bool Deployed { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
