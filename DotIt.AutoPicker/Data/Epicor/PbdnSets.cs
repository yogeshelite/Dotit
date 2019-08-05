using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PbdnSets
    {
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public string BdnSetId { get; set; }
        public bool HasChanges { get; set; }
        public int Seq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
