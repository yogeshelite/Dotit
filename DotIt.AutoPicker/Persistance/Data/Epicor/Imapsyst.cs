using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imapsyst
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public bool SaveReceipts { get; set; }
        public bool AlwaysDiscount { get; set; }
        public bool AutoNumChk { get; set; }
        public string FmtCode { get; set; }
        public string DefaultFmtCode { get; set; }
        public int CheckPerforationLineNum { get; set; }
        public string RptFormDir { get; set; }
        public string CpayParent { get; set; }
        public string CpayCompany { get; set; }
        public bool AllowReverseCharges { get; set; }
        public decimal RoundTolerance { get; set; }
        public bool RoundInvoice { get; set; }
        public string LogInvAccting { get; set; }
        public string AuthAdmins { get; set; }
        public bool LogInvAutoAprv { get; set; }
        public string Glstage { get; set; }
        public int NextPinum { get; set; }
        public int NumDigit { get; set; }
        public int NextExpInvSeq { get; set; }
        public bool InvcReadyToCalcDflt { get; set; }
        public int ExchangeDateToUse { get; set; }
        public int LnbasedOnDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool CopyExcRateDm { get; set; }
        public bool CopyExcRateCorrInv { get; set; }
        public bool UsePodtlTaxable { get; set; }
        public bool LnreqForInvc { get; set; }
        public bool ApplyApprePayAuto { get; set; }
        public bool DatesSetUp { get; set; }
        public bool ApamdApplyDate { get; set; }
        public bool ApamdTaxPdate { get; set; }
        public bool ApamdTaxRateD { get; set; }
        public string ApdefApplyDate { get; set; }
        public string ApdefTaxPdate { get; set; }
        public string ApdefTaxRateD { get; set; }
        public string AplinkApplyDate { get; set; }
        public string AplinkTaxPdate { get; set; }
        public string AplinkTaxRateD { get; set; }
        public string TwaplegNumSource { get; set; }
        public int TwapthresholdTax { get; set; }
        public int TaxYear { get; set; }
        public string PayersTin { get; set; }
        public string NameControl { get; set; }
        public string OfficeCode { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNum { get; set; }
        public string TransControlCode { get; set; }
        public string CoextWordAmt { get; set; }
        public int DeferredExpCurr { get; set; }
        public bool AllowMultInvcReceipts { get; set; }
        public int DaysOutstanding { get; set; }
        public decimal PcntTolerance { get; set; }
        public int AmountTolerance { get; set; }
        public string TaxEntityType { get; set; }
        public string TaxEntitySubCat { get; set; }
        public string ContactPerson { get; set; }
        public string RoleCode { get; set; }
        public string BranchName { get; set; }
        public string PayersPan { get; set; }
        public string EmailAddress { get; set; }
        public string AreaCode { get; set; }
        public string FaxNum { get; set; }
        public string FutureDateAction { get; set; }
        public int FutureDateDaysHorizon { get; set; }
    }
}
