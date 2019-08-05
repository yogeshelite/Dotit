using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CooneTime
    {
        public string Company { get; set; }
        public string CooneTimeId { get; set; }
        public string Description { get; set; }
        public int CheckDigit { get; set; }
        public string IdentificationType { get; set; }
        public string FirstLastName { get; set; }
        public string FirstName { get; set; }
        public string SecondLastName { get; set; }
        public string OtherNames { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public string TownCode { get; set; }
        public string CountryCode { get; set; }
        public string Ciiucode { get; set; }
        public bool CommonRegime { get; set; }
        public bool ImportantTaxpayer { get; set; }
        public bool SimplifiedRegime { get; set; }
        public string Nature { get; set; }
        public string EmailAddress { get; set; }
        public string CellPhoneNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
