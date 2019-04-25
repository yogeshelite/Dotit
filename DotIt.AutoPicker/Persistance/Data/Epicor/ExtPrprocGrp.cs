using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ExtPrprocGrp
    {
        public ExtPrprocGrp()
        {
            ExtPrgrpEmp = new HashSet<ExtPrgrpEmp>();
        }

        public string Company { get; set; }
        public string GroupId { get; set; }
        public string Status { get; set; }
        public DateTime? Pedate { get; set; }
        public bool PayWeekly { get; set; }
        public bool PayBiWeekly { get; set; }
        public bool PaySemiMonthly { get; set; }
        public bool PayMonthly { get; set; }
        public string CreatedBy { get; set; }
        public string PayClasses { get; set; }
        public bool SentToFile { get; set; }
        public string FilePath { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<ExtPrgrpEmp> ExtPrgrpEmp { get; set; }
    }
}
