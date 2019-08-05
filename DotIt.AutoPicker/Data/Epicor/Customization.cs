using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Customization
    {
        public string Type { get; set; }
        public string Target { get; set; }
        public string Scope { get; set; }
        public string Project { get; set; }
        public bool Disabled { get; set; }
        public int Revision { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Assembly { get; set; }
        public string Version { get; set; }
        public string TypeName { get; set; }
        public bool SystemFlag { get; set; }
    }
}
