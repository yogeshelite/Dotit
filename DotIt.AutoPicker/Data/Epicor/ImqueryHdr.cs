using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImqueryHdr
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string QueryId { get; set; }
        public string AuthorId { get; set; }
        public string Description { get; set; }
        public string DisplayPhrase { get; set; }
        public bool IsGlobal { get; set; }
        public bool IsShared { get; set; }
        public string Version { get; set; }
        public string Cgccode { get; set; }
        public bool Xcompany { get; set; }
        public string GlbCompany { get; set; }
        public bool Updatable { get; set; }
        public bool ExtQuery { get; set; }
        public string ExtDatasourceName { get; set; }
        public bool SystemFlag { get; set; }
        public string Extension { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int CompanyVisibility { get; set; }
        public string SecCode { get; set; }
        public string AppUseCode { get; set; }
        public string AppUseReason { get; set; }
    }
}
