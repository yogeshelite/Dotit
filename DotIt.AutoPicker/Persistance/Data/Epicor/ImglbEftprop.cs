using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbEftprop
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int EftheadUid { get; set; }
        public int EftpropUid { get; set; }
        public int MaxLength { get; set; }
        public int MinLength { get; set; }
        public string Name { get; set; }
        public int NumDec { get; set; }
        public string Type { get; set; }
        public string GlbCompany { get; set; }
        public int GlbEftheadUid { get; set; }
        public int GlbEftpropUid { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalEftprop { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
