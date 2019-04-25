using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ZfieldDecimal
    {
        public string SchemaName { get; set; }
        public string DbtableName { get; set; }
        public string DbfieldName { get; set; }
        public string DecimalValueType { get; set; }
        public string DecimalCurrencyType { get; set; }
        public bool Inactive { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
