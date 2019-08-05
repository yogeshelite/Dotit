using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SysCubeDim
    {
        public string Company { get; set; }
        public string CubeId { get; set; }
        public int DimNum { get; set; }
        public string DimensionId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
