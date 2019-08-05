using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EsPrepressdefaultsdtl
    {
        public string Company { get; set; }
        public string RecId { get; set; }
        public string PrepressDefaultsDtlUserId { get; set; }
        public string PrepressDefaultsUserId { get; set; }
        public string PrepressDefDtlDesc { get; set; }
        public string PrepressDefaultsId { get; set; }
        public string CalculateUnitsPer { get; set; }
        public decimal? UnitsPerPart { get; set; }
        public bool? CalcUnitsPerPage { get; set; }
        public decimal? UnitsPerPage { get; set; }
        public bool? CalcUnitsPerColor { get; set; }
        public decimal? UnitsPerColor { get; set; }
        public bool? CalcUnitsPerShtSqUnits { get; set; }
        public decimal? UnitsPerSqUnits { get; set; }
        public bool? CalcUnitsPerLyt { get; set; }
        public decimal? UnitsPerLyt { get; set; }
        public bool? CalcUnitsPerLg { get; set; }
        public decimal? UnitsPerLg { get; set; }
        public bool? CalcUnitsPerPlate { get; set; }
        public decimal? UnitsPerPlate { get; set; }
        public string PrepressStdId { get; set; }
        public string PrepressStdDesc { get; set; }
        public string PrepressStdUserId { get; set; }
        public bool? Inactive { get; set; }
        public decimal? OrderInEst { get; set; }
        public bool? TmpIsCalcNoPagsPerPart { get; set; }
        public bool? TmpIsCalcNumOfColorPerPart { get; set; }
        public bool? TmpIsCalcPresStSizePerPart { get; set; }
        public bool? TmpIsCalcNumOfLytsPerPart { get; set; }
        public bool? TmpIsCalcLgqtyPerPart { get; set; }
        public bool? TmpIsCalcNumPlatePerPart { get; set; }
        public bool? TmpIsMainCalcUomfinished { get; set; }
        public decimal? LaborAdjPct { get; set; }
        public decimal? LaborAdjPctUi { get; set; }
        public string UirecIdentifier { get; set; }
        public string TopLevelUserId { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public int? LineNumber { get; set; }
        public string UserChar1 { get; set; }
        public string UserChar2 { get; set; }
        public string UserChar3 { get; set; }
        public string UserChar4 { get; set; }
        public string UserChar5 { get; set; }
        public string UserChar6 { get; set; }
        public DateTime? UserDate1 { get; set; }
        public DateTime? UserDate2 { get; set; }
        public DateTime? UserDate3 { get; set; }
        public DateTime? UserDate4 { get; set; }
        public DateTime? UserDate5 { get; set; }
        public DateTime? UserDate6 { get; set; }
        public decimal? UserDecimal1 { get; set; }
        public decimal? UserDecimal2 { get; set; }
        public decimal? UserDecimal3 { get; set; }
        public decimal? UserDecimal4 { get; set; }
        public decimal? UserDecimal5 { get; set; }
        public decimal? UserDecimal6 { get; set; }
        public decimal? UserDecimal7 { get; set; }
        public decimal? UserDecimal8 { get; set; }
        public decimal? UserDecimal9 { get; set; }
        public decimal? UserDecimal10 { get; set; }
        public decimal? UserDecimal11 { get; set; }
        public decimal? UserDecimal12 { get; set; }
        public int? UserInteger1 { get; set; }
        public int? UserInteger2 { get; set; }
        public int? UserInteger3 { get; set; }
        public int? UserInteger4 { get; set; }
        public int? UserInteger5 { get; set; }
        public int? UserInteger6 { get; set; }

        public virtual EsPrepressdefaults PrepressDefaults { get; set; }
        public virtual EsPrepress PrepressStd { get; set; }
    }
}
