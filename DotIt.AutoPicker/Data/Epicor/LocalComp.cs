using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class LocalComp
    {
        public string Company { get; set; }
        public string Localization { get; set; }
        public string LocalName { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
