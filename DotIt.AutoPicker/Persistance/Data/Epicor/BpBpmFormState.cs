using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BpBpmFormState
    {
        public Guid StateId { get; set; }
        public DateTime LastAccessOn { get; set; }
        public byte[] BlobValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
