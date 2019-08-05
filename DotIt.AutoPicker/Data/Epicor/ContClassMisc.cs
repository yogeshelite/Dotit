using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ContClassMisc
    {
        public string Company { get; set; }
        public string ClassCode { get; set; }
        public string MiscCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
