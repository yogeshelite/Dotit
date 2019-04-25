using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class QueryCtrlValues
    {
        public string Company { get; set; }
        public string QueryId { get; set; }
        public string ControlId { get; set; }
        public string Id { get; set; }
        public string Val { get; set; }
        public int Seq { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
