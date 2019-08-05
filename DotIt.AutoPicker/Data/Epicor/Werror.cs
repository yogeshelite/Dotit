using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Werror
    {
        public int ErrorUid { get; set; }
        public int RvJrnTrUid { get; set; }
        public string Description { get; set; }
        public bool IsError { get; set; }
        public string Company { get; set; }
        public int RvJrnUid { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool Persistent { get; set; }
    }
}
