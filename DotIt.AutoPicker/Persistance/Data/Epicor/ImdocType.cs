using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImdocType
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string DocTypeId { get; set; }
        public string Description { get; set; }
        public bool Receipt { get; set; }
        public bool Shipment { get; set; }
        public string BaseUrl { get; set; }
        public string SharePointId { get; set; }
        public int StorageType { get; set; }
        public string ImageName { get; set; }
        public bool SpecificTables { get; set; }
        public bool GlobalDocType { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int FileTransferMode { get; set; }
    }
}
