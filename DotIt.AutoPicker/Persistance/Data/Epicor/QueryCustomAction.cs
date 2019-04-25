using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class QueryCustomAction
    {
        public string Company { get; set; }
        public string QueryId { get; set; }
        public string ActionId { get; set; }
        public string ActionLabel { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
