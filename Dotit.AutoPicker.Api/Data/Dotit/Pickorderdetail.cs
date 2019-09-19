using System;
using System.Collections.Generic;

namespace DotIt.AutoPickerApi.Data.DotIt
{
    public partial class Pickorderdetail
    {
        public Guid Id { get; set; }
        public int Ordernum { get; set; }
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

        public virtual Pickerorder Pickerorder { get; set; }
    }
}
