using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PartLangDesc
    {
        public string LangNameId { get; set; }
        public string PartNum { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
