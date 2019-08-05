using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class MktgAct
    {
        public string Company { get; set; }
        public string ActivityType { get; set; }
        public string ActivityDescription { get; set; }
        public bool Inactive { get; set; }
        public bool GlobalMktgAct { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
