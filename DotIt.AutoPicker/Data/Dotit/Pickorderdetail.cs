using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.DotIt
{
    public partial class Pickorderdetail
    {
        public int Orderno { get; set; }
        public string Company { get; set; }
        public string Partnum { get; set; }
        public string Binnum { get; set; }
        public int? Damageqty { get; set; }
        public int? Pickstatus { get; set; }
    }
}
