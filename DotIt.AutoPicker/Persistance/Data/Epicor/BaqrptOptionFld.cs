using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BaqrptOptionFld
    {
        public string Company { get; set; }
        public string BaqrptId { get; set; }
        public string DataTableId { get; set; }
        public string FieldName { get; set; }
        public string CompOp { get; set; }
        public int Seq { get; set; }
        public string DefaultValue { get; set; }
        public string FieldLabel { get; set; }
        public string DisplayName { get; set; }
        public string FieldFormat { get; set; }
        public string EpiGuid { get; set; }
        public bool IsVisible { get; set; }
        public string DataType { get; set; }
        public bool SystemFlag { get; set; }
        public int DispOrder { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
