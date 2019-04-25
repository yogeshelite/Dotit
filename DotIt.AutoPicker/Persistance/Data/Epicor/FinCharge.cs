using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class FinCharge
    {
        public string Company { get; set; }
        public string ChargeCode { get; set; }
        public decimal MinChrgAmt { get; set; }
        public decimal MaxChrgAmt { get; set; }
        public int PayProcDays { get; set; }
        public string LineDesc { get; set; }
        public string FinInvTerms { get; set; }
        public bool ConsiderAdvInv { get; set; }
        public bool ConsiderFcinv { get; set; }
        public string ChargeDesc { get; set; }
        public bool ConsiderCm { get; set; }
        public string MiscCode { get; set; }
        public bool OpenInvoices { get; set; }
        public bool SettledInvoices { get; set; }
        public decimal PerInvoice { get; set; }
        public decimal PerCustomer { get; set; }
        public string TaxCatId { get; set; }
        public string TranDocTypeId { get; set; }
        public string IncomeTaxCode { get; set; }
        public bool GlobalFinCharge { get; set; }
        public bool GlobalLock { get; set; }
        public string DefaultTranDocTypeId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
