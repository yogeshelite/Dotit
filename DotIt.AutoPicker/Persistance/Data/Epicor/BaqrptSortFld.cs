using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BaqrptSortFld
    {
        public string Company { get; set; }
        public string BaqrptId { get; set; }
        public string SortId { get; set; }
        public bool SystemFlag { get; set; }
        public string DataTableId { get; set; }
        public int Seq { get; set; }
        public string FieldName { get; set; }
        public bool IsAscending { get; set; }
        public string DisplayName { get; set; }
        public int DispOrder { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
