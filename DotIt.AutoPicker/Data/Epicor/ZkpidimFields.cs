using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ZkpidimFields
    {
        public string SystemCode { get; set; }
        public bool ValidForKpi { get; set; }
        public string DimensionName { get; set; }
        public string DimFieldName { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
