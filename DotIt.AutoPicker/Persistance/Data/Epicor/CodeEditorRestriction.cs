using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CodeEditorRestriction
    {
        public string Company { get; set; }
        public string RestrictedText { get; set; }
        public string Module { get; set; }
        public bool SystemRestriction { get; set; }
        public int Exemption { get; set; }
        public string Reason { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
