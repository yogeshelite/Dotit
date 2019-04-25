using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BpDirective
    {
        public Guid DirectiveId { get; set; }
        public string Source { get; set; }
        public string BpMethodCode { get; set; }
        public int DirectiveType { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public bool IsEnabled { get; set; }
        public int ReenterMax { get; set; }
        public bool PreventDeadloops { get; set; }
        public int VisibilityScope { get; set; }
        public string Company { get; set; }
        public string DirectiveGroup { get; set; }
        public bool IsUpToDate { get; set; }
        public string Cgccode { get; set; }
        public string Body { get; set; }
        public string Thumbnail { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual BpDirectiveType BpDirectiveType { get; set; }
    }
}
