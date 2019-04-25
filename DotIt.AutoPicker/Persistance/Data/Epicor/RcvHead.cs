using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RcvHead
    {
        public RcvHead()
        {
            RcvHeadTax = new HashSet<RcvHeadTax>();
        }

        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public string PackSlip { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string EntryPerson { get; set; }
        public bool SaveForInvoicing { get; set; }
        public bool Invoiced { get; set; }
        public string ReceiptComment { get; set; }
        public string ReceivePerson { get; set; }
        public string ShipViaCode { get; set; }
        public DateTime? EntryDate { get; set; }
        public string Plant { get; set; }
        public int Ponum { get; set; }
        public string Lcreference { get; set; }
        public string Lccomment { get; set; }
        public decimal LandedCost { get; set; }
        public string LegalNumber { get; set; }
        public decimal Lcvariance { get; set; }
        public bool Iclinked { get; set; }
        public string GlbCompany { get; set; }
        public int GlbVendorNum { get; set; }
        public string GlbPurPoint { get; set; }
        public string GlbPackSlip { get; set; }
        public int ContainerId { get; set; }
        public decimal Weight { get; set; }
        public string LcdisburseMethod { get; set; }
        public bool AutoReceipt { get; set; }
        public string AutoTranType { get; set; }
        public string Potype { get; set; }
        public int AutoTranId { get; set; }
        public string WeightUom { get; set; }
        public decimal UpliftPercent { get; set; }
        public decimal SpecDutyAmt { get; set; }
        public decimal AppliedLcamt { get; set; }
        public decimal LcdutyAmt { get; set; }
        public decimal LcindCost { get; set; }
        public bool ApplyToLc { get; set; }
        public bool Received { get; set; }
        public DateTime? ArrivedDate { get; set; }
        public decimal AppliedRcptLcamt { get; set; }
        public decimal LcupliftIndCost { get; set; }
        public decimal AppliedLcvariance { get; set; }
        public string TranDocTypeId { get; set; }
        public string ImportNum { get; set; }
        public int ImportedFrom { get; set; }
        public string ImportedFromDesc { get; set; }
        public decimal GrossWeight { get; set; }
        public string GrossWeightUom { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string TaxRegionCode { get; set; }
        public DateTime? TaxPoint { get; set; }
        public DateTime? TaxRateDate { get; set; }
        public bool InPrice { get; set; }
        public bool HdrTaxNoUpdt { get; set; }
        public string TaxRateGrpCode { get; set; }
        public bool TaxesCalculated { get; set; }
        public decimal InAppliedLcamt { get; set; }
        public decimal InAppliedLcvariance { get; set; }
        public decimal InAppliedRcptLcamt { get; set; }
        public decimal InLandedCost { get; set; }
        public decimal InLcdutyAmt { get; set; }
        public decimal InLcindCost { get; set; }
        public decimal InLcupliftIndCost { get; set; }
        public decimal InLcvariance { get; set; }
        public decimal InSpecDutyAmt { get; set; }

        public virtual RcvHeadUd RcvHeadUd { get; set; }
        public virtual ICollection<RcvHeadTax> RcvHeadTax { get; set; }
    }
}
