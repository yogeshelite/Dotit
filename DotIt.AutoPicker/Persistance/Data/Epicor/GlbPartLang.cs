using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbPartLang
    {
        public string LangNameId { get; set; }
        public string PartNum { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public string GlbCompany { get; set; }
        public string GlbLangNameId { get; set; }
        public string GlbPartNum { get; set; }
        public string OldCompany { get; set; }
        public string OldPartNum { get; set; }
        public string OldLangNameId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
