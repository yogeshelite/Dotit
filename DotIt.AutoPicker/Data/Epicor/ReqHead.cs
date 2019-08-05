using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ReqHead
    {
        public string Company { get; set; }
        public bool OpenReq { get; set; }
        public int ReqNum { get; set; }
        public string RequestorId { get; set; }
        public DateTime? RequestDate { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipAddress3 { get; set; }
        public string ShipCity { get; set; }
        public string ShipState { get; set; }
        public string ShipZip { get; set; }
        public string ShipCountry { get; set; }
        public int PrcConNum { get; set; }
        public string CommentText { get; set; }
        public string ShipToConName { get; set; }
        public int ShipCountryNum { get; set; }
        public string ReqActionId { get; set; }
        public string CurrDispatcherId { get; set; }
        public bool NotifyUponReceipt { get; set; }
        public string Note { get; set; }
        public string StatusType { get; set; }
        public string GlbCompany { get; set; }
        public int GlbReqNum { get; set; }
        public string CpdispatcherId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
