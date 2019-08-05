using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImmenuTab
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string UserId { get; set; }
        public string TabCaption { get; set; }
        public int Type { get; set; }
        public string Content { get; set; }
        public int TabId { get; set; }
        public string CompanyId { get; set; }
        public string PlantId { get; set; }
        public string AppServerUrl { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
