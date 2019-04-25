using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ExtPrgrpEmp
    {
        public ExtPrgrpEmp()
        {
            ExtPrgrpEmpDtl = new HashSet<ExtPrgrpEmpDtl>();
        }

        public string Company { get; set; }
        public string GroupId { get; set; }
        public string EmpId { get; set; }
        public DateTime? Psdate { get; set; }
        public DateTime? Pedate { get; set; }
        public decimal TotalBaseHours { get; set; }
        public decimal TotalOthours { get; set; }
        public decimal TotalDthours { get; set; }
        public string PayClassId { get; set; }
        public string PayFreq { get; set; }
        public bool SentToFile { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ExtPrprocGrp ExtPrprocGrp { get; set; }
        public virtual ICollection<ExtPrgrpEmpDtl> ExtPrgrpEmpDtl { get; set; }
    }
}
