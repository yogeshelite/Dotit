using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Prw2dtl
    {
        public string Company { get; set; }
        public int TaxYear { get; set; }
        public int ControlNum { get; set; }
        public string EmpLink { get; set; }
        public string ClassId { get; set; }
        public bool VoidW2 { get; set; }
        public decimal FitWages { get; set; }
        public decimal FitTax { get; set; }
        public decimal Sswages { get; set; }
        public decimal Sstax { get; set; }
        public decimal Sstips { get; set; }
        public decimal AllocTips { get; set; }
        public decimal MediWages { get; set; }
        public decimal MediTax { get; set; }
        public decimal AdvanceEic { get; set; }
        public decimal DependCare { get; set; }
        public decimal Nqplan { get; set; }
        public decimal FringeBenefits { get; set; }
        public bool Statutory { get; set; }
        public bool Deceased { get; set; }
        public bool Pension { get; set; }
        public bool LegalRep { get; set; }
        public bool RetirePlan { get; set; }
        public bool HouseHold { get; set; }
        public bool ThirdPartySickPay { get; set; }
        public bool DeferredComp { get; set; }
        public string State1TaxTblId { get; set; }
        public decimal State1Wages { get; set; }
        public decimal State1Tax { get; set; }
        public string State2TaxTblId { get; set; }
        public decimal State2Wages { get; set; }
        public decimal State2Tax { get; set; }
        public string Local1TaxTblId { get; set; }
        public decimal Local1Wages { get; set; }
        public decimal Local1Tax { get; set; }
        public string Local2TaxTblId { get; set; }
        public decimal Local2Wages { get; set; }
        public decimal Local2Tax { get; set; }
        public decimal MiscAmt1 { get; set; }
        public decimal MiscAmt2 { get; set; }
        public decimal MiscAmt3 { get; set; }
        public decimal MiscAmt4 { get; set; }
        public string MiscCode1 { get; set; }
        public string MiscCode2 { get; set; }
        public string MiscCode3 { get; set; }
        public string MiscCode4 { get; set; }
        public decimal OtherAmt1 { get; set; }
        public decimal OtherAmt2 { get; set; }
        public decimal OtherAmt3 { get; set; }
        public string OtherCode1 { get; set; }
        public string OtherCode2 { get; set; }
        public string OtherCode3 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string State1TaxDesc { get; set; }
        public string State2TaxDesc { get; set; }
        public string SmtrInfo { get; set; }
        public string ContactInfo { get; set; }
        public string PrefNotiCode { get; set; }
    }
}
