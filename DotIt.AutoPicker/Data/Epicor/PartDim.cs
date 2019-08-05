using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PartDim
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string DimCode { get; set; }
        public string DimCodeDescription { get; set; }
        public string Dum { get; set; }
        public decimal DimConvFactor { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
