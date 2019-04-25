using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class WebPersonalization
    {
        public string WebResourceId { get; set; }
        public string UserId { get; set; }
        public string Properties { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual SysUserFile User { get; set; }
        public virtual WebResource WebResource { get; set; }
    }
}
