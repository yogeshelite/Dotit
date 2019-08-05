using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class LaunchOption
    {
        public LaunchOption()
        {
            AlternateKey = new HashSet<AlternateKey>();
        }

        public string LikeId { get; set; }
        public string ContextTypeCode { get; set; }
        public string ContextMenuId { get; set; }
        public string CalledFrom { get; set; }
        public bool LaunchModal { get; set; }
        public bool EpiReadOnly { get; set; }
        public bool SuppressPublisher { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SystemFlag { get; set; }
        public int SeqNum { get; set; }
        public string ContextValue { get; set; }

        public virtual ICollection<AlternateKey> AlternateKey { get; set; }
    }
}
