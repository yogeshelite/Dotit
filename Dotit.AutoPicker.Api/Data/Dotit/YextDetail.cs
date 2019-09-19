using System;
using System.Collections.Generic;

namespace DotIt.AutoPickerApi.Data.DotIt
{
    public partial class YextDetail
    {
        public int Epicorordernum { get; set; }
        public int Yextid { get; set; }
        public string Partnum { get; set; }
        public int Orderqty { get; set; }
        public DateTime Orderdate { get; set; }
        public bool Isonline { get; set; }
        public decimal Price { get; set; }
        public string Entryperson { get; set; }

        public virtual YextHeader Yext { get; set; }
    }
}
