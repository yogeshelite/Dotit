using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class LaborDtlGroup
    {
        public string Company { get; set; }
        public string EmployeeNum { get; set; }
        public string ClaimRef { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
