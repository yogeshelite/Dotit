using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BpHoldType
    {
        public string Company { get; set; }
        public string HoldTypeId { get; set; }
        public string SystemCode { get; set; }
        public string ClassName { get; set; }
        public string ObjectNs { get; set; }
        public string DataTableId { get; set; }
        public string Description { get; set; }
        public int HistoryLength { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
