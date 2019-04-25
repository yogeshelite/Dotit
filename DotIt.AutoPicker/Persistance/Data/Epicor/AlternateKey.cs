using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AlternateKey
    {
        public AlternateKey()
        {
            AlternateKeyBinding = new HashSet<AlternateKeyBinding>();
        }

        public string LikeId { get; set; }
        public string ContextTypeCode { get; set; }
        public string ContextMenuId { get; set; }
        public string CalledFrom { get; set; }
        public string CurrentBinding { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SystemFlag { get; set; }
        public int SeqNum { get; set; }
        public string ContextValue { get; set; }

        public virtual LaunchOption LaunchOption { get; set; }
        public virtual ICollection<AlternateKeyBinding> AlternateKeyBinding { get; set; }
    }
}
