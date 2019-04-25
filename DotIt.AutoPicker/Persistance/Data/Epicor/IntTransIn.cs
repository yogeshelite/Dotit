using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class IntTransIn
    {
        public string Company { get; set; }
        public string ExtSystemId { get; set; }
        public string ExtCompanyId { get; set; }
        public string DbschemaName { get; set; }
        public string DbtableName { get; set; }
        public string DbfieldName { get; set; }
        public string DbfieldValue { get; set; }
        public string InboundValue { get; set; }
        public bool DefaultValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
