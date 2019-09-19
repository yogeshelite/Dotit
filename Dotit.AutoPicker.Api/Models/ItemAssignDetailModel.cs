using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPickerApi.Models
{
    public class ItemAssignDetailModel
    {
        public string DcdUserID { get; set; }
        public string PickerName { get; set; }
        public int OrderNo { get; set; }
        public string BinLocation { get; set; }
        public string PartNum { get; set; }
        public int? Damageqty { get; set; }
        public int? Pickstatus { get; set; }
        public int? OrderLine { get; set; }
        public decimal? OrderQty { get; set; }
        public string IUM { get; set; }
        public string LineDesc { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
