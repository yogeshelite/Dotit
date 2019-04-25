using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PlantMfbill
    {
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
