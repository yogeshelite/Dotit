using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class VntgTr
    {
        public string MainTable { get; set; }
        public string RelatedTable { get; set; }
        public bool DirectRelationship { get; set; }
        public string PrimeIndex { get; set; }
        public int PrimeIndexFc { get; set; }
        public string IndexFields { get; set; }
        public string ParentTable { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
