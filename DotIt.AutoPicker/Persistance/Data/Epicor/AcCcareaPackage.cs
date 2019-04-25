using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcCcareaPackage
    {
        public string Company { get; set; }
        public int AreaId { get; set; }
        public string PackageCd { get; set; }
        public bool DefaultPackage { get; set; }
        public int AuthorisedUsers { get; set; }
        public int CurrentUsers { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
