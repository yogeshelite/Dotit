using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FsrenewalSn
    {
        public string Company { get; set; }
        public int ContractNum { get; set; }
        public int RenewalNbr { get; set; }
        public int RenewalLine { get; set; }
        public string PartNum { get; set; }
        public string SerialNumber { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
