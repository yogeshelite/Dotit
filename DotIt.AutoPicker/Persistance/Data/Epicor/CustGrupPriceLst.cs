using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CustGrupPriceLst
    {
        public string Company { get; set; }
        public string GroupCode { get; set; }
        public int SeqNum { get; set; }
        public string ListCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
