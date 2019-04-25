using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcOcevtRen
    {
        public string Company { get; set; }
        public decimal OcevtRenid { get; set; }
        public decimal OcmsgHeadId { get; set; }
        public decimal RadtlId { get; set; }
        public int CustNum { get; set; }
        public string EntryType { get; set; }
        public string PmtStatus { get; set; }
        public string PmtType { get; set; }
        public int BondAmt { get; set; }
        public bool PrevRacsbond { get; set; }
        public string PensionStatus { get; set; }
        public string CentreLinkNum { get; set; }
        public string Dvanum { get; set; }
        public string LiabilityType { get; set; }
        public DateTime? PreEntryDate { get; set; }
        public bool HighCare { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string OtherRacs { get; set; }
        public string ExtraService { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public string CareNeedsStatus { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public string ReceivingPriorCare { get; set; }
        public string ElectedMeansTesting { get; set; }
        public int AgreedAccomPrice { get; set; }
        public string PaymentArrangement { get; set; }
        public DateTime? UnfundedPriorEntryDt { get; set; }
    }
}
