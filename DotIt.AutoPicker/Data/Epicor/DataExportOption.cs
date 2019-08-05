using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class DataExportOption
    {
        public string Company { get; set; }
        public string DefinitionId { get; set; }
        public string OptionName { get; set; }
        public string TableOption { get; set; }
        public string OptionType { get; set; }
        public bool DefaultOption { get; set; }
        public int IntegerCol { get; set; }
        public decimal DecimalCol { get; set; }
        public bool LogicalCol { get; set; }
        public string StringCol { get; set; }
        public DateTime? DateCol { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
