using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class InchapterId
    {
        public string Company { get; set; }
        public string ChapterId { get; set; }
        public string Description { get; set; }
        public bool InActive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
