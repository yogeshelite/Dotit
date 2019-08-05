﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FassetDtlHist
    {
        public string Company { get; set; }
        public string AssetNum { get; set; }
        public string AssetRegId { get; set; }
        public string CalendarId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int YearNum { get; set; }
        public bool NotDepreciate { get; set; }
        public bool AdditionSpread { get; set; }
        public string SpreadCode { get; set; }
        public string LifeModifier { get; set; }
        public decimal AnnualDepRate { get; set; }
        public int AssetLife { get; set; }
        public decimal CyopenCost { get; set; }
        public decimal CyopenDepn { get; set; }
        public decimal CyopenBookValue { get; set; }
        public decimal CyaddPrevDepn { get; set; }
        public decimal CyaddCurrDepn { get; set; }
        public decimal CyaddBookvalue { get; set; }
        public decimal CydispPrevDepn { get; set; }
        public decimal CydispCurrDepn { get; set; }
        public decimal CydispBookvalue { get; set; }
        public decimal CydispProceeds { get; set; }
        public decimal CydispProfit { get; set; }
        public decimal CurrentCostvalue { get; set; }
        public decimal CurrentPrevYearDepn { get; set; }
        public decimal CurrentPostedDepn { get; set; }
        public decimal CurrentBookvalue { get; set; }
        public decimal CurrentUnpostedDepn { get; set; }
        public decimal CurrentYebookvalue { get; set; }
        public string AssetMethod { get; set; }
        public string BookId { get; set; }
        public string DepConvention { get; set; }
        public bool RetroAdjust { get; set; }
        public string ProdUnitSpread { get; set; }
        public decimal TotalProdUnit { get; set; }
        public decimal AnnualFixedValue { get; set; }
        public string AnnualSpread { get; set; }
        public decimal PeriodFixedValue { get; set; }
        public string PeriodSpread { get; set; }
        public string PeriodRateSpread { get; set; }
        public string FinalSpread { get; set; }
        public bool MethodSwitched { get; set; }
        public string AltAssetMethod { get; set; }
        public decimal DocCurrentCostvalue { get; set; }
        public decimal DocCurrentPrevYearDepn { get; set; }
        public decimal DocCurrentPostedDepn { get; set; }
        public decimal DocCurrentBookvalue { get; set; }
        public decimal DocCurrentUnpostedDepn { get; set; }
        public decimal DocCurrentYebookvalue { get; set; }
        public decimal Rpt1CurrentCostvalue { get; set; }
        public decimal Rpt1CurrentPrevYearDepn { get; set; }
        public decimal Rpt1CurrentPostedDepn { get; set; }
        public decimal Rpt1CurrentBookvalue { get; set; }
        public decimal Rpt1CurrentUnpostedDepn { get; set; }
        public decimal Rpt1CurrentYebookvalue { get; set; }
        public decimal Rpt2CurrentCostvalue { get; set; }
        public decimal Rpt2CurrentPrevYearDepn { get; set; }
        public decimal Rpt2CurrentPostedDepn { get; set; }
        public decimal Rpt2CurrentBookvalue { get; set; }
        public decimal Rpt2CurrentUnpostedDepn { get; set; }
        public decimal Rpt2CurrentYebookvalue { get; set; }
        public decimal Rpt3CurrentCostvalue { get; set; }
        public decimal Rpt3CurrentPrevYearDepn { get; set; }
        public decimal Rpt3CurrentPostedDepn { get; set; }
        public decimal Rpt3CurrentBookvalue { get; set; }
        public decimal Rpt3CurrentUnpostedDepn { get; set; }
        public decimal Rpt3CurrentYebookvalue { get; set; }
        public bool UseFinalSpread { get; set; }
        public bool DepRecalcNeeded { get; set; }
        public decimal CurrentGrantAmt { get; set; }
        public decimal CurrentGrantPydepn { get; set; }
        public decimal CurrentGrantPostedDepn { get; set; }
        public decimal CurrentGrantBookValue { get; set; }
        public decimal CurrentGrantUnpostedDepn { get; set; }
        public decimal CurrentGrantYebookValue { get; set; }
        public decimal DocCurrentGrantAmt { get; set; }
        public decimal DocCurrentGrantPydepn { get; set; }
        public decimal DocCurrentGrantPostedDepn { get; set; }
        public decimal DocCurrentGrantBookValue { get; set; }
        public decimal DocCurrentGrantUnpostedDepn { get; set; }
        public decimal DocCurrentGrantYebookValue { get; set; }
        public decimal Rpt1CurrentGrantAmt { get; set; }
        public decimal Rpt1CurrentGrantPydepn { get; set; }
        public decimal Rpt1CurrentGrantPostedDepn { get; set; }
        public decimal Rpt1CurrentGrantBookValue { get; set; }
        public decimal Rpt1CurrentGrantUnpostedDepn { get; set; }
        public decimal Rpt1CurrentGrantYebookValue { get; set; }
        public decimal Rpt2CurrentGrantAmt { get; set; }
        public decimal Rpt2CurrentGrantPydepn { get; set; }
        public decimal Rpt2CurrentGrantPostedDepn { get; set; }
        public decimal Rpt2CurrentGrantBookValue { get; set; }
        public decimal Rpt2CurrentGrantUnpostedDepn { get; set; }
        public decimal Rpt2CurrentGrantYebookValue { get; set; }
        public decimal Rpt3CurrentGrantAmt { get; set; }
        public decimal Rpt3CurrentGrantPydepn { get; set; }
        public decimal Rpt3CurrentGrantPostedDepn { get; set; }
        public decimal Rpt3CurrentGrantBookValue { get; set; }
        public decimal Rpt3CurrentGrantUnpostedDepn { get; set; }
        public decimal Rpt3CurrentGrantYebookValue { get; set; }
        public decimal CyopenGrant { get; set; }
        public decimal CyopenGrantDepn { get; set; }
        public decimal CyaddCost { get; set; }
        public decimal CydispCost { get; set; }
        public decimal DocCyaddCost { get; set; }
        public decimal DocCydispCost { get; set; }
        public decimal Rpt1CyaddCost { get; set; }
        public decimal Rpt1CydispCost { get; set; }
        public decimal Rpt2CyaddCost { get; set; }
        public decimal Rpt2CydispCost { get; set; }
        public decimal Rpt3CyaddCost { get; set; }
        public decimal Rpt3CydispCost { get; set; }
        public decimal CyimpCost { get; set; }
        public decimal DocCyimpCost { get; set; }
        public decimal Rpt1CyimpCost { get; set; }
        public decimal Rpt2CyimpCost { get; set; }
        public decimal Rpt3CyimpCost { get; set; }
        public decimal DocCyopenCost { get; set; }
        public decimal Rpt1CyopenCost { get; set; }
        public decimal Rpt2CyopenCost { get; set; }
        public decimal Rpt3CyopenCost { get; set; }
        public decimal DocCyopenGrant { get; set; }
        public decimal Rpt1CyopenGrant { get; set; }
        public decimal Rpt2CyopenGrant { get; set; }
        public decimal Rpt3CyopenGrant { get; set; }
        public decimal DocCydispProceeds { get; set; }
        public decimal DocCydispProfit { get; set; }
        public decimal Rpt1CydispProceeds { get; set; }
        public decimal Rpt1CydispProfit { get; set; }
        public decimal Rpt2CydispProceeds { get; set; }
        public decimal Rpt2CydispProfit { get; set; }
        public decimal Rpt3CydispProceeds { get; set; }
        public decimal Rpt3CydispProfit { get; set; }
        public decimal DocCyopenDepn { get; set; }
        public decimal DocCyopenBookValue { get; set; }
        public decimal DocCyaddPrevDepn { get; set; }
        public decimal DocCyaddCurrDepn { get; set; }
        public decimal DocCyaddBookvalue { get; set; }
        public decimal DocCydispPrevDepn { get; set; }
        public decimal DocCydispCurrDepn { get; set; }
        public decimal DocCydispBookvalue { get; set; }
        public decimal Rpt1CyopenDepn { get; set; }
        public decimal Rpt1CyopenBookValue { get; set; }
        public decimal Rpt1CyaddPrevDepn { get; set; }
        public decimal Rpt1CyaddCurrDepn { get; set; }
        public decimal Rpt1CyaddBookvalue { get; set; }
        public decimal Rpt1CydispPrevDepn { get; set; }
        public decimal Rpt1CydispCurrDepn { get; set; }
        public decimal Rpt1CydispBookvalue { get; set; }
        public decimal Rpt2CyopenDepn { get; set; }
        public decimal Rpt2CyopenBookValue { get; set; }
        public decimal Rpt2CyaddPrevDepn { get; set; }
        public decimal Rpt2CyaddCurrDepn { get; set; }
        public decimal Rpt2CyaddBookvalue { get; set; }
        public decimal Rpt2CydispPrevDepn { get; set; }
        public decimal Rpt2CydispCurrDepn { get; set; }
        public decimal Rpt2CydispBookvalue { get; set; }
        public decimal Rpt3CyopenDepn { get; set; }
        public decimal Rpt3CyopenBookValue { get; set; }
        public decimal Rpt3CyaddPrevDepn { get; set; }
        public decimal Rpt3CyaddCurrDepn { get; set; }
        public decimal Rpt3CyaddBookvalue { get; set; }
        public decimal Rpt3CydispPrevDepn { get; set; }
        public decimal Rpt3CydispCurrDepn { get; set; }
        public decimal Rpt3CydispBookvalue { get; set; }
        public decimal DocCyopenGrantDepn { get; set; }
        public decimal Rpt1CyopenGrantDepn { get; set; }
        public decimal Rpt2CyopenGrantDepn { get; set; }
        public decimal Rpt3CyopenGrantDepn { get; set; }
        public DateTime? DepRecalcDate { get; set; }
        public decimal CyopenGrantBookValue { get; set; }
        public decimal InitBookValue { get; set; }
        public decimal DocInitBookValue { get; set; }
        public decimal Rpt1InitBookValue { get; set; }
        public decimal Rpt2InitBookValue { get; set; }
        public decimal Rpt3InitBookValue { get; set; }
        public decimal InitGrantBookValue { get; set; }
        public decimal DocInitGrantBookValue { get; set; }
        public decimal Rpt1InitGrantBookValue { get; set; }
        public decimal Rpt2InitGrantBookValue { get; set; }
        public decimal Rpt3InitGrantBookValue { get; set; }
        public decimal CyimpBookValue { get; set; }
        public decimal CydispGrantPrevDepn { get; set; }
        public decimal CydispGrantCurrDepn { get; set; }
        public decimal CydispGrantBookValue { get; set; }
        public decimal DocCyopenGrantBookValue { get; set; }
        public decimal DocCyimpBookValue { get; set; }
        public decimal DocCydispGrantPrevDepn { get; set; }
        public decimal DocCydispGrantCurrDepn { get; set; }
        public decimal DocCydispGrantBookValue { get; set; }
        public decimal Rpt1CyopenGrantBookValue { get; set; }
        public decimal Rpt1CyimpBookValue { get; set; }
        public decimal Rpt1CydispGrantPrevDepn { get; set; }
        public decimal Rpt1CydispGrantCurrDepn { get; set; }
        public decimal Rpt1CydispGrantBookValue { get; set; }
        public decimal Rpt2CyopenGrantBookValue { get; set; }
        public decimal Rpt2CyimpBookValue { get; set; }
        public decimal Rpt2CydispGrantPrevDepn { get; set; }
        public decimal Rpt2CydispGrantCurrDepn { get; set; }
        public decimal Rpt2CydispGrantBookValue { get; set; }
        public decimal Rpt3CyopenGrantBookValue { get; set; }
        public decimal Rpt3CyimpBookValue { get; set; }
        public decimal Rpt3CydispGrantPrevDepn { get; set; }
        public decimal Rpt3CydispGrantCurrDepn { get; set; }
        public decimal Rpt3CydispGrantBookValue { get; set; }
        public decimal CurrentActPrevDepn { get; set; }
        public decimal CurrentActPostedDepn { get; set; }
        public decimal DocCurrentActPrevDepn { get; set; }
        public decimal DocCurrentActPostedDepn { get; set; }
        public decimal Rpt1CurrentActPrevDepn { get; set; }
        public decimal Rpt1CurrentActPostedDepn { get; set; }
        public decimal Rpt2CurrentActPrevDepn { get; set; }
        public decimal Rpt2CurrentActPostedDepn { get; set; }
        public decimal Rpt3CurrentActPrevDepn { get; set; }
        public decimal Rpt3CurrentActPostedDepn { get; set; }
        public decimal CyaddGrant { get; set; }
        public decimal DocCyaddGrant { get; set; }
        public decimal Rpt1CyaddGrant { get; set; }
        public decimal Rpt2CyaddGrant { get; set; }
        public decimal Rpt3CyaddGrant { get; set; }
        public decimal CyaddGrantPrevDepn { get; set; }
        public decimal CyaddGrantCurrDepn { get; set; }
        public decimal CyaddGrantBookValue { get; set; }
        public decimal DocCyaddGrantPrevDepn { get; set; }
        public decimal DocCyaddGrantCurrDepn { get; set; }
        public decimal DocCyaddGrantBookValue { get; set; }
        public decimal Rpt1CyaddGrantPrevDepn { get; set; }
        public decimal Rpt1CyaddGrantCurrDepn { get; set; }
        public decimal Rpt1CyaddGrantBookValue { get; set; }
        public decimal Rpt2CyaddGrantPrevDepn { get; set; }
        public decimal Rpt2CyaddGrantCurrDepn { get; set; }
        public decimal Rpt2CyaddGrantBookValue { get; set; }
        public decimal Rpt3CyaddGrantPrevDepn { get; set; }
        public decimal Rpt3CyaddGrantCurrDepn { get; set; }
        public decimal Rpt3CyaddGrantBookValue { get; set; }
        public bool Depreciate { get; set; }
        public int RateFactor { get; set; }
        public decimal ResidualValue { get; set; }
        public decimal DocResidualValue { get; set; }
        public decimal Rpt1ResidualValue { get; set; }
        public decimal Rpt2ResidualValue { get; set; }
        public decimal Rpt3ResidualValue { get; set; }
        public decimal ReplaceValue { get; set; }
        public decimal DocReplaceValue { get; set; }
        public decimal Rpt1ReplaceValue { get; set; }
        public decimal Rpt2ReplaceValue { get; set; }
        public decimal Rpt3ReplaceValue { get; set; }
        public DateTime? BookValueDate { get; set; }
        public DateTime? DateSwitched { get; set; }
        public decimal CurrActGrantPydepn { get; set; }
        public decimal CurrActGrantPostedDepn { get; set; }
        public decimal DocCurrActGrantPydepn { get; set; }
        public decimal DocCurrActGrantPostedDepn { get; set; }
        public decimal Rpt1CurrActGrantPydepn { get; set; }
        public decimal Rpt1CurrActGrantPostedDepn { get; set; }
        public decimal Rpt2CurrActGrantPydepn { get; set; }
        public decimal Rpt2CurrActGrantPostedDepn { get; set; }
        public decimal Rpt3CurrActGrantPydepn { get; set; }
        public decimal Rpt3CurrActGrantPostedDepn { get; set; }
        public decimal AcquisitionCost { get; set; }
        public decimal DocAcquisitionCost { get; set; }
        public decimal Rpt1AcquisitionCost { get; set; }
        public decimal Rpt2AcquisitionCost { get; set; }
        public decimal Rpt3AcquisitionCost { get; set; }
        public decimal CydispGrant { get; set; }
        public decimal DocCydispGrant { get; set; }
        public decimal Rpt1CydispGrant { get; set; }
        public decimal Rpt2CydispGrant { get; set; }
        public decimal Rpt3CydispGrant { get; set; }
        public decimal RoundMltpAnnualCharge { get; set; }
        public decimal RoundMltpPeriodCharge { get; set; }
        public int RoundRuleAnnualCharge { get; set; }
        public int RoundRulePeriodCharge { get; set; }
        public bool AllowOverrideCost { get; set; }
        public decimal CyrevalueCost { get; set; }
        public decimal DocCyrevalueCost { get; set; }
        public decimal Rpt1CyrevalueCost { get; set; }
        public decimal Rpt2CyrevalueCost { get; set; }
        public decimal Rpt3CyrevalueCost { get; set; }
        public decimal CyrevalueBookValue { get; set; }
        public decimal DocCyrevalueBookValue { get; set; }
        public decimal Rpt1CyrevalueBookValue { get; set; }
        public decimal Rpt2CyrevalueBookValue { get; set; }
        public decimal Rpt3CyrevalueBookValue { get; set; }
        public decimal CyrevalueDepn { get; set; }
        public decimal DocCyrevalueDepn { get; set; }
        public decimal Rpt1CyrevalueDepn { get; set; }
        public decimal Rpt2CyrevalueDepn { get; set; }
        public decimal Rpt3CyrevalueDepn { get; set; }
        public decimal CyrevalueGainLoss { get; set; }
        public decimal DocCyrevalueGainLoss { get; set; }
        public decimal Rpt1CyrevalueGainLoss { get; set; }
        public decimal Rpt2CyrevalueGainLoss { get; set; }
        public decimal Rpt3CyrevalueGainLoss { get; set; }
        public decimal CydepRevalCost { get; set; }
        public decimal DocCydepRevalCost { get; set; }
        public decimal Rpt1CydepRevalCost { get; set; }
        public decimal Rpt2CydepRevalCost { get; set; }
        public decimal Rpt3CydepRevalCost { get; set; }
        public decimal CydepRevalBookValue { get; set; }
        public decimal DocCydepRevalBookValue { get; set; }
        public decimal Rpt1CydepRevalBookValue { get; set; }
        public decimal Rpt2CydepRevalBookValue { get; set; }
        public decimal Rpt3CydepRevalBookValue { get; set; }
        public decimal CydepRevalDepn { get; set; }
        public decimal DocCydepRevalDepn { get; set; }
        public decimal Rpt1CydepRevalDepn { get; set; }
        public decimal Rpt2CydepRevalDepn { get; set; }
        public decimal Rpt3CydepRevalDepn { get; set; }
        public decimal CydepRevalGainLoss { get; set; }
        public decimal DocCydepRevalGainLoss { get; set; }
        public decimal Rpt1CydepRevalGainLoss { get; set; }
        public decimal Rpt2CydepRevalGainLoss { get; set; }
        public decimal Rpt3CydepRevalGainLoss { get; set; }
        public decimal CyrevGrantGainLoss { get; set; }
        public decimal DocCyrevGrantGainLoss { get; set; }
        public decimal Rpt1CyrevGrantGainLoss { get; set; }
        public decimal Rpt2CyrevGrantGainLoss { get; set; }
        public decimal Rpt3CyrevGrantGainLoss { get; set; }
        public decimal CydepRevGrantGainLoss { get; set; }
        public decimal DocCydepRevGrantGainLoss { get; set; }
        public decimal Rpt1CydepRevGrantGainLoss { get; set; }
        public decimal Rpt2CydepRevGrantGainLoss { get; set; }
        public decimal Rpt3CydepRevGrantGainLoss { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}