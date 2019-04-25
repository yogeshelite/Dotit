using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Cnsyst
    {
        public string Company { get; set; }
        public string EntryPerson { get; set; }
        public string Verifier { get; set; }
        public string Cashier { get; set; }
        public string PrintPerson { get; set; }
        public string BookId { get; set; }
        public string CompanyGroup { get; set; }
        public string CompanyType { get; set; }
        public string Industry { get; set; }
        public string IndustryCode { get; set; }
        public string RegionCode { get; set; }
        public string OrganizationCode { get; set; }
        public string SoftwareSupplierName { get; set; }
        public string SoftwareVersion { get; set; }
        public string DefaultTaxType { get; set; }
        public string DefaultTaxRateCode { get; set; }
        public bool VatinvcLimit { get; set; }
        public decimal VatinvcLimitAmt { get; set; }
        public string InvoiceManager { get; set; }
        public string InvoiceCollector { get; set; }
        public bool PriceIncludeTax { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
