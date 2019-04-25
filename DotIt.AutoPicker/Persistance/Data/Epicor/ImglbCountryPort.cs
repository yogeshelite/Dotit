using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbCountryPort
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int CountryNum { get; set; }
        public bool DefaultPort { get; set; }
        public string Description { get; set; }
        public string PortId { get; set; }
        public string GlbCompany { get; set; }
        public int GlbCountryNum { get; set; }
        public string GlbPortId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalCountryPort { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
