using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Zsystem
    {
        public Zsystem()
        {
            ContextType = new HashSet<ContextType>();
            Zbodef = new HashSet<Zbodef>();
            ZdataSet = new HashSet<ZdataSet>();
            ZdataTable = new HashSet<ZdataTable>();
        }

        public string SystemCode { get; set; }
        public string Description { get; set; }
        public string DbschemaName { get; set; }
        public string DataContextType { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<ContextType> ContextType { get; set; }
        public virtual ICollection<Zbodef> Zbodef { get; set; }
        public virtual ICollection<ZdataSet> ZdataSet { get; set; }
        public virtual ICollection<ZdataTable> ZdataTable { get; set; }
    }
}
