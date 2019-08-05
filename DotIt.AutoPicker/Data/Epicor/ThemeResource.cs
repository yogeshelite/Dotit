using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ThemeResource
    {
        public string ThemeId { get; set; }
        public string ResourceType { get; set; }
        public string ResourceName { get; set; }
        public string Resource { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] BinaryResource { get; set; }

        public virtual Theme Theme { get; set; }
    }
}
