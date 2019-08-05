using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ExtPrgrpEmpDtl
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string EmpId { get; set; }
        public int DtlNum { get; set; }
        public DateTime? PayrollDate { get; set; }
        public string PayTypeId { get; set; }
        public decimal BaseHours { get; set; }
        public decimal Othours { get; set; }
        public decimal Hours3 { get; set; }
        public string Hours3Code { get; set; }
        public bool SentToFile { get; set; }
        public string TempDept { get; set; }
        public bool FromLabor { get; set; }
        public int Shift { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ExtPrgrpEmp ExtPrgrpEmp { get; set; }
    }
}
