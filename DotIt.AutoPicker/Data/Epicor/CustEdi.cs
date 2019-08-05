using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CustEdi
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public bool Test { get; set; }
        public string EdidocIn { get; set; }
        public string EdidocOut { get; set; }
        public bool UseCustDefault { get; set; }
        public bool CheckForPart { get; set; }
        public bool UsePriceList { get; set; }
        public bool UseCustPart { get; set; }
        public string MapId { get; set; }
        public bool PrintInv { get; set; }
        public bool PrintAsn { get; set; }
        public bool UseDftShipTo { get; set; }
        public bool AutoPost { get; set; }
        public bool HoldOrders { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
