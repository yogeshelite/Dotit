using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class MschedRelItem
    {
        public string Company { get; set; }
        public string BatchJobNum { get; set; }
        public string JobNum { get; set; }
        public string ParentJobNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual MschedItem MschedItem { get; set; }
    }
}
