using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AlternateKeyBinding
    {
        public string LikeId { get; set; }
        public string ContextTypeCode { get; set; }
        public string ContextMenuId { get; set; }
        public string CalledFrom { get; set; }
        public string CurrentBinding { get; set; }
        public string AlternateKeyBinding1 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int SeqNum { get; set; }
        public bool SystemFlag { get; set; }

        public virtual AlternateKey AlternateKey { get; set; }
    }
}
