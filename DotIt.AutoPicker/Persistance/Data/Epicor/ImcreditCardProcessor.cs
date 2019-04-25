using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImcreditCardProcessor
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
