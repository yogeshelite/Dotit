﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CurrExChain
    {
        public string Company { get; set; }
        public string TableName { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string Key4 { get; set; }
        public string Key5 { get; set; }
        public string Key6 { get; set; }
        public string Key7 { get; set; }
        public string Key8 { get; set; }
        public string TargetCurrCode { get; set; }
        public int Step { get; set; }
        public string FromCurrCode { get; set; }
        public string ToCurrCode { get; set; }
        public int RuleCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool Round { get; set; }
        public int RoundDec { get; set; }
        public bool DisplayStep { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
