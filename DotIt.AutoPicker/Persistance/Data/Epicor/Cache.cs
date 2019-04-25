using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Cache
    {
        public string CacheKey { get; set; }
        public byte[] Value { get; set; }
        public DateTime ExpiresOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
