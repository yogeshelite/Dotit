using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BaqrptSort
    {
        public string Company { get; set; }
        public string BaqrptId { get; set; }
        public string SortId { get; set; }
        public bool SystemFlag { get; set; }
        public bool IsDefault { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
