using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ElementDetail
    {
        public string ElementHeaderId { get; set; }
        public int ElementDetailId { get; set; }
        public string ChildTableName { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ElementHeader ElementHeader { get; set; }
    }
}
