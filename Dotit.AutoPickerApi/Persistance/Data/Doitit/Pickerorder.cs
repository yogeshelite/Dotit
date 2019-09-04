using System;
using System.Collections.Generic;

namespace Dotit.AutoPickerApi.Persistance.Data.Doitit
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
        public DateTime? Pickdate { get; set; }
        public DateTime? Recorddate { get; set; }
        public DateTime? Recordupdatedon { get; set; }
        public string Reasionpickfail { get; set; }
    }
}
