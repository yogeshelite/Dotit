using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PcStrComp
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
        public int SmartStringStart { get; set; }
        public int SmartStringEnd { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
