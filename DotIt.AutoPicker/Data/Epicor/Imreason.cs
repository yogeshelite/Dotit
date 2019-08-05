﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imreason
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ReasonType { get; set; }
        public string ReasonCode { get; set; }
        public string Description { get; set; }
        public bool DmrrejOpr { get; set; }
        public bool DmrrejMtl { get; set; }
        public bool DmrrejSub { get; set; }
        public bool DmrrejInv { get; set; }
        public bool DmracceptOpr { get; set; }
        public bool DmracceptMtl { get; set; }
        public bool DmracceptSub { get; set; }
        public bool DmracceptInv { get; set; }
        public bool InspFailOpr { get; set; }
        public bool InspFailMtl { get; set; }
        public bool InspFailSub { get; set; }
        public bool InspFailInv { get; set; }
        public bool Scrap { get; set; }
        public bool NonConfOpr { get; set; }
        public bool NonConfMtl { get; set; }
        public bool NonConfSub { get; set; }
        public bool NonConfOther { get; set; }
        public bool Qacause { get; set; }
        public bool QacorrectiveAct { get; set; }
        public bool InvAdjCountDiscrepancy { get; set; }
        public bool Passed { get; set; }
        public bool GlobalReason { get; set; }
        public bool GlobalLock { get; set; }
        public string JdfworkType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool NonConfInv { get; set; }
        public bool ExternalMessyncRequired { get; set; }
        public DateTime? ExternalMeslastSync { get; set; }
    }
}
