﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PrchkDtl
    {
        public string Company { get; set; }
        public int HeadNum { get; set; }
        public int LineNum { get; set; }
        public DateTime? PayrollDate { get; set; }
        public string PayTypeId { get; set; }
        public decimal PayRate { get; set; }
        public decimal BaseHours { get; set; }
        public decimal BasePay { get; set; }
        public string PremiumPayType { get; set; }
        public decimal PremiumHours { get; set; }
        public decimal PremiumBasePay { get; set; }
        public decimal PremiumPay { get; set; }
        public int Shift { get; set; }
        public decimal ShiftPay { get; set; }
        public string ClassId { get; set; }
        public bool Posted { get; set; }
        public string EmpLink { get; set; }
        public DateTime? CheckDate { get; set; }
        public bool FromLabor { get; set; }
        public bool Voided { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int PrintHeadNum { get; set; }
    }
}
