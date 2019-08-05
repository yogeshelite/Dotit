using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ZkeyField
    {
        public string SystemCode { get; set; }
        public string DataTableId { get; set; }
        public string KeyId { get; set; }
        public int Seq { get; set; }
        public string FieldName { get; set; }
        public string Description { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual Zkey Zkey { get; set; }
    }
}
