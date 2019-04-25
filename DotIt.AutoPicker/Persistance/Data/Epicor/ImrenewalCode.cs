using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImrenewalCode
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string RenewalCode { get; set; }
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
