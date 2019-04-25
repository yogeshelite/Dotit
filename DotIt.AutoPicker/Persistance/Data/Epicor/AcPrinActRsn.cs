using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcPrinActRsn
    {
        public string Company { get; set; }
        public string PrinActRsnCd { get; set; }
        public string PrinActRsnDesc { get; set; }
        public bool SystemFlag { get; set; }
        public string Prstatus { get; set; }
        public bool ResidentEntry { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
