using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PcPageExpr
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int PageSeq { get; set; }
        public string ConfigId { get; set; }
        public int SeqNum { get; set; }
        public string TypeCode { get; set; }
        public string Expression { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
