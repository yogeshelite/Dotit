using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SysPlant
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int CountryNum { get; set; }
        public string PhoneNum { get; set; }
        public string FaxNum { get; set; }
        public string CommentText { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string TimeZoneId { get; set; }
    }
}
