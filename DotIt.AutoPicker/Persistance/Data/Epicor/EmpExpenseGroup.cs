using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EmpExpenseGroup
    {
        public string Company { get; set; }
        public string EmpId { get; set; }
        public string ClaimRef { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
