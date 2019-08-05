using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImlangName
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
