using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PerfData
    {
        public string Company { get; set; }
        public string DatasetName { get; set; }
        public string Dimensions { get; set; }
        public string Facts { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
