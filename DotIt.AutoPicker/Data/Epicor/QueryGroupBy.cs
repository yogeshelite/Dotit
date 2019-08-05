using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QueryGroupBy
    {
        public string Company { get; set; }
        public string QueryId { get; set; }
        public Guid SubQueryId { get; set; }
        public Guid GroupById { get; set; }
        public string Expression { get; set; }
        public int Seq { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
