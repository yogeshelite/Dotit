using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ReportType
    {
        public ReportType()
        {
            ReportStyle = new HashSet<ReportStyle>();
        }

        public string RptTypeId { get; set; }
        public string RptTypeDescription { get; set; }
        public string PrintDriver { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<ReportStyle> ReportStyle { get; set; }
    }
}
