using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EssearchFields
    {
        public string Company { get; set; }
        public string SearchId { get; set; }
        public string GlbCompany { get; set; }
        public int Seq { get; set; }
        public string DataTableId { get; set; }
        public string FieldName { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
