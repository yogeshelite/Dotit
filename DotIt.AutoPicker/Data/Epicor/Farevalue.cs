using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Farevalue
    {
        public Farevalue()
        {
            FarevalueReg = new HashSet<FarevalueReg>();
        }

        public string Company { get; set; }
        public string AssetNum { get; set; }
        public int RevalueNum { get; set; }
        public string Description { get; set; }
        public DateTime? ApplyDate { get; set; }
        public bool ReadyToPost { get; set; }
        public bool Posted { get; set; }
        public DateTime? PostDate { get; set; }
        public string CurrencyCode { get; set; }
        public string RateGrpCode { get; set; }
        public string PostedBy { get; set; }
        public string JournalCode { get; set; }
        public int JournalNum { get; set; }
        public decimal NewBookValue { get; set; }
        public decimal DocNewBookValue { get; set; }
        public decimal Rpt1NewBookValue { get; set; }
        public decimal Rpt2NewBookValue { get; set; }
        public decimal Rpt3NewBookValue { get; set; }
        public string RevalueMethod { get; set; }
        public bool CostLimitApplied { get; set; }
        public bool HdrCostRecorded { get; set; }
        public string RecordedRegList { get; set; }
        public DateTime? ValuationDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }

        public virtual ICollection<FarevalueReg> FarevalueReg { get; set; }
    }
}
