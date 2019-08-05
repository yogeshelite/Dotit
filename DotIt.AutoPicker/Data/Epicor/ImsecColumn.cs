using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImsecColumn
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
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string WriteAllowList { get; set; }
        public string WriteDenyList { get; set; }
        public string ReadAllowList { get; set; }
        public string ReadDenyList { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int CompanyVisibility { get; set; }
        public string Mask { get; set; }
        public string UnmaskedAllowList { get; set; }
        public string UnmaskedDenyList { get; set; }
    }
}
