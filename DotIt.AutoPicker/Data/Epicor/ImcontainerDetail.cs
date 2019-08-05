using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImcontainerDetail
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
        public decimal ContainerShipQty { get; set; }
        public string ShipQtyUom { get; set; }
        public string Comment { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int PorelNum { get; set; }
        public string PackSlip { get; set; }
        public decimal Volume { get; set; }
        public string VolumeUom { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public decimal Lcamt { get; set; }
        public decimal Weight { get; set; }
        public string NetWeightUom { get; set; }
        public decimal OurUnitCost { get; set; }
        public decimal DocOurUnitCost { get; set; }
        public decimal Rpt1OurUnitCost { get; set; }
        public decimal Rpt2OurUnitCost { get; set; }
        public decimal Rpt3OurUnitCost { get; set; }
        public int OrigCountryNum { get; set; }
        public string ContainerLineRef { get; set; }
        public decimal ArrivedQty { get; set; }
        public string ArrivedQtyUom { get; set; }
        public decimal ReceivedQty { get; set; }
        public string ReceivedQtyUom { get; set; }
        public string ShipStatus { get; set; }
        public decimal UpliftPercent { get; set; }
        public decimal LcdutyAmt { get; set; }
        public decimal LcindCost { get; set; }
        public decimal PotransValue { get; set; }
        public decimal ExtTransValue { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string CommodityCode { get; set; }
        public DateTime? ArrivedDate { get; set; }
        public decimal LcspecLineDutyAmt { get; set; }
        public decimal AppliedRcptLcamt { get; set; }
        public decimal LcupliftIndCost { get; set; }
        public decimal AppliedLcvariance { get; set; }
        public decimal GrossWeight { get; set; }
        public string GrossWeightUom { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string TaxCatId { get; set; }
        public bool Taxable { get; set; }
        public string TaxExempt { get; set; }
        public decimal InAppliedLcvariance { get; set; }
        public decimal InAppliedRcptLcamt { get; set; }
        public decimal InExtTransValue { get; set; }
        public decimal InLcamt { get; set; }
        public decimal InLcdutyAmt { get; set; }
        public decimal InLcindCost { get; set; }
        public decimal InLcspecLineDutyAmt { get; set; }
        public decimal InLcupliftIndCost { get; set; }
        public decimal InPotransValue { get; set; }
        public bool NoTaxRecalc { get; set; }
    }
}
