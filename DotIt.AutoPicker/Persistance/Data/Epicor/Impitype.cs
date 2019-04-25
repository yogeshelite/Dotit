using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Impitype
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Pitype { get; set; }
        public string Description { get; set; }
        public int Piscope { get; set; }
        public string Initiation { get; set; }
        public bool CustBankDtl { get; set; }
        public string BankAcctId { get; set; }
        public string EditypeCode { get; set; }
        public string GenType { get; set; }
        public bool DefaultType { get; set; }
        public string InitStatus { get; set; }
        public string ReconStatus { get; set; }
        public bool SupBankDtl { get; set; }
        public string Glstage { get; set; }
        public bool GlobalPitype { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
