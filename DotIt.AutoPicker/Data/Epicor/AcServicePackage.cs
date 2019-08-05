using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcServicePackage
    {
        public string Company { get; set; }
        public string PackageId { get; set; }
        public string ProgramId { get; set; }
        public string PackageDesc { get; set; }
        public string ServiceTypeList { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
