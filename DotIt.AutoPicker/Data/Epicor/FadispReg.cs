using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FadispReg
    {
        public string Company { get; set; }
        public string AssetNum { get; set; }
        public int DisposalNum { get; set; }
        public string AssetRegId { get; set; }
        public decimal PrevDepreciation { get; set; }
        public decimal CurrDepreciation { get; set; }
        public decimal BookValue { get; set; }
        public decimal DocPrevDepreciation { get; set; }
        public decimal DocCurrDepreciation { get; set; }
        public decimal DocBookValue { get; set; }
        public decimal Rpt1PrevDepreciation { get; set; }
        public decimal Rpt1CurrDepreciation { get; set; }
        public decimal Rpt1BookValue { get; set; }
        public decimal Rpt2PrevDepreciation { get; set; }
        public decimal Rpt2CurrDepreciation { get; set; }
        public decimal Rpt2BookValue { get; set; }
        public decimal Rpt3PrevDepreciation { get; set; }
        public decimal Rpt3CurrDepreciation { get; set; }
        public decimal Rpt3BookValue { get; set; }
        public decimal GrantBookValue { get; set; }
        public decimal PrevGrantDep { get; set; }
        public decimal CurrGrantDep { get; set; }
        public decimal DocGrantBookValue { get; set; }
        public decimal DocPrevGrantDep { get; set; }
        public decimal DocCurrGrantDep { get; set; }
        public decimal Rpt1GrantBookValue { get; set; }
        public decimal Rpt1PrevGrantDep { get; set; }
        public decimal Rpt1CurrGrantDep { get; set; }
        public decimal Rpt2GrantBookValue { get; set; }
        public decimal Rpt2PrevGrantDep { get; set; }
        public decimal Rpt2CurrGrantDep { get; set; }
        public decimal Rpt3GrantBookValue { get; set; }
        public decimal Rpt3PrevGrantDep { get; set; }
        public decimal Rpt3CurrGrantDep { get; set; }
        public decimal GrantAmt { get; set; }
        public decimal DocGrantAmt { get; set; }
        public decimal Rpt1GrantAmt { get; set; }
        public decimal Rpt2GrantAmt { get; set; }
        public decimal Rpt3GrantAmt { get; set; }
        public decimal DisposalCost { get; set; }
        public decimal DocDisposalCost { get; set; }
        public decimal Rpt1DisposalCost { get; set; }
        public decimal Rpt2DisposalCost { get; set; }
        public decimal Rpt3DisposalCost { get; set; }
        public decimal Proceed { get; set; }
        public decimal DocProceed { get; set; }
        public decimal Rpt1Proceed { get; set; }
        public decimal Rpt2Proceed { get; set; }
        public decimal Rpt3Proceed { get; set; }
        public decimal DocProceedInvBal { get; set; }
        public decimal AssetBalOurQty { get; set; }
        public string AssetQtyIum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int DepOnDisposal { get; set; }
    }
}
