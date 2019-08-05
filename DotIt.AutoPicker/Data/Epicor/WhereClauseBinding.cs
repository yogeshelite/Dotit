using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class WhereClauseBinding
    {
        public WhereClauseBinding()
        {
            WhereClauseToken = new HashSet<WhereClauseToken>();
        }

        public string LikeId { get; set; }
        public string ContextTypeCode { get; set; }
        public string ContextMenuId { get; set; }
        public string CalledFrom { get; set; }
        public string CurrentBinding { get; set; }
        public string SearchTable { get; set; }
        public string SearchTitle { get; set; }
        public string WhereClauseString { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SystemFlag { get; set; }

        public virtual SearchOption SearchOption { get; set; }
        public virtual ICollection<WhereClauseToken> WhereClauseToken { get; set; }
    }
}
