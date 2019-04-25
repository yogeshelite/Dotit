using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImcontainerHeader
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int ContainerId { get; set; }
        public DateTime? ShipDate { get; set; }
        public bool Shipped { get; set; }
        public string ContainerClass { get; set; }
        public decimal ContainerCost { get; set; }
        public int ShippingDays { get; set; }
        public string ContainerComments { get; set; }
        public string ContainerDescription { get; set; }
        public bool NewPoRelAtReceipt { get; set; }
        public decimal Volume { get; set; }
        public string VolumeUom { get; set; }
        public decimal CostPerVolume { get; set; }
        public string ContainerReference { get; set; }
        public string Lcreference { get; set; }
        public string Lccomment { get; set; }
        public decimal Lcvariance { get; set; }
        public string LcdisburseMethod { get; set; }
        public string CurrencyCode { get; set; }
        public bool LockRate { get; set; }
        public decimal ExchangeRate { get; set; }
        public DateTime? CurrencyDate { get; set; }
        public decimal DocContainerCost { get; set; }
        public string PorelShipOption { get; set; }
        public decimal Rpt1ContainerCost { get; set; }
        public decimal Rpt2ContainerCost { get; set; }
        public decimal Rpt3ContainerCost { get; set; }
        public string RateGrpCode { get; set; }
        public string LoadPortId { get; set; }
        public string DechargePortId { get; set; }
        public string ShipViaCode { get; set; }
        public string Fob { get; set; }
        public int ContainerCount { get; set; }
        public int PackageCount { get; set; }
        public decimal Weight { get; set; }
        public string WeightUom { get; set; }
        public decimal UpliftPercent { get; set; }
        public int VendorNum { get; set; }
        public int ConNum { get; set; }
        public string Bolading { get; set; }
        public string Boexchange { get; set; }
        public string ShipStatus { get; set; }
        public string PorelRcptOption { get; set; }
        public string ImportNum { get; set; }
        public string Vessel { get; set; }
        public decimal SpecDutyAmt { get; set; }
        public decimal AppliedLcamt { get; set; }
        public decimal ContainerDutyAmt { get; set; }
        public decimal ContainerIndCost { get; set; }
        public bool ApplyToLc { get; set; }
        public DateTime? ArrivedDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string PurPoint { get; set; }
        public decimal AppliedRcptLcamt { get; set; }
        public decimal UpliftIndCost { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal AppliedLcvariance { get; set; }
        public int ImportedFrom { get; set; }
        public string ImportedFromDesc { get; set; }
        public string TranDocTypeId { get; set; }
        public string LegalNumber { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int AdditionalShippingDays { get; set; }
        public DateTime? EstimatedArrivalDate { get; set; }
        public DateTime? NeedByDate { get; set; }
        public DateTime? PromiseDate { get; set; }
        public bool TaxesCalculated { get; set; }
        public decimal InAppliedLcamt { get; set; }
        public decimal InAppliedLcvariance { get; set; }
        public decimal InAppliedRcptLcamt { get; set; }
        public decimal InContainerCost { get; set; }
        public decimal InContainerDutyAmt { get; set; }
        public decimal InContainerIndCost { get; set; }
        public decimal InDocContainerCost { get; set; }
        public decimal InLcappliedAmt { get; set; }
        public decimal InLcvariance { get; set; }
        public decimal InSpecDutyAmt { get; set; }
        public decimal InUpliftIndCost { get; set; }
    }
}
