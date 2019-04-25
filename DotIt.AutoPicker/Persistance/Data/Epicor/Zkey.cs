using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Zkey
    {
        public Zkey()
        {
            ZkeyField = new HashSet<ZkeyField>();
        }

        public string SystemCode { get; set; }
        public string DataTableId { get; set; }
        public string KeyId { get; set; }
        public string Description { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool SystemFlag { get; set; }
        public bool External { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ZdataTable ZdataTable { get; set; }
        public virtual ICollection<ZkeyField> ZkeyField { get; set; }
    }
}
