using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class OperParamHead
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string MachResourceId { get; set; }
        public string ToolResourceId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
