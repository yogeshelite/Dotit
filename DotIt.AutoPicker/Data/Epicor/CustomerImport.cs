using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CustomerImport
    {
        public string Company { get; set; }
        public long ImportId { get; set; }
        public string CustId { get; set; }
        public int CustNum { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string SalesRepCode { get; set; }
        public string TerritoryId { get; set; }
        public string FaxNum { get; set; }
        public string PhoneNum { get; set; }
        public string EmailAddress { get; set; }
        public string CustomerType { get; set; }
        public bool NoContact { get; set; }
        public string CustUrl { get; set; }
        public string ExtId { get; set; }
        public int MatchedCustNum { get; set; }
        public string MatchedFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
