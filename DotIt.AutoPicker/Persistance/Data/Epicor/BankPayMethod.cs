using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BankPayMethod
    {
        public string Company { get; set; }
        public string BankAcctId { get; set; }
        public int Pmuid { get; set; }
        public bool IsDefault { get; set; }
        public int Pmsource { get; set; }
        public string PaymentNumMask { get; set; }
        public string StartingSeqNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
