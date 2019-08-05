using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbCrmcomp
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string Comment { get; set; }
        public string Company { get; set; }
        public string CompId { get; set; }
        public int CompNum { get; set; }
        public string CompUrl { get; set; }
        public string Country { get; set; }
        public int CountryNum { get; set; }
        public string EmailAddress { get; set; }
        public string FaxNum { get; set; }
        public bool Inactive { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string GlbCompany { get; set; }
        public int GlbCompNum { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalCrmcomp { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
