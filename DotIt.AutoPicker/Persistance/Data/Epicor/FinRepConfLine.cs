using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class FinRepConfLine
    {
        public string Company { get; set; }
        public string ConfigId { get; set; }
        public int LineNum { get; set; }
        public string LabelId { get; set; }
        public string Formula { get; set; }
        public bool RightSideStarts { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
