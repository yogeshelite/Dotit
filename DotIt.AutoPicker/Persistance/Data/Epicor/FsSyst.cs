using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class FsSyst
    {
        public string Company { get; set; }
        public int StartContractNum { get; set; }
        public int StartServiceCallNum { get; set; }
        public int ExpireHorizon { get; set; }
        public bool PrintPrice { get; set; }
        public string CallProdCode { get; set; }
        public string CallJobPrefix { get; set; }
        public bool ContractStartup { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int RenewalPeriod { get; set; }
    }
}
