﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BankBal
    {
        public string Company { get; set; }
        public string BankAcctId { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal DbBalance { get; set; }
        public decimal CrBalance { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal DocDbBalance { get; set; }
        public decimal DocCrBalance { get; set; }
        public decimal DocOpeningBalance { get; set; }
        public decimal Rpt1CrBalance { get; set; }
        public decimal Rpt2CrBalance { get; set; }
        public decimal Rpt3CrBalance { get; set; }
        public decimal Rpt1DbBalance { get; set; }
        public decimal Rpt2DbBalance { get; set; }
        public decimal Rpt3DbBalance { get; set; }
        public decimal Rpt1OpeningBalance { get; set; }
        public decimal Rpt2OpeningBalance { get; set; }
        public decimal Rpt3OpeningBalance { get; set; }
        public string RateGrpCode { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal OpeningBalanceRec { get; set; }
        public decimal CrBalanceRec { get; set; }
        public decimal DbBalanceRec { get; set; }
        public decimal DocOpeningBalanceRec { get; set; }
        public decimal DocCrBalanceRec { get; set; }
        public decimal DocDbBalanceRec { get; set; }
        public decimal Rpt1OpeningBalanceRec { get; set; }
        public decimal Rpt1CrBalanceRec { get; set; }
        public decimal Rpt1DbBalanceRec { get; set; }
        public decimal Rpt2OpeningBalanceRec { get; set; }
        public decimal Rpt2CrBalanceRec { get; set; }
        public decimal Rpt2DbBalanceRec { get; set; }
        public decimal Rpt3OpeningBalanceRec { get; set; }
        public decimal Rpt3CrBalanceRec { get; set; }
        public decimal Rpt3DbBalanceRec { get; set; }
    }
}
