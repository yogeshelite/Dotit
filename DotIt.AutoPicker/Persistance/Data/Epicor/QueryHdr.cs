using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class QueryHdr
    {
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
