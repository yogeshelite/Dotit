using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BpArgument
    {
        public string Source { get; set; }
        public string BpMethodCode { get; set; }
        public int Order { get; set; }
        public string BpArgumentName { get; set; }
        public string Type { get; set; }
        public string Direction { get; set; }
        public string TypeInfo { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
