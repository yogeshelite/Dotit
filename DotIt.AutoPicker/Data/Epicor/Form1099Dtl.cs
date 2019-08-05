using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Form1099Dtl
    {
        public string Company { get; set; }
        public string FormTypeId { get; set; }
        public int Form1099Num { get; set; }
        public string Code1099Id { get; set; }
        public decimal BoxAmt { get; set; }
        public string BoxNum { get; set; }
        public string BoxNumDesc { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual BoxNumber BoxNumber { get; set; }
        public virtual Form1099 Form1099 { get; set; }
    }
}
