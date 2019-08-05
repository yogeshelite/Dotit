﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FagroupReg
    {
        public string Company { get; set; }
        public string GroupCode { get; set; }
        public string AssetRegId { get; set; }
        public bool AdditionSpread { get; set; }
        public string SpreadCode { get; set; }
        public string LifeModifier { get; set; }
        public decimal AnnualDepRate { get; set; }
        public int AssetLife { get; set; }
        public string AssetMethod { get; set; }
        public string BookId { get; set; }
        public string CalendarId { get; set; }
        public string DepConvention { get; set; }
        public bool RetroAdjust { get; set; }
        public string ProdUnitSpread { get; set; }
        public decimal TotalProdUnit { get; set; }
        public decimal AnnualFixedValue { get; set; }
        public string AnnualSpread { get; set; }
        public decimal PeriodFixedValue { get; set; }
        public string PeriodSpread { get; set; }
        public string PeriodRateSpread { get; set; }
        public string FinalSpread { get; set; }
        public string AltAssetMethod { get; set; }
        public bool UseFinalSpread { get; set; }
        public bool Depreciate { get; set; }
        public int RateFactor { get; set; }
        public decimal ResidualValue { get; set; }
        public bool GlobalFagroupReg { get; set; }
        public bool GlobalLock { get; set; }
        public bool AllowCostLimit { get; set; }
        public decimal AssetCostLimit { get; set; }
        public string LimitCurrencyCode { get; set; }
        public bool AllowOverrideCost { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
