using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcCompanyConfig
    {
        public string Company { get; set; }
        public string ConfigCode { get; set; }
        public string ConfigDesc { get; set; }
        public string ConfigValue { get; set; }
        public string ConfigDataType { get; set; }
        public string ConfigValueList { get; set; }
        public string ModuleName { get; set; }
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
