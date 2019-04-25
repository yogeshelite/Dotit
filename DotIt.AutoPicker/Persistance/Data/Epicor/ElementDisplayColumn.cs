using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ElementDisplayColumn
    {
        public string ElementHeaderId { get; set; }
        public int ElementDisplayColumnId { get; set; }
        public string ParentColumnName { get; set; }
        public string DataType { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ElementHeader ElementHeader { get; set; }
    }
}
