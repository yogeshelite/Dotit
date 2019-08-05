using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class HdtopicParent
    {
        public string Company { get; set; }
        public string TopicId { get; set; }
        public string ParentTopicId { get; set; }
        public int ParentSeqNum { get; set; }
        public bool GlobalHdtopicParent { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
