using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RcvDtl
    {
        public RcvDtl()
        {
            RcvDtlTax = new HashSet<RcvDtlTax>();
        }

        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public string PackSlip { get; set; }
        public int PackLine { get; set; }
        public bool Invoiced { get; set; }
        public string InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public string PartNum { get; set; }
        public string WareHouseCode { get; set; }
        public string BinNum { get; set; }
        public decimal OurQty { get; set; }
        public string Ium { get; set; }
        public decimal OurUnitCost { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public string JobSeqType { get; set; }
        public int JobSeq { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int PorelNum { get; set; }
        public string TranReference { get; set; }
        public string PartDescription { get; set; }
        public string RevisionNum { get; set; }
        public decimal VendorQty { get; set; }
        public decimal VendorUnitCost { get; set; }
        public string ReceiptType { get; set; }
        public string ReceivedTo { get; set; }
        public bool ReceivedComplete { get; set; }
        public bool IssuedComplete { get; set; }
        public string Pum { get; set; }
        public string VenPartNum { get; set; }
        public string CostPerCode { get; set; }
        public string LotNum { get; set; }
        public int NumLabels { get; set; }
        public string DimCode { get; set; }
        public string Dum { get; set; }
        public decimal DimConvFactor { get; set; }
        public bool InspectionReq { get; set; }
        public bool InspectionPending { get; set; }
        public string InspectorId { get; set; }
        public string InspectedBy { get; set; }
        public DateTime? InspectedDate { get; set; }
        public int InspectedTime { get; set; }
        public decimal PassedQty { get; set; }
        public decimal FailedQty { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string ReasonCode { get; set; }
        public decimal TotCostVariance { get; set; }
        public decimal Weight { get; set; }
        public string WeightUom { get; set; }
        public bool NonConformnce { get; set; }
        public decimal MtlBurRate { get; set; }
        public decimal OurMtlBurUnitCost { get; set; }
        public string RefType { get; set; }
        public string RefCode { get; set; }
        public string PurchCode { get; set; }
        public bool Lcflag { get; set; }
        public string GlbCompany { get; set; }
        public int GlbVendorNum { get; set; }
        public string GlbPurPoint { get; set; }
        public string GlbPackSlip { get; set; }
        public int GlbPackLine { get; set; }
        public decimal DocUnitCost { get; set; }
        public int ContainerId { get; set; }
        public decimal Volume { get; set; }
        public decimal Rpt1UnitCost { get; set; }
        public decimal Rpt2UnitCost { get; set; }
        public decimal Rpt3UnitCost { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public int OrigCountryNum { get; set; }
        public decimal UpliftPercent { get; set; }
        public decimal LcdutyAmt { get; set; }
        public decimal LcindCost { get; set; }
        public decimal PotransValue { get; set; }
        public decimal ExtTransValue { get; set; }
        public bool Received { get; set; }
        public string CommodityCode { get; set; }
        public string Potype { get; set; }
        public bool AutoReceipt { get; set; }
        public string VolumeUom { get; set; }
        public DateTime? ArrivedDate { get; set; }
        public decimal LcspecLineDutyAmt { get; set; }
        public decimal AppliedRcptLcamt { get; set; }
        public decimal LcupliftIndCost { get; set; }
        public decimal Lcamt { get; set; }
        public decimal AppliedLcvariance { get; set; }
        public decimal LcmtlBurUnitCost { get; set; }
        public decimal DocVendorUnitCost { get; set; }
        public decimal Rpt1VendorUnitCost { get; set; }
        public decimal Rpt2VendorUnitCost { get; set; }
        public decimal Rpt3VendorUnitCost { get; set; }
        public bool NotCompliant { get; set; }
        public string ComplianceMsg { get; set; }
        public int MangCustNum { get; set; }
        public string LegalNumber { get; set; }
        public int IcpackNum { get; set; }
        public string ShipRcv { get; set; }
        public string ImportNum { get; set; }
        public int ImportedFrom { get; set; }
        public string ImportedFromDesc { get; set; }
        public decimal GrossWeight { get; set; }
        public string GrossWeightUom { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string QtyOption { get; set; }
        public bool ConvOverride { get; set; }
        public string ContractId { get; set; }
        public int SmitransNum { get; set; }
        public string Pcid { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public bool Delivered { get; set; }
        public string DeliveredComments { get; set; }
        public decimal InOurCost { get; set; }
        public decimal DocInUnitCost { get; set; }
        public decimal Rpt1InUnitCost { get; set; }
        public decimal Rpt2InUnitCost { get; set; }
        public decimal Rpt3InUnitCost { get; set; }
        public decimal InVendorUnitCost { get; set; }
        public decimal DocInVendorUnitCost { get; set; }
        public decimal Rpt1InVendorUnitCost { get; set; }
        public decimal Rpt2InVendorUnitCost { get; set; }
        public decimal Rpt3InVendorUnitCost { get; set; }
        public decimal SupplierUnInvcReceiptQty { get; set; }
        public decimal OurUnInvcReceiptQty { get; set; }
        public string TaxRegionCode { get; set; }
        public string TaxCatId { get; set; }
        public bool Taxable { get; set; }
        public string TaxExempt { get; set; }
        public bool NoTaxRecalc { get; set; }
        public decimal InAppliedLcvariance { get; set; }
        public decimal InAppliedRcptLcamt { get; set; }
        public decimal InLcamt { get; set; }
        public decimal InLcdutyAmt { get; set; }
        public decimal InLcindCost { get; set; }
        public decimal InLcmtlBurUnitCost { get; set; }
        public decimal InLcspecLineDutyAmt { get; set; }
        public decimal InLcupliftIndCost { get; set; }
        public decimal InPotransValue { get; set; }
        public bool ProjProcessed { get; set; }
        public decimal ExtNonRecoverableCost { get; set; }
        public bool EpicorFsa { get; set; }

        public virtual RcvDtlUd RcvDtlUd { get; set; }
        public virtual ICollection<RcvDtlTax> RcvDtlTax { get; set; }
    }
}
