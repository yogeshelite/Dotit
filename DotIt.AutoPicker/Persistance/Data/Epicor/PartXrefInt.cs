using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PartXrefInt
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string XrefPartNum { get; set; }
        public string XrefPartDesc { get; set; }
        public string Snmask { get; set; }
        public string SnmaskExample { get; set; }
        public string SnmaskSuffix { get; set; }
        public string SnmaskPrefix { get; set; }
        public string SnlastUsedSeq { get; set; }
        public bool Snoverride { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
