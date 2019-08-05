using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Code1099
    {
        public string Company { get; set; }
        public string FormTypeId { get; set; }
        public string Code1099Id { get; set; }
        public string Description { get; set; }
        public string BoxNum { get; set; }
        public decimal MinimumAmt { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual BoxNumber BoxNumber { get; set; }
        public virtual FormType FormType { get; set; }
    }
}
