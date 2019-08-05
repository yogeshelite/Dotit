using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbMktgAct
    {
        public string ActivityDescription { get; set; }
        public string ActivityType { get; set; }
        public string Company { get; set; }
        public bool Inactive { get; set; }
        public string GlbCompany { get; set; }
        public string GlbActivityType { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalMktgAct { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
