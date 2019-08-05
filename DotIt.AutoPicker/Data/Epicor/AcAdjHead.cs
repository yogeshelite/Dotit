using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcAdjHead
    {
        public string Company { get; set; }
        public decimal AdjHeadId { get; set; }
        public decimal AdjGrpId { get; set; }
        public int ClientCustNum { get; set; }
        public int CustNum { get; set; }
        public string CustId { get; set; }
        public DateTime? AdjustmentDate { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public decimal Raid { get; set; }
        public string Btname { get; set; }
        public string Btaddress1 { get; set; }
        public string Btaddress2 { get; set; }
        public string Btaddress3 { get; set; }
        public string Btcity { get; set; }
        public string Btstate { get; set; }
        public string Btzip { get; set; }
        public string Btcountry { get; set; }
        public int BtcountryNum { get; set; }
        public int CheckNum { get; set; }
        public string BankId { get; set; }
        public string BankName { get; set; }
        public string BankIdentifier { get; set; }
        public int BankCountry { get; set; }
        public string BankPostalCode { get; set; }
        public string BankCity { get; set; }
        public string BankAcctNumber { get; set; }
        public string BankAddress1 { get; set; }
        public string BankAddress2 { get; set; }
        public string BankAddress3 { get; set; }
        public string BankState { get; set; }
        public string BankNameOnAccount { get; set; }
    }
}
