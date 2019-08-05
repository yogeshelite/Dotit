using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class LocationInventoryAddress
    {
        public string Company { get; set; }
        public long LocationNum { get; set; }
        public string AddressType { get; set; }
        public int CustNum { get; set; }
        public string CustShipToNum { get; set; }
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
        public bool UseOts { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual LocationInventory LocationInventory { get; set; }
    }
}
