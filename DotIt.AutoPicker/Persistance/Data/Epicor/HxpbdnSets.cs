using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class HxpbdnSets
    {
        public int Revision { get; set; }
        public string BdnSetId { get; set; }
        public string Company { get; set; }
        public bool HasChanges { get; set; }
        public string ProjectId { get; set; }
        public int Seq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
