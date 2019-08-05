using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BpInstanceCounter
    {
        public string Company { get; set; }
        public string BpMethodCode { get; set; }
        public int DirectiveType { get; set; }
        public Guid DirectiveId { get; set; }
        public string UserCode { get; set; }
        public int Number { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
