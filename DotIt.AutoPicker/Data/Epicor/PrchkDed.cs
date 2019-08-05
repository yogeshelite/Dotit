using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PrchkDed
    {
        public string Company { get; set; }
        public int HeadNum { get; set; }
        public string DeductionId { get; set; }
        public int DeductionNum { get; set; }
        public decimal ScheduledAmt { get; set; }
        public bool ManualCalc { get; set; }
        public int CalcOrder { get; set; }
        public decimal DeductionAmt { get; set; }
        public string ClassId { get; set; }
        public bool Posted { get; set; }
        public string EmpLink { get; set; }
        public DateTime? CheckDate { get; set; }
        public decimal PriorDedYtd { get; set; }
        public bool Voided { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int PrintHeadNum { get; set; }
    }
}
