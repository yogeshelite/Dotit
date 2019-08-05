using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class UdmapTable
    {
        public UdmapTable()
        {
            UdmapColumn = new HashSet<UdmapColumn>();
        }

        public int MapTableId { get; set; }
        public int MapId { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public bool IsEnabled { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual Udmap Map { get; set; }
        public virtual ICollection<UdmapColumn> UdmapColumn { get; set; }
    }
}
