using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImquickSearch
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string QuickSearchId { get; set; }
        public string GlbCompany { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public string ExportId { get; set; }
        public string LikeDataFieldTableId { get; set; }
        public string LikeDataFieldName { get; set; }
        public bool GlobalSearch { get; set; }
        public bool ForValidation { get; set; }
        public bool IsShared { get; set; }
        public bool SystemFlag { get; set; }
        public string ReturnFieldTableId { get; set; }
        public string ReturnFieldName { get; set; }
        public string CallFrom { get; set; }
        public bool ContextDefault { get; set; }
        public bool BaseDefault { get; set; }
        public string Version { get; set; }
        public string HotKey { get; set; }
        public string Cgccode { get; set; }
        public bool IsPredictive { get; set; }
        public string SourceSystemCode { get; set; }
        public string SourceTableId { get; set; }
        public string SourceFieldName { get; set; }
        public string SearchOnFieldSystemCode { get; set; }
        public string SearchOnFieldTableId { get; set; }
        public string SearchOnFieldName { get; set; }
        public bool SuppressBaseSearch { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
