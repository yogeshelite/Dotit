using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RlsLevel
    {
        public string Company { get; set; }
        public string RlsClassCode { get; set; }
        public int LevelSeq { get; set; }
        public int LevelNum { get; set; }
        public string LevLabel { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
