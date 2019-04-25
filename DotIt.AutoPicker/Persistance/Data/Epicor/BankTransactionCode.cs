using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BankTransactionCode
    {
        public string Company { get; set; }
        public string BankTransCode { get; set; }
        public string TranTemplateId { get; set; }
        public string Description { get; set; }
        public string BankTransType { get; set; }
        public string BankFeeId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string DebitCredit { get; set; }
        public bool Reverse { get; set; }
    }
}
