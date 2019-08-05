using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class XfileAttch
    {
        public string Company { get; set; }
        public string RelatedToSchemaName { get; set; }
        public string RelatedToFile { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string Key4 { get; set; }
        public int AttachNum { get; set; }
        public string Key5 { get; set; }
        public int XfileRefNum { get; set; }
        public bool DoTrigger { get; set; }
        public string DupToRelatedToFile { get; set; }
        public string DupToKey1 { get; set; }
        public string DupToKey2 { get; set; }
        public string DupToKey3 { get; set; }
        public string DupToKey4 { get; set; }
        public string DupToKey5 { get; set; }
        public int DupToAttachNum { get; set; }
        public string Key6 { get; set; }
        public string SharePointId { get; set; }
        public Guid ForeignSysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
