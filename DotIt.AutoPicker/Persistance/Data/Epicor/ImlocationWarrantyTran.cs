using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImlocationWarrantyTran
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public long LocationNum { get; set; }
        public long WarrantySeqNum { get; set; }
        public string Idnum { get; set; }
        public string SerialNum { get; set; }
        public string Comment { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int HdcaseNum { get; set; }
        public string ParentPartNum { get; set; }
        public string OriginalPartNum { get; set; }
        public string OriginalPartSerialNum { get; set; }
        public string NewPartNum { get; set; }
        public string NewPartSerialNum { get; set; }
        public string PartDescription { get; set; }
        public string WarrantyCode { get; set; }
        public string WarrantyComment { get; set; }
        public DateTime? WarrantyStartDate { get; set; }
        public DateTime? WarrantyExpirationDate { get; set; }
        public string DealerWarranty { get; set; }
        public string DealerWarrantyDesc { get; set; }
        public DateTime? DealerWarrantyStart { get; set; }
        public DateTime? DealerWarrantyExpiration { get; set; }
        public string WarrantyUsage { get; set; }
        public string LotNum { get; set; }
        public bool SystemCreated { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
