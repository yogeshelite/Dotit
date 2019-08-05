using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImbaqextDsTableFilter
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string DatasourceType { get; set; }
        public Guid FilterId { get; set; }
        public int Seq { get; set; }
        public string AndOr { get; set; }
        public bool Neg { get; set; }
        public string LeftP { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string RightP { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
