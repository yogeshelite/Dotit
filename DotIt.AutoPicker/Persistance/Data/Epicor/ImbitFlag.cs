using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImbitFlag
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string RelatedToSchemaName { get; set; }
        public string RelatedToTable { get; set; }
        public Guid RelatedToRowId { get; set; }
        public int Memo { get; set; }
        public int Attachment { get; set; }
        public int Crmcall { get; set; }
        public int ChgLog { get; set; }
        public int Bpmhold { get; set; }
        public bool RequiresGlcontrol { get; set; }
        public int? BitValues { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
