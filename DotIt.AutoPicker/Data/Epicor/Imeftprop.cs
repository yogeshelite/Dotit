using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imeftprop
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int EftheadUid { get; set; }
        public int EftpropUid { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int MaxLength { get; set; }
        public int MinLength { get; set; }
        public int NumDec { get; set; }
        public string Company { get; set; }
        public bool GlobalEftprop { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
