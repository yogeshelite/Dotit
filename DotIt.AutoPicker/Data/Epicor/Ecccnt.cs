using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Ecccnt
    {
        public string Company { get; set; }
        public int OrderNum { get; set; }
        public string Type { get; set; }
        public string AddressCode { get; set; }
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public int CountryNum { get; set; }
        public string PhoneNum { get; set; }
        public string FaxNum { get; set; }
        public string EmailAddress { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
