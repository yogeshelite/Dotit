using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class IcommCode
    {
        public string Company { get; set; }
        public string CommodityCode { get; set; }
        public string Description { get; set; }
        public bool RequiresWeight { get; set; }
        public bool RequiresUm { get; set; }
        public bool NotReported { get; set; }
        public string IntCommCode { get; set; }
        public string StatImportCode { get; set; }
        public string StatExportCode { get; set; }
        public string ImportCode { get; set; }
        public string ExportCode { get; set; }
        public bool GlobalIcommCode { get; set; }
        public bool GlobalLock { get; set; }
        public string SuppUnitsUom { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
