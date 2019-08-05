using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QueryUpdateField
    {
        public string Company { get; set; }
        public string QueryId { get; set; }
        public string MapTableName { get; set; }
        public string MapFieldName { get; set; }
        public bool Direction { get; set; }
        public string Expression { get; set; }
        public bool IsKeyField { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string NetDataType { get; set; }
    }
}
