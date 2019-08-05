using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BitFlag
    {
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
