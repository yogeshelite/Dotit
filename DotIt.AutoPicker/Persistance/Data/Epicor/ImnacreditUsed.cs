using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImnacreditUsed
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int CustNum { get; set; }
        public int Seq { get; set; }
        public string RelatedToFile { get; set; }
        public int KeyNum { get; set; }
        public string Source { get; set; }
        public int CreditCustNum { get; set; }
        public string CrdPoolCode { get; set; }
        public decimal CreditUsed { get; set; }
        public int GlbCustNum { get; set; }
        public string GlbCompany { get; set; }
        public string RlsClassCode { get; set; }
        public int TopCustNum { get; set; }
        public string ExtCompany { get; set; }
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
