using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcRoxyTrtAus
    {
        public string Company { get; set; }
        public decimal RoxyTrtId { get; set; }
        public int CustNum { get; set; }
        public DateTime? FromDt { get; set; }
        public DateTime? ToDt { get; set; }
        public bool HigherSupp { get; set; }
        public decimal SuppAmt { get; set; }
        public bool Ocsend { get; set; }
        public string OceventType { get; set; }
        public bool Ocready { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
