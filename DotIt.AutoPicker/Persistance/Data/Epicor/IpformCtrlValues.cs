using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class IpformCtrlValues
    {
        public string ValueMember { get; set; }
        public string ControlId { get; set; }
        public string ParentId { get; set; }
        public string DisplayMember { get; set; }
        public int ValueSeq { get; set; }
        public string FormId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
