using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Currency
    {
        public string Company { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrDesc { get; set; }
        public string CurrSymbol { get; set; }
        public string DocumentDesc { get; set; }
        public string Note { get; set; }
        public string CurrName { get; set; }
        public string CurrencyId { get; set; }
        public int DecimalsGeneral { get; set; }
        public bool Inactive { get; set; }
        public int DecimalsPrice { get; set; }
        public bool MaintRate { get; set; }
        public int DecimalsCost { get; set; }
        public bool BaseCurr { get; set; }
        public decimal RoundMltpUnitPrice { get; set; }
        public bool ReportCurr { get; set; }
        public decimal RoundMltpUnitTax { get; set; }
        public decimal RoundMltpExtPrice { get; set; }
        public decimal RoundMltpExtTax { get; set; }
        public decimal RoundMltpTotalAmt { get; set; }
        public bool GlobalCurr { get; set; }
        public decimal RoundMltpTotalTax { get; set; }
        public bool GlobalLock { get; set; }
        public int RoundRuleUnitPrice { get; set; }
        public int ScaleFactor { get; set; }
        public int RoundRuleUnitTax { get; set; }
        public int CountryNum { get; set; }
        public int RoundRuleExtPrice { get; set; }
        public int ReportCurrPos { get; set; }
        public int RoundRuleExtTax { get; set; }
        public int RoundRuleTotalAmt { get; set; }
        public int RoundRuleTotalTax { get; set; }
        public decimal RoundTolerance { get; set; }
        public int Isonumber { get; set; }
        public string StoreId { get; set; }
        public decimal RoundMltpAnnualCharge { get; set; }
        public decimal RoundMltpPeriodCharge { get; set; }
        public int RoundRuleAnnualCharge { get; set; }
        public int RoundRulePeriodCharge { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Agafipcode { get; set; }
        public string Mxsatcode { get; set; }
        public string Mxsatdesc { get; set; }
        public string IsocurrCode { get; set; }
        public long ProcessorNum { get; set; }
    }
}
