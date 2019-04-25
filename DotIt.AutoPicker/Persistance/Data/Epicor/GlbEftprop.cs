using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbEftprop
    {
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
