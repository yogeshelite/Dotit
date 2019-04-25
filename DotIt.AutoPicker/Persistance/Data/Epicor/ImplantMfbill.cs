using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImplantMfbill
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Plant { get; set; }
        public string PayBtflag { get; set; }
        public string PayTypeDesc { get; set; }
        public string PayAccount { get; set; }
        public string PayBtaddress1 { get; set; }
        public string PayBtaddress2 { get; set; }
        public string PayBtaddress3 { get; set; }
        public string PayBtcity { get; set; }
        public string PayBtstate { get; set; }
        public string PayBtzip { get; set; }
        public string PayBtcountry { get; set; }
        public int PayBtcountryNum { get; set; }
        public string PayBtphone { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
