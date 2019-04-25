using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class QueryValueSetItems
    {
        public string Company { get; set; }
        public string QueryId { get; set; }
        public string ValueSetId { get; set; }
        public string ItemValue { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
