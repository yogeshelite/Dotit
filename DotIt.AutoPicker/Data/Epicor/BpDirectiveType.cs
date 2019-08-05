using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BpDirectiveType
    {
        public BpDirectiveType()
        {
            BpDirective = new HashSet<BpDirective>();
        }

        public string Source { get; set; }
        public int DirectiveType { get; set; }
        public string Name { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<BpDirective> BpDirective { get; set; }
    }
}
