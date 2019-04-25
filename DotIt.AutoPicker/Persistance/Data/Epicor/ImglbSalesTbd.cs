using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbSalesTbd
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string CountryName { get; set; }
        public int CountryNum { get; set; }
        public string EndZip { get; set; }
        public string StartZip { get; set; }
        public string State { get; set; }
        public string TerritoryId { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTerritoryId { get; set; }
        public int GlbCountryNum { get; set; }
        public string GlbState { get; set; }
        public string GlbStartZip { get; set; }
        public string GlbEndZip { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalSalesTbd { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
