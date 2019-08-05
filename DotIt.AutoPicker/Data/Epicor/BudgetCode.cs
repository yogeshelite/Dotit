using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BudgetCode
    {
        public string Company { get; set; }
        public string BudgetCodeId { get; set; }
        public string BudgetCodeDesc { get; set; }
        public bool IsDefault { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
