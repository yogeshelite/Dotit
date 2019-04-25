using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Udcodes
    {
        public string Company { get; set; }
        public string CodeTypeId { get; set; }
        public string CodeId { get; set; }
        public bool IsActive { get; set; }
        public string CodeDesc { get; set; }
        public string LongDesc { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public bool GlobalUdcodes { get; set; }
        public bool GlobalLock { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
