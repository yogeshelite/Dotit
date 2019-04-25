using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class VendRemitTo
    {
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public int RemitToSeq { get; set; }
        public string RemitToType { get; set; }
        public int RemitCustNum { get; set; }
        public string RemitEmpId { get; set; }
        public int RemitVendorNum { get; set; }
        public string RemitToName { get; set; }
        public bool DefaultRemitTo { get; set; }
        public bool Inactive { get; set; }
        public bool OneCheck { get; set; }
        public string Comments { get; set; }
        public string RemitToAddress1 { get; set; }
        public string RemitToAddress2 { get; set; }
        public string RemitToAddress3 { get; set; }
        public string RemitToCity { get; set; }
        public string RemitToState { get; set; }
        public string RemitToZip { get; set; }
        public int RemitToCountry { get; set; }
        public string RemitToPhoneNum { get; set; }
        public string RemitToFaxNum { get; set; }
        public string RemitToEmail { get; set; }
        public string TermsCode { get; set; }
        public string CurrencyCode { get; set; }
        public int Pmuid { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
