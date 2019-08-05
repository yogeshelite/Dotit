using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Tip
    {
        public string Company { get; set; }
        public string MfgSys { get; set; }
        public int TipNum { get; set; }
        public bool Active { get; set; }
        public string TipTitle { get; set; }
        public string TipText { get; set; }
        public int ShowNum { get; set; }
        public bool SystemFlag { get; set; }
        public int CompanyVisibility { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
