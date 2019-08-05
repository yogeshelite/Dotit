using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ContainerDutyTax
    {
        public string Company { get; set; }
        public int ContainerId { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int PorelNum { get; set; }
        public int DutySeq { get; set; }
        public string TaxCode { get; set; }
        public string RateCode { get; set; }
        public int EcacquisitionSeq { get; set; }
        public string TariffCode { get; set; }
        public decimal ReportableAmt { get; set; }
        public decimal DocReportableAmt { get; set; }
        public decimal TaxableAmt { get; set; }
        public decimal DocTaxableAmt { get; set; }
        public decimal Percent { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal DocTaxAmt { get; set; }
        public bool Manual { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public bool ReverseCharge { get; set; }
        public decimal Rpt1ReportableAmt { get; set; }
        public decimal Rpt2ReportableAmt { get; set; }
        public decimal Rpt3ReportableAmt { get; set; }
        public decimal Rpt1TaxableAmt { get; set; }
        public decimal Rpt2TaxableAmt { get; set; }
        public decimal Rpt3TaxableAmt { get; set; }
        public decimal Rpt1TaxAmt { get; set; }
        public decimal Rpt2TaxAmt { get; set; }
        public decimal Rpt3TaxAmt { get; set; }
        public int CollectionType { get; set; }
        public int Timing { get; set; }
        public int ExemptType { get; set; }
        public decimal ExemptPercent { get; set; }
        public string ResolutionNum { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public DateTime? TaxRateDate { get; set; }
        public decimal DefTaxableAmt { get; set; }
        public decimal DocDefTaxableAmt { get; set; }
        public decimal Rpt1DefTaxableAmt { get; set; }
        public decimal Rpt2DefTaxableAmt { get; set; }
        public decimal Rpt3DefTaxableAmt { get; set; }
        public decimal DefTaxAmt { get; set; }
        public decimal DocDefTaxAmt { get; set; }
        public decimal Rpt1DefTaxAmt { get; set; }
        public decimal Rpt2DefTaxAmt { get; set; }
        public decimal Rpt3DefTaxAmt { get; set; }
        public bool ManAdd { get; set; }
        public decimal DedTaxAmt { get; set; }
        public decimal DocDedTaxAmt { get; set; }
        public decimal Rpt1DedTaxAmt { get; set; }
        public decimal Rpt2DedTaxAmt { get; set; }
        public decimal Rpt3DedTaxAmt { get; set; }
        public decimal FixedAmount { get; set; }
        public decimal DocFixedAmount { get; set; }
        public decimal Rpt1FixedAmount { get; set; }
        public decimal Rpt2FixedAmount { get; set; }
        public decimal Rpt3FixedAmount { get; set; }
        public string TextCode { get; set; }
        public decimal TaxAmtVar { get; set; }
        public decimal DocTaxAmtVar { get; set; }
        public decimal Rpt1TaxAmtVar { get; set; }
        public decimal Rpt2TaxAmtVar { get; set; }
        public decimal Rpt3TaxAmtVar { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ContainerDuty ContainerDuty { get; set; }
    }
}
