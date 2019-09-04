using System;
using System.Collections.Generic;

namespace Dotit.AutoPickerApi.Persistance.Data.Doitit
{
    public partial class Pickorderdetail
    {
        public int Orderno { get; set; }
        public string Company { get; set; }
        public string Partnum { get; set; }
        public string Binnum { get; set; }
        public int? Damageqty { get; set; }
        public int? Pickstatus { get; set; }
        public int? Orderline { get; set; }
        public decimal? Orderqty { get; set; }
        public string Ium { get; set; }
        public string Linedesc { get; set; }
        public decimal? Unitprice { get; set; }
        public decimal? Totalprice { get; set; }
    }
}
