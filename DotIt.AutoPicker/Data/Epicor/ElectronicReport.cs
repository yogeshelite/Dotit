using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ElectronicReport
    {
        public string Company { get; set; }
        public int EftheadUid { get; set; }
        public string OutputFile { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string IntrastatDispatchFileName { get; set; }
    }
}
