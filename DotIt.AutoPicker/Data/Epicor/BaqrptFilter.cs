using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BaqrptFilter
    {
        public string Company { get; set; }
        public string BaqrptId { get; set; }
        public string DataTableId { get; set; }
        public string FieldName { get; set; }
        public string AdapterName { get; set; }
        public int Seq { get; set; }
        public string LookupField { get; set; }
        public string FilterLabel { get; set; }
        public string TabLabel { get; set; }
        public string DisplayName { get; set; }
        public string EpiGuid { get; set; }
        public bool IsVisible { get; set; }
        public string FilterField { get; set; }
        public bool SystemFlag { get; set; }
        public int DispOrder { get; set; }
        public string DataType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
