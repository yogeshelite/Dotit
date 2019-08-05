using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class DropShipHead
    {
        public string Company { get; set; }
        public string PackSlip { get; set; }
        public int Ponum { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public string ShipToNum { get; set; }
        public bool ReceivedShipped { get; set; }
        public string EntryPerson { get; set; }
        public DateTime? EntryDate { get; set; }
        public string ReceivePerson { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string ShipViaCode { get; set; }
        public string TrackingNumber { get; set; }
        public bool Apinvoiced { get; set; }
        public bool Arinvoiced { get; set; }
        public int ShipmentPackNum { get; set; }
        public string ReceiptPackSlip { get; set; }
        public string ShipComment { get; set; }
        public string ReceiptComment { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string ChangedBy { get; set; }
        public int ChangeTime { get; set; }
        public int CustNum { get; set; }
        public int BtcustNum { get; set; }
        public int BtconNum { get; set; }
        public string Plant { get; set; }
        public int ShipToCustNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string TranDocTypeId { get; set; }
        public string LegalNumber { get; set; }
    }
}
