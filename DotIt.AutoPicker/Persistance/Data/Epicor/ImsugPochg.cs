using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImsugPochg
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int PorelNum { get; set; }
        public string SuggestionCode { get; set; }
        public string BuyerId { get; set; }
        public DateTime? RequireDate { get; set; }
        public string SourceName { get; set; }
        public decimal SurplusQty { get; set; }
        public string CancelReason { get; set; }
        public string Plant { get; set; }
        public int ConNum { get; set; }
        public string Comment { get; set; }
        public bool VendorChange { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string ExtCompany { get; set; }
        public string GlbCompany { get; set; }
        public string Abccode { get; set; }
        public string SuggestionStatus { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool Review { get; set; }
    }
}
