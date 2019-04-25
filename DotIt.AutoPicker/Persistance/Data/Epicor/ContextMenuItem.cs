using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ContextMenuItem
    {
        public ContextMenuItem()
        {
            AlternateKeyLike = new HashSet<AlternateKeyLike>();
        }

        public string LikeId { get; set; }
        public string ContextTypeCode { get; set; }
        public string ContextMenuId { get; set; }
        public string ContextMenuText { get; set; }
        public string ProcessCall { get; set; }
        public string ProcessType { get; set; }
        public string MenuId { get; set; }
        public string AdapterId { get; set; }
        public string SearchMode { get; set; }
        public string TrackerId { get; set; }
        public bool Qsvalidation { get; set; }
        public bool QsbaseDefault { get; set; }
        public bool QscontextDefault { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int MenuOrder { get; set; }
        public bool MenuEnabled { get; set; }
        public bool SystemFlag { get; set; }
        public string QueryId { get; set; }

        public virtual ContextMenu ContextMenu { get; set; }
        public virtual ICollection<AlternateKeyLike> AlternateKeyLike { get; set; }
    }
}
