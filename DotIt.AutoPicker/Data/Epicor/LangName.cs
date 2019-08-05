using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class LangName
    {
        public string LangNameId { get; set; }
        public string Description { get; set; }
        public string ParentLangId { get; set; }
        public bool IsCustomLang { get; set; }
        public string HelpFileName { get; set; }
        public string SpellCheckingDictionary { get; set; }
        public int TransVer { get; set; }
        public string Culture { get; set; }
        public string FontName { get; set; }
        public decimal CharWidthFactor { get; set; }
        public string FontStyle { get; set; }
        public string FileVersion { get; set; }
        public DateTime TranDate { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool? HasTrans { get; set; }
    }
}
