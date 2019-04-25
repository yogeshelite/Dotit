using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class DefExpRecogTask
    {
        public string Company { get; set; }
        public Guid TaskUid { get; set; }
        public int TaskLine { get; set; }
        public string RelatedToFile { get; set; }
        public Guid ForeignSysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
