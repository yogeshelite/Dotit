using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PbginvcTran
    {
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public int TmpInvcNum { get; set; }
        public string RelatedToFile { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string Key4 { get; set; }
        public bool Modified { get; set; }
        public DateTime? DateModified { get; set; }
        public string UserModified { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
