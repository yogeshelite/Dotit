using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class MapBook
    {
        public string Company { get; set; }
        public int LinkId { get; set; }
        public string TrgBook { get; set; }
        public string SrcBook { get; set; }
        public int TranCurr { get; set; }
        public int CoamapUid { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
