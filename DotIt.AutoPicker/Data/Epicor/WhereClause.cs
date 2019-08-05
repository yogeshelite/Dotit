using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class WhereClause
    {
        public string Company { get; set; }
        public string SearchForm { get; set; }
        public string Nsid { get; set; }
        public string UserId { get; set; }
        public string CalledFrom { get; set; }
        public string TableName { get; set; }
        public string WhereClause1 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
