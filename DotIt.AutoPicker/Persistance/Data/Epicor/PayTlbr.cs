using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PayTlbr
    {
        public string Company { get; set; }
        public string PayTypeId { get; set; }
        public string ExpenseCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
