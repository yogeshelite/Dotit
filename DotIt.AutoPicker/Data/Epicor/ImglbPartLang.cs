using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbPartLang
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
