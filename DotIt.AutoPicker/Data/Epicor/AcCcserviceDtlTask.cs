using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcCcserviceDtlTask
    {
        public string Company { get; set; }
        public int ServiceDtlId { get; set; }
        public int ServiceDtlTaskId { get; set; }
        public string ServiceTaskCd { get; set; }
        public string ServiceTaskDesc { get; set; }
        public bool Essential { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string JobNum { get; set; }
    }
}
