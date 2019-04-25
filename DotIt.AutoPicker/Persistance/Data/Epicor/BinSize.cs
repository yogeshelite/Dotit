using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BinSize
    {
        public string Company { get; set; }
        public string SizeId { get; set; }
        public decimal BinLength { get; set; }
        public decimal BinWidth { get; set; }
        public decimal BinHeight { get; set; }
        public string SizeUom { get; set; }
        public decimal BinVolume { get; set; }
        public string VolumeUom { get; set; }
        public bool Inactive { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
