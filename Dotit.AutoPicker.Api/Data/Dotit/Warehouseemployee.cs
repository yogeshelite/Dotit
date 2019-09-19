using System;
using System.Collections.Generic;

namespace DotIt.AutoPickerApi.Data.DotIt
{
    public partial class Warehouseemployee
    {
        public Guid? Empid { get; set; }
        public string Company { get; set; }
        public string Dcduserid { get; set; }
        public string Pickername { get; set; }
        public string Emailaddress { get; set; }
        public string Grouplist { get; set; }
        public int? Maxlines { get; set; }
        public int? Maxweight { get; set; }
        public int? Adminlineperhour { get; set; }
        public string Password { get; set; }
        public bool? Active { get; set; }
        public DateTime? Lastlogin { get; set; }
        public DateTime? Recorddate { get; set; }
        public DateTime? Recordupdatedate { get; set; }
        public string Userheight { get; set; }
        public int? Weightcapacity { get; set; }
        public string Pickforcompany { get; set; }
        public int? Maxorder { get; set; }
    }
}
