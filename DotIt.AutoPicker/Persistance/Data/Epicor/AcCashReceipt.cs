using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcCashReceipt
    {
        public string Company { get; set; }
        public decimal CashReceiptId { get; set; }
        public decimal Raid { get; set; }
        public decimal RefId { get; set; }
        public string GroupId { get; set; }
        public int Pmuid { get; set; }
        public string BankAcctId { get; set; }
        public int HeadNum { get; set; }
        public int CustNum { get; set; }
        public string CheckRef { get; set; }
        public DateTime? ApplyDate { get; set; }
        public decimal AmountReceived { get; set; }
        public string Type { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
    }
}
