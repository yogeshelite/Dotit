using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImvntgTr
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
