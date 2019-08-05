using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbContainerClass
    {
        public string ClassCode { get; set; }
        public string Company { get; set; }
        public int ConNum { get; set; }
        public decimal ContainerCost { get; set; }
        public int ContainerCount { get; set; }
        public decimal CostPerVolume { get; set; }
        public string CurrencyCode { get; set; }
        public string DechargePortId { get; set; }
        public string Description { get; set; }
        public string Fob { get; set; }
        public string LoadPortId { get; set; }
        public int PackageCount { get; set; }
        public string PurPoint { get; set; }
        public int ShippingDays { get; set; }
        public string ShipViaCode { get; set; }
        public decimal UpliftPercent { get; set; }
        public int VendorNum { get; set; }
        public decimal Volume { get; set; }
        public string VolumeUom { get; set; }
        public decimal Weight { get; set; }
        public string WeightUom { get; set; }
        public string GlbCompany { get; set; }
        public string GlbClassCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalContainerClass { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
