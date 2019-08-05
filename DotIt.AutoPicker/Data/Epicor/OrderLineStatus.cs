using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class OrderLineStatus
    {
        public string Company { get; set; }
        public string StatusCode { get; set; }
        public string Description { get; set; }
        public bool WebEditable { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
