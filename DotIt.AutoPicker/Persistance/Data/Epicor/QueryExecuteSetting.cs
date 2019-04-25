using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class QueryExecuteSetting
    {
        public string Company { get; set; }
        public string QueryId { get; set; }
        public string SettingId { get; set; }
        public string SettingValue { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
