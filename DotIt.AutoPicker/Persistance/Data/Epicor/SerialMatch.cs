using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SerialMatch
    {
        public string Company { get; set; }
        public string ParentPartNum { get; set; }
        public string ParentSerialNo { get; set; }
        public string ChildPartNum { get; set; }
        public string ChildSerialNo { get; set; }
        public DateTime? DateMatched { get; set; }
        public bool ChildIsAssembly { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
