using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ProductVersion
    {
        public string SystemCode { get; set; }
        public string SystemVersion { get; set; }
        public decimal ReleaseOrder { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
