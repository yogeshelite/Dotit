using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class FaaddReg
    {
        public string Company { get; set; }
        public string AssetNum { get; set; }
        public int AdditionNum { get; set; }
        public string AssetRegId { get; set; }
        public decimal PrevDepreciation { get; set; }
        public decimal CurrDepreciation { get; set; }
        public decimal BookValue { get; set; }
        public decimal GrantBookValue { get; set; }
        public decimal PrevGrantDep { get; set; }
        public decimal CurrGrantDep { get; set; }
        public decimal DocPrevDepreciation { get; set; }
        public decimal DocCurrDepreciation { get; set; }
        public decimal DocBookValue { get; set; }
        public decimal DocGrantBookValue { get; set; }
        public decimal DocPrevGrantDep { get; set; }
        public decimal DocCurrGrantDep { get; set; }
        public decimal Rpt1PrevDepreciation { get; set; }
        public decimal Rpt1CurrDepreciation { get; set; }
        public decimal Rpt1BookValue { get; set; }
        public decimal Rpt1GrantBookValue { get; set; }
        public decimal Rpt1PrevGrantDep { get; set; }
        public decimal Rpt1CurrGrantDep { get; set; }
        public decimal Rpt2PrevDepreciation { get; set; }
        public decimal Rpt2CurrDepreciation { get; set; }
        public decimal Rpt2BookValue { get; set; }
        public decimal Rpt2GrantBookValue { get; set; }
        public decimal Rpt2PrevGrantDep { get; set; }
        public decimal Rpt2CurrGrantDep { get; set; }
        public decimal Rpt3PrevDepreciation { get; set; }
        public decimal Rpt3CurrDepreciation { get; set; }
        public decimal Rpt3BookValue { get; set; }
        public decimal Rpt3GrantBookValue { get; set; }
        public decimal Rpt3PrevGrantDep { get; set; }
        public decimal Rpt3CurrGrantDep { get; set; }
        public decimal AdditionCost { get; set; }
        public decimal GrantAmt { get; set; }
        public decimal DocAdditionCost { get; set; }
        public decimal DocGrantAmt { get; set; }
        public decimal Rpt1AdditionCost { get; set; }
        public decimal Rpt1GrantAmt { get; set; }
        public decimal Rpt2AdditionCost { get; set; }
        public decimal Rpt2GrantAmt { get; set; }
        public decimal Rpt3AdditionCost { get; set; }
        public decimal Rpt3GrantAmt { get; set; }
        public decimal AdditionCostLimit { get; set; }
        public decimal DocAdditionCostLimit { get; set; }
        public decimal Rpt1AdditionCostLimit { get; set; }
        public decimal Rpt2AdditionCostLimit { get; set; }
        public decimal Rpt3AdditionCostLimit { get; set; }
        public decimal CostVariance { get; set; }
        public decimal DocCostVariance { get; set; }
        public decimal Rpt1CostVariance { get; set; }
        public decimal Rpt2CostVariance { get; set; }
        public decimal Rpt3CostVariance { get; set; }
        public decimal GrantVariance { get; set; }
        public decimal DocGrantVariance { get; set; }
        public decimal Rpt1GrantVariance { get; set; }
        public decimal Rpt2GrantVariance { get; set; }
        public decimal Rpt3GrantVariance { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool InclCurrPerDepn { get; set; }
        public bool AffectsAssetLife { get; set; }
        public int NewAssetLife { get; set; }
        public string NewLifeModifier { get; set; }
    }
}
