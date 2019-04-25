using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Pager
    {
        public string ConnId { get; set; }
        public string CacheToken { get; set; }
        public string FilePath { get; set; }
        public DateTime? LastAccessDate { get; set; }
        public int LastAccessTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
