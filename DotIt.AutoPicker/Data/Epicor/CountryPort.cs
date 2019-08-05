using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CountryPort
    {
        public string Company { get; set; }
        public int CountryNum { get; set; }
        public string PortId { get; set; }
        public string Description { get; set; }
        public bool DefaultPort { get; set; }
        public bool GlobalCountryPort { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
