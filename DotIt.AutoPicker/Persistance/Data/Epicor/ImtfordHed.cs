using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImtfordHed
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TfordNum { get; set; }
        public bool OpenOrder { get; set; }
        public string Plant { get; set; }
        public string ToPlant { get; set; }
        public string EntryPerson { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ShipViaCode { get; set; }
        public string ShipComment { get; set; }
        public string PickListComment { get; set; }
        public bool Shipped { get; set; }
        public bool AutoPrintReady { get; set; }
        public string TranDocTypeId { get; set; }
        public string LegalNumber { get; set; }
        public string WarehouseCode { get; set; }
        public bool UseOts { get; set; }
        public string Otsname { get; set; }
        public string Otsaddress1 { get; set; }
        public string Otsaddress2 { get; set; }
        public string Otsaddress3 { get; set; }
        public string Otscity { get; set; }
        public string Otsstate { get; set; }
        public string Otszip { get; set; }
        public string Otscontact { get; set; }
        public int OtscountryNum { get; set; }
        public string OtsphoneNum { get; set; }
        public string OtsfaxNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
