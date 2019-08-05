using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcPcashDeskAddr
    {
        public string Company { get; set; }
        public string CashDeskId { get; set; }
        public string Description { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public int CountryNum { get; set; }
        public string Comments { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNum { get; set; }
        public string FaxNum { get; set; }
        public string LocalName { get; set; }
        public string Logo { get; set; }
        public string LogoPath { get; set; }
        public string CashierUrl { get; set; }
        public string TaxId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
