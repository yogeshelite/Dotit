using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImbaqextDatasource
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string DatasourceName { get; set; }
        public string Description { get; set; }
        public string DatasourceType { get; set; }
        public string ProviderType { get; set; }
        public string ConnectionString { get; set; }
        public string TokenServerUrl { get; set; }
        public string TokenServerClientId { get; set; }
        public string TokenServerClientSecret { get; set; }
        public int? QueryMaxResultSet { get; set; }
        public int? QueryTimeOut { get; set; }
        public string Settings { get; set; }
        public int CompanyVisibility { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
