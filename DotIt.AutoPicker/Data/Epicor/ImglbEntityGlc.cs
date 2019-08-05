using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbEntityGlc
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string BusinessEntity { get; set; }
        public string Company { get; set; }
        public string ExtCompanyId { get; set; }
        public string GlcontrolCode { get; set; }
        public string GlcontrolType { get; set; }
        public bool IsExternalCompany { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string Key4 { get; set; }
        public string Key5 { get; set; }
        public string Key6 { get; set; }
        public string RelatedToFile { get; set; }
        public string GlbCompany { get; set; }
        public string GlbRelatedToFile { get; set; }
        public string GlbKey1 { get; set; }
        public string GlbKey2 { get; set; }
        public string GlbKey3 { get; set; }
        public string GlbKey4 { get; set; }
        public string GlbKey5 { get; set; }
        public string GlbGlcontrolType { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalEntityGlc { get; set; }
        public bool GlobalLock { get; set; }
        public string GlbKey6 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
