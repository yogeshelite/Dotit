using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbDocType
    {
        public string BaseUrl { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string DocTypeId { get; set; }
        public string ImageName { get; set; }
        public bool Receipt { get; set; }
        public string SharePointId { get; set; }
        public bool Shipment { get; set; }
        public bool SpecificTables { get; set; }
        public int StorageType { get; set; }
        public string GlbCompany { get; set; }
        public string GlbDocTypeId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalDocType { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
