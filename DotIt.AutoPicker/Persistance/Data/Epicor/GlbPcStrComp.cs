using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbPcStrComp
    {
        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int PosOrder { get; set; }
        public string CompName { get; set; }
        public string CompType { get; set; }
        public string CompDataType { get; set; }
        public string DisplayFormat { get; set; }
        public string SourceDbrecid { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPartNum { get; set; }
        public string GlbRevisionNum { get; set; }
        public int SmartStringEnd { get; set; }
        public int SmartStringStart { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
