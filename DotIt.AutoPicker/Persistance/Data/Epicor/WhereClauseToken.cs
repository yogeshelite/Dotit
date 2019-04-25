using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class WhereClauseToken
    {
        public string LikeId { get; set; }
        public string ContextTypeCode { get; set; }
        public string ContextMenuId { get; set; }
        public string CalledFrom { get; set; }
        public string CurrentBinding { get; set; }
        public string BindingToken { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int SeqNum { get; set; }
        public bool SystemFlag { get; set; }

        public virtual WhereClauseBinding WhereClauseBinding { get; set; }
    }
}
