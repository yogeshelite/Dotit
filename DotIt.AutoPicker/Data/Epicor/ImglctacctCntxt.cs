using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglctacctCntxt
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GlcontrolType { get; set; }
        public int GlctacctNum { get; set; }
        public string GlacctContext { get; set; }
        public string BookId { get; set; }
        public bool Required { get; set; }
        public bool AllBooks { get; set; }
        public bool UseMasterChart { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
