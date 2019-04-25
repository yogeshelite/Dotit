using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PrchkGrp
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string CreatedBy { get; set; }
        public string ActiveUserId { get; set; }
        public string BankAcctId { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? Pedate { get; set; }
        public bool PayWeekly { get; set; }
        public bool PayBiWeekly { get; set; }
        public bool PaySemiMonthly { get; set; }
        public bool PayMonthly { get; set; }
        public string PayClasses { get; set; }
        public int DeductionPeriod { get; set; }
        public bool TaxesNeeded { get; set; }
        public bool ChecksPrinted { get; set; }
        public bool RegisterPrinted { get; set; }
        public string PostErrorLog { get; set; }
        public bool UpdateAccrual { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string FilePath { get; set; }
        public int DownloadStatus { get; set; }
    }
}
