using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Abthead
    {
        public string Abtuid { get; set; }
        public int ActrevisionUid { get; set; }
        public string Company { get; set; }
        public string GroupId { get; set; }
        public bool InHistory { get; set; }
        public string DocUid { get; set; }
        public int ActtypeUid { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
