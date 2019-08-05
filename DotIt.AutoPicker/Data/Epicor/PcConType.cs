using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PcConType
    {
        public string Company { get; set; }
        public string TypeCode { get; set; }
        public string TypeDesc { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
