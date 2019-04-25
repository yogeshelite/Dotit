using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Famethod
    {
        public string Company { get; set; }
        public string AssetMethod { get; set; }
        public string Description { get; set; }
        public string DepreciationMethod { get; set; }
        public bool AdditionSpread { get; set; }
        public bool Finalspread { get; set; }
        public bool InUse { get; set; }
        public bool AllowSwitch { get; set; }
        public string AltAssetMethod { get; set; }
        public string DepChargeBasis { get; set; }
        public string AnnualChargeType { get; set; }
        public string AnnualFormula { get; set; }
        public string PeriodChargeType { get; set; }
        public string ProrateType { get; set; }
        public bool SystemFlag { get; set; }
        public string SwitchMethod { get; set; }
        public decimal SwitchPercent { get; set; }
        public string PeriodFormula { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string RemYearsCalculation { get; set; }
    }
}
