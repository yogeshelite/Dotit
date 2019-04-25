using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EmpRole
    {
        public string Company { get; set; }
        public string EmpId { get; set; }
        public string RoleCd { get; set; }
        public bool Primary { get; set; }
        public bool TimeApprover { get; set; }
        public bool ExpenseApprover { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
