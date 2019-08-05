using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PrempRt
    {
        public string Company { get; set; }
        public string EmpLink { get; set; }
        public DateTime? RateDate { get; set; }
        public decimal PayRate { get; set; }
        public string ClassId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
