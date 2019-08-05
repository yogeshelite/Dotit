using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ExtPrexportSrcTbl
    {
        public ExtPrexportSrcTbl()
        {
            ExtPrexportSeq = new HashSet<ExtPrexportSeq>();
            ExtPrexportSrcFld = new HashSet<ExtPrexportSrcFld>();
        }

        public string Company { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<ExtPrexportSeq> ExtPrexportSeq { get; set; }
        public virtual ICollection<ExtPrexportSrcFld> ExtPrexportSrcFld { get; set; }
    }
}
