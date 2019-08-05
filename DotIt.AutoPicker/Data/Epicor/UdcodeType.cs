using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class UdcodeType
    {
        public string Company { get; set; }
        public string CodeTypeId { get; set; }
        public string CodeTypeDesc { get; set; }
        public string LongDesc { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public bool AutoSequence { get; set; }
        public int SequenceId { get; set; }
        public string Cgccode { get; set; }
        public bool GlobalUdcodeType { get; set; }
        public bool GlobalLock { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
