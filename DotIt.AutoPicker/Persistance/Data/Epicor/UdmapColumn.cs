using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class UdmapColumn
    {
        public int MapTableId { get; set; }
        public int Seq { get; set; }
        public string TargetColumnName { get; set; }
        public string SourceColumnName { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual UdmapTable MapTable { get; set; }
    }
}
