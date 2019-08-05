using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbHdtopicParent
    {
        public string Company { get; set; }
        public int ParentSeqNum { get; set; }
        public string ParentTopicId { get; set; }
        public string TopicId { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTopicId { get; set; }
        public string GlbParentTopicId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalHdtopicParent { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
