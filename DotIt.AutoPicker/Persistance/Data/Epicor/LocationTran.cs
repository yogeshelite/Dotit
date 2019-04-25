using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class LocationTran
    {
        public string Company { get; set; }
        public long LocationNum { get; set; }
        public long LocationSeqNum { get; set; }
        public int CustNum { get; set; }
        public string CustShipToNum { get; set; }
        public string AddressType { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
        public int CountryNum { get; set; }
        public string EmailAddress { get; set; }
        public string FaxNum { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string WarrantyTransfer { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string WarrantyCode { get; set; }
        public string WarrantyComment { get; set; }
        public DateTime? WarrantyStartDate { get; set; }
        public DateTime? WarrantyExpirationDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual LocationInventory LocationInventory { get; set; }
    }
}
