using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImschemaDiff
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int OlderSchemaVersion { get; set; }
        public int NewerSchemaVersion { get; set; }
        public string DbtableName { get; set; }
        public string DbfieldName { get; set; }
        public string DataType { get; set; }
        public int OlderCharLength { get; set; }
        public int NewerCharLength { get; set; }
        public bool TruncateCharLength { get; set; }
        public int OlderIntPrecision { get; set; }
        public int NewerIntPrecision { get; set; }
        public bool TruncateIntPrecision { get; set; }
        public int OlderDeciPrecision { get; set; }
        public int NewerDeciPrecision { get; set; }
        public bool TruncateDeciPrecision { get; set; }
        public string SchemaDiffShortChar01 { get; set; }
        public string SchemaDiffShortChar02 { get; set; }
        public string SchemaDiffShortChar03 { get; set; }
        public string SchemaDiffShortChar04 { get; set; }
        public string SchemaDiffShortChar05 { get; set; }
        public decimal SchemaDiffNumber01 { get; set; }
        public decimal SchemaDiffNumber02 { get; set; }
        public decimal SchemaDiffNumber03 { get; set; }
        public decimal SchemaDiffNumber04 { get; set; }
        public decimal SchemaDiffNumber05 { get; set; }
        public DateTime? SchemaDiffDate01 { get; set; }
        public DateTime? SchemaDiffDate02 { get; set; }
        public DateTime? SchemaDiffDate03 { get; set; }
        public DateTime? SchemaDiffDate04 { get; set; }
        public DateTime? SchemaDiffDate05 { get; set; }
        public bool SchemaDiffCheckBox01 { get; set; }
        public bool SchemaDiffCheckBox02 { get; set; }
        public bool SchemaDiffCheckBox03 { get; set; }
        public bool SchemaDiffCheckBox04 { get; set; }
        public bool SchemaDiffCheckBox05 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
