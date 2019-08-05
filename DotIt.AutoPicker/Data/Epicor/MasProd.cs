using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class MasProd
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string Plant { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal ProdQty { get; set; }
        public string ProdQtyUom { get; set; }
        public DateTime? ForeDate { get; set; }
        public string ParentPartNum { get; set; }
        public string KitFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
