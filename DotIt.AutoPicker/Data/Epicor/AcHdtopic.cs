using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcHdtopic
    {
        public string Company { get; set; }
        public string TopicId { get; set; }
        public bool CarePlanDomain { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
