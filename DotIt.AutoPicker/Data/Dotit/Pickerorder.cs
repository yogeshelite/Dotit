using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.DotIt
{
    public partial class Pickerorder
    {
        public int Ordernum { get; set; }
        public string Company { get; set; }
        public DateTime Orderdate { get; set; }
        public int? Totalitems { get; set; }
        public double? Weight { get; set; }
        public string Dcduserid { get; set; }
        public string Pickstatus { get; set; }
        public DateTime? Recorddate { get; set; }
        public DateTime? Recordupdatedon { get; set; }
        public DateTime? PickDate { get; set; }

        public string ReasionPickFail { get; set; }
        

    }
}
