using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImacPrpref
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal PrprefId { get; set; }
        public decimal Prid { get; set; }
        public int SeqNum { get; set; }
        public int Seg1Id { get; set; }
        public string SegCtcd { get; set; }
        public string SegTpCd { get; set; }
        public string SegFrgnCd { get; set; }
        public DateTime? DtforPref { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public int QuoteNum { get; set; }
        public int CustNum { get; set; }
        public int SegNum { get; set; }
    }
}
