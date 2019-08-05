using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AgafipcommDocType
    {
        public string Company { get; set; }
        public string AfipcommDocType { get; set; }
        public string TranDocType { get; set; }
        public string DocumentLetter { get; set; }
        public string Afipcode { get; set; }
        public string Cotcode { get; set; }
        public bool SignInversion { get; set; }
        public bool InDuplicateInvoice { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
