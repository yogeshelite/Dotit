using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ReportStyleImage
    {
        public string Company { get; set; }
        public string ReportId { get; set; }
        public int StyleNum { get; set; }
        public string ReportStyleImageName { get; set; }
        public string ImageCompany { get; set; }
        public string ImageId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ReportStyle ReportStyle { get; set; }
    }
}
