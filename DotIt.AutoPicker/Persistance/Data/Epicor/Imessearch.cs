using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imessearch
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string SearchId { get; set; }
        public string Baqid { get; set; }
        public string GlbCompany { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public string LikeDataFieldTableId { get; set; }
        public string LikeDataFieldName { get; set; }
        public bool GlobalSearch { get; set; }
        public bool IsShared { get; set; }
        public bool SystemFlag { get; set; }
        public string CallFrom { get; set; }
        public bool ContextDefault { get; set; }
        public bool BaseDefault { get; set; }
        public string Version { get; set; }
        public string Cgccode { get; set; }
        public string SortColumn { get; set; }
        public bool SortDescending { get; set; }
        public int PageSize { get; set; }
        public string ReturnFieldTableId { get; set; }
        public string ReturnFieldName { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
