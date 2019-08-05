using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImdataExportOption
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
