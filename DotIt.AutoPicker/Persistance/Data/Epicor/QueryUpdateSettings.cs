using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class QueryUpdateSettings
    {
        public string Company { get; set; }
        public string QueryId { get; set; }
        public bool AllowAddNew { get; set; }
        public string AddNewLabel { get; set; }
        public bool SupportMdr { get; set; }
        public string UpdatableType { get; set; }
        public string UpdatableBo { get; set; }
        public string BosystemCode { get; set; }
        public string UpdateMethod { get; set; }
        public string Scurl { get; set; }
        public string Scworkflow { get; set; }
        public string ScctxUser { get; set; }
        public string ScctxPwd { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ScuserId { get; set; }
        public string Scpassword { get; set; }
        public string ScctxUrl { get; set; }
    }
}
