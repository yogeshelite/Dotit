using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class QueryCtrl
    {
        public string Company { get; set; }
        public string QueryId { get; set; }
        public string ControlId { get; set; }
        public string DataSource { get; set; }
        public string DataType { get; set; }
        public string FieldFormat { get; set; }
        public bool IsMandatory { get; set; }
        public string DefaultValue { get; set; }
        public string ControlType { get; set; }
        public int SourceType { get; set; }
        public string ListSource { get; set; }
        public string DisplayColumn { get; set; }
        public string ValueColumn { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int Seq { get; set; }
    }
}
