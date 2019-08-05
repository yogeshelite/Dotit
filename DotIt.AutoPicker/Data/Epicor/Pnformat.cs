using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Pnformat
    {
        public string Company { get; set; }
        public string FormatId { get; set; }
        public string Description { get; set; }
        public string Filename { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
