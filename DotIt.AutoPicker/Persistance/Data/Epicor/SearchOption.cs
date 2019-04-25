using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SearchOption
    {
        public SearchOption()
        {
            WhereClauseBinding = new HashSet<WhereClauseBinding>();
        }

        public string LikeId { get; set; }
        public string ContextTypeCode { get; set; }
        public string ContextMenuId { get; set; }
        public string CalledFrom { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SystemFlag { get; set; }

        public virtual ICollection<WhereClauseBinding> WhereClauseBinding { get; set; }
    }
}
