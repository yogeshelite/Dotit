using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbIcommCode
    {
        public string CommodityCode { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string ExportCode { get; set; }
        public string ImportCode { get; set; }
        public string IntCommCode { get; set; }
        public bool NotReported { get; set; }
        public bool RequiresUm { get; set; }
        public bool RequiresWeight { get; set; }
        public string StatExportCode { get; set; }
        public string StatImportCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbCommodityCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalIcommCode { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
