using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AlternateKeyLike
    {
        public string LikeId { get; set; }
        public string ContextTypeCode { get; set; }
        public string ContextMenuId { get; set; }
        public string LikeField { get; set; }
        public int SeqNum { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ContextMenuItem ContextMenuItem { get; set; }
    }
}
