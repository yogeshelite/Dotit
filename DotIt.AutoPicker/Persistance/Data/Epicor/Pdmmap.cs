using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Pdmmap
    {
        public string Company { get; set; }
        public string ExtSystemId { get; set; }
        public string ExtCompanyId { get; set; }
        public string Pdmfield { get; set; }
        public string FieldDescription { get; set; }
        public int StartPosition { get; set; }
        public int Length { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
