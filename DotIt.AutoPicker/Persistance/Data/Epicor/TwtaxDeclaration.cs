using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TwtaxDeclaration
    {
        public string Company { get; set; }
        public int DeclareYear { get; set; }
        public int DeclarePeriod { get; set; }
        public string Guisource { get; set; }
        public string GuiformatCode { get; set; }
        public string TranDocType { get; set; }
        public string InvoiceNum { get; set; }
        public string LegalNumber { get; set; }
        public string GuitaxTypeCode { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public bool TaxInPrice { get; set; }
        public DateTime? ExportDate { get; set; }
        public string ExportBillNum { get; set; }
        public string ExportBillType { get; set; }
        public string ExportMark { get; set; }
        public string ExportType { get; set; }
        public decimal ImportTaxBasis { get; set; }
        public decimal ImportTaxAmt { get; set; }
        public string GuideductCode { get; set; }
        public string SellerGuicode { get; set; }
        public string BuyerGuicode { get; set; }
        public decimal AmtExclTax { get; set; }
        public decimal TaxAmt { get; set; }
        public bool ManualInsert { get; set; }
        public int PartnerNum { get; set; }
        public string Guigroup { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
