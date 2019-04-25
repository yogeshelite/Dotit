using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CreditCardProcessor
    {
        public string Company { get; set; }
        public long ProcessorNum { get; set; }
        public string Processor { get; set; }
        public string ProcessorDesc { get; set; }
        public string Partner { get; set; }
        public string PartnerUser { get; set; }
        public string PartnerVendor { get; set; }
        public string PartnerPwd { get; set; }
        public string Tppid { get; set; }
        public string FdmsgroupId { get; set; }
        public string FdmscustomerId { get; set; }
        public string FdmsphoneNum { get; set; }
        public string BankAcctId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
