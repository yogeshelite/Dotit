using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TermsSched
    {
        public string Company { get; set; }
        public string TermsCode { get; set; }
        public int PaySeq { get; set; }
        public int PayDays { get; set; }
        public decimal PayPercent { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual Terms Terms { get; set; }
    }
}
