using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class FarevalueReg
    {
        public string Company { get; set; }
        public string AssetNum { get; set; }
        public int RevalueNum { get; set; }
        public string AssetRegId { get; set; }
        public decimal OrigCurrentCost { get; set; }
        public decimal DocOrigCurrentCost { get; set; }
        public decimal Rpt1OrigCurrentCost { get; set; }
        public decimal Rpt2OrigCurrentCost { get; set; }
        public decimal Rpt3OrigCurrentCost { get; set; }
        public decimal OrigBookValue { get; set; }
        public decimal DocOrigBookValue { get; set; }
        public decimal Rpt1OrigBookValue { get; set; }
        public decimal Rpt2OrigBookValue { get; set; }
        public decimal Rpt3OrigBookValue { get; set; }
        public decimal OrigTotalDepn { get; set; }
        public decimal DocOrigTotalDepn { get; set; }
        public decimal Rpt1OrigTotalDepn { get; set; }
        public decimal Rpt2OrigTotalDepn { get; set; }
        public decimal Rpt3OrigTotalDepn { get; set; }
        public decimal RevalueGainLoss { get; set; }
        public decimal DocRevalueGainLoss { get; set; }
        public decimal Rpt1RevalueGainLoss { get; set; }
        public decimal Rpt2RevalueGainLoss { get; set; }
        public decimal Rpt3RevalueGainLoss { get; set; }
        public decimal RevalueSurplus { get; set; }
        public decimal DocRevalueSurplus { get; set; }
        public decimal Rpt1RevalueSurplus { get; set; }
        public decimal Rpt2RevalueSurplus { get; set; }
        public decimal Rpt3RevalueSurplus { get; set; }
        public decimal GrantAmt { get; set; }
        public decimal DocGrantAmt { get; set; }
        public decimal Rpt1GrantAmt { get; set; }
        public decimal Rpt2GrantAmt { get; set; }
        public decimal Rpt3GrantAmt { get; set; }
        public decimal GrantDepnAmt { get; set; }
        public decimal DocGrantDepnAmt { get; set; }
        public decimal Rpt1GrantDepnAmt { get; set; }
        public decimal Rpt2GrantDepnAmt { get; set; }
        public decimal Rpt3GrantDepnAmt { get; set; }
        public decimal UnusedGrantAmt { get; set; }
        public decimal DocUnusedGrantAmt { get; set; }
        public decimal Rpt1UnusedGrantAmt { get; set; }
        public decimal Rpt2UnusedGrantAmt { get; set; }
        public decimal Rpt3UnusedGrantAmt { get; set; }
        public decimal PostedFutrDepnAmt { get; set; }
        public decimal DocPostedFutrDepnAmt { get; set; }
        public decimal Rpt1PostedFutrDepnAmt { get; set; }
        public decimal Rpt2PostedFutrDepnAmt { get; set; }
        public decimal Rpt3PostedFutrDepnAmt { get; set; }
        public decimal PostedFutrGrantDepnAmt { get; set; }
        public decimal DocPostedFutrGrantDepnAmt { get; set; }
        public decimal Rpt1PostedFutrGrantDepnAmt { get; set; }
        public decimal Rpt2PostedFutrGrantDepnAmt { get; set; }
        public decimal Rpt3PostedFutrGrantDepnAmt { get; set; }
        public int NewAssetLife { get; set; }
        public string NewLifeModifier { get; set; }
        public decimal NewResidualValue { get; set; }
        public decimal DocNewResidualValue { get; set; }
        public decimal Rpt1NewResidualValue { get; set; }
        public decimal Rpt2NewResidualValue { get; set; }
        public decimal Rpt3NewResidualValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int DepOnDisposal { get; set; }
        public decimal OrigCurrPerDepn { get; set; }
        public decimal DocOrigCurrPerDepn { get; set; }
        public decimal Rpt1OrigCurrPerDepn { get; set; }
        public decimal Rpt2OrigCurrPerDepn { get; set; }
        public decimal Rpt3OrigCurrPerDepn { get; set; }
        public decimal OrigCurrPerGrantDepn { get; set; }
        public decimal DocOrigCurrPerGrantDepn { get; set; }
        public decimal Rpt1OrigCurrPerGrantDepn { get; set; }
        public decimal Rpt2OrigCurrPerGrantDepn { get; set; }
        public decimal Rpt3OrigCurrPerGrantDepn { get; set; }

        public virtual Farevalue Farevalue { get; set; }
    }
}
