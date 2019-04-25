using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class FareportCat
    {
        public string Company { get; set; }
        public string CategoryCode { get; set; }
        public string ParentCategoryCode { get; set; }
        public bool BottomLevel { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
