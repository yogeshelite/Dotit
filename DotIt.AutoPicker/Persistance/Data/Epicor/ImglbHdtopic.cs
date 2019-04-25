using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbHdtopic
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public bool CaseTopic { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public bool MaintIssue { get; set; }
        public bool MaintRes { get; set; }
        public string TopicId { get; set; }
        public bool TopLevelTopic { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTopicId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalHdtopic { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
