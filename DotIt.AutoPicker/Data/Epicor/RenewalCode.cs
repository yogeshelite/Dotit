using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RenewalCode
    {
        public string Company { get; set; }
        public string RenewalCode1 { get; set; }
        public string RenewalDesc { get; set; }
        public int RenewalType { get; set; }
        public bool Quoted { get; set; }
        public string TaskSetId { get; set; }
        public int IncreaseMethod { get; set; }
        public decimal IncreaseAmt { get; set; }
        public decimal IncreasePct { get; set; }
        public string PriceListCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool Renewable { get; set; }
    }
}
