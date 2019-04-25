using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Qmmkup
    {
        public string Company { get; set; }
        public string MarkUpId { get; set; }
        public string ClassCode { get; set; }
        public decimal MaterialMarkUp { get; set; }
        public bool GlobalQmmkup { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
