using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbLangDesc
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string LangNameId { get; set; }
        public string TableName { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTableName { get; set; }
        public string GlbKey1 { get; set; }
        public string GlbKey2 { get; set; }
        public string GlbKey3 { get; set; }
        public string GlbLangNameId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLangDesc { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
