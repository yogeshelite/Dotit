using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPicker.Models
{
    public class ItemAssignDetailModel
    {
        public string DcdUserID { get; set; }
        public string PickerName { get; set; }
        public int OrderNo { get; set; }
        public string BinLocation { get; set; }
        public string PartNum { get; set; }
        
    }
}
