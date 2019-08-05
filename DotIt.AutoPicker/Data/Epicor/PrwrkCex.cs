using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PrwrkCex
    {
        public string Company { get; set; }
        public string WorkCompCode { get; set; }
        public string PayTypeId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
