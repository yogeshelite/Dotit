using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class MemoCatRelatedToTable
    {
        public string RelatedToSchemaName { get; set; }
        public string RelatedToTableName { get; set; }
        public string RelatedToTableDesc { get; set; }
        public string SystemCode { get; set; }
        public string Module { get; set; }
        public string Company { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
