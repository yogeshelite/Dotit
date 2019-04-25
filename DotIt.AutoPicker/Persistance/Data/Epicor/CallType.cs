using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CallType
    {
        public string Company { get; set; }
        public string CallTypeCode { get; set; }
        public string CallTypeDesc { get; set; }
        public bool Inactive { get; set; }
        public bool GlobalCallType { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
