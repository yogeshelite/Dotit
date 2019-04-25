using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TranDocType
    {
        public string Company { get; set; }
        public string TranDocTypeId { get; set; }
        public string Description { get; set; }
        public string SystemTranId { get; set; }
        public bool Inactive { get; set; }
        public bool SystemTranDefault { get; set; }
        public bool RedStorno { get; set; }
        public string GuiformatCode { get; set; }
        public string GuitaxTypeCode { get; set; }
        public string GuideductCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Agagipcode { get; set; }
        public string Agarbacode { get; set; }
        public string Agcomarbcode { get; set; }
        public string AgdefaultLetter { get; set; }
        public bool Returns { get; set; }
        public bool AllUsers { get; set; }
        public bool Penrinvoices { get; set; }
        public bool Einvoice { get; set; }
        public bool PostTaxDeclaration { get; set; }
        public string TwgenerationType { get; set; }
        public bool InisExcisable { get; set; }
        public string InexportType { get; set; }
        public string InpurchaseType { get; set; }
        public bool InisServiceType { get; set; }
        public string PesunatTdt { get; set; }
        public bool SelfInvoice { get; set; }
    }
}
