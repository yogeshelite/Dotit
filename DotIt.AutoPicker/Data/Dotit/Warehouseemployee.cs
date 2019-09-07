using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.DotIt
{
    public partial class Warehouseemployee
    {
       // public Guid? Empid { get; set; }
        public string Company { get; set; }
        public string Dcduserid { get; set; }
        public string Pickername { get; set; }
        public string Emailaddress { get; set; }
        public string Grouplist { get; set; }
        public int? Maxlines { get; set; }
        public int? Maxweight { get; set; }
        public int? Adminlineperhour { get; set; }
        public string Password { get; set; }
        public bool? active { get; set; }
        public DateTime? Lastlogin { get; set; }
        public DateTime? Recorddate { get; set; }
        public DateTime? Recordupdatedate { get; set; }
        public string UserHeight { get; set; }
        public int? WeightCapacity { get; set; }
        public string PickForCompany { get; set; }
        public int? MaxOrder { get; set; }
    }
}
