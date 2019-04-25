using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Ingstr2transaction
    {
        public string Company { get; set; }
        public Guid ExternalSysRowId { get; set; }
        public int AptransactionType { get; set; }
        public int ApvendorNum { get; set; }
        public string ApinvoiceNum { get; set; }
        public string Apgstid { get; set; }
        public string ApbusinessCategory { get; set; }
        public string AptaxRegionCode { get; set; }
        public string ApintaxLiabilityType { get; set; }
        public string ApimportNum { get; set; }
        public DateTime? ApinvoiceDate { get; set; }
        public decimal ApinvoiceAmt { get; set; }
        public decimal AplineTotal { get; set; }
        public string AplinePartNum { get; set; }
        public string AplineDescription { get; set; }
        public int ApinvoiceLine { get; set; }
        public string AplineCommodityCode { get; set; }
        public decimal AplineTaxableAmt { get; set; }
        public string AplineTaxCode { get; set; }
        public string AplineIndirectTaxType { get; set; }
        public decimal AplineIgstrate { get; set; }
        public decimal AplineIgsttaxAmt { get; set; }
        public decimal AplineCgstrate { get; set; }
        public decimal AplineCgsttaxAmt { get; set; }
        public decimal AplineSgstrate { get; set; }
        public decimal AplineSgsttaxAmt { get; set; }
        public decimal Apitcigstamt { get; set; }
        public decimal Apitccgstamt { get; set; }
        public decimal Apitcsgstamt { get; set; }
        public decimal ApitcclaimIgstamt { get; set; }
        public decimal ApitcclaimCgstamt { get; set; }
        public decimal ApitcclaimSgstamt { get; set; }
        public decimal AptotalItcadmissible { get; set; }
        public decimal ApitcadmissibleMonth { get; set; }
        public DateTime? ImportDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
