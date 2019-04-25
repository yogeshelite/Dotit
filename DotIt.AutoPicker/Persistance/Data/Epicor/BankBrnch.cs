using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BankBrnch
    {
        public string Company { get; set; }
        public string BankBranchCode { get; set; }
        public string Description { get; set; }
        public string BankName { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool AgwithHoldingFlag { get; set; }
    }
}
