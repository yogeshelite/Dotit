using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PitypeFee
    {
        public string Company { get; set; }
        public string Pitype { get; set; }
        public string Pistatus { get; set; }
        public string BankFeeId { get; set; }
        public decimal FeeAmount { get; set; }
        public decimal FeePercent { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
