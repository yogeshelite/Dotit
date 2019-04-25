using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ReqDetail
    {
        public string Company { get; set; }
        public bool OpenLine { get; set; }
        public int ReqNum { get; set; }
        public int ReqLine { get; set; }
        public string LineDesc { get; set; }
        public string Ium { get; set; }
        public decimal UnitCost { get; set; }
        public decimal DocUnitCost { get; set; }
        public bool Taxable { get; set; }
        public string Rum { get; set; }
        public string CostPerCode { get; set; }
        public string PartNum { get; set; }
        public string VenPartNum { get; set; }
        public string CommentText { get; set; }
        public string Class { get; set; }
        public string RevisionNum { get; set; }
        public bool RcvInspectionReq { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public decimal PurchasingFactor { get; set; }
        public DateTime? DueDate { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int PorelNum { get; set; }
        public string JobNum { get; set; }
        public int PrcConNum { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool LockRate { get; set; }
        public DateTime? ReqDate { get; set; }
        public decimal OrderQty { get; set; }
        public decimal XorderQty { get; set; }
        public string JobSeqType { get; set; }
        public string TranType { get; set; }
        public string GlbCompany { get; set; }
        public int GlbReqNum { get; set; }
        public int GlbReqLine { get; set; }
        public string PurchasingFactorDirection { get; set; }
        public decimal Rpt1UnitCost { get; set; }
        public decimal Rpt2UnitCost { get; set; }
        public decimal Rpt3UnitCost { get; set; }
        public string RateGrpCode { get; set; }
        public int MfgNum { get; set; }
        public string MfgPartNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool OverridePriceList { get; set; }
        public bool EpicorFsa { get; set; }
    }
}
